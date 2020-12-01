using LTTQ_BTL_N12.Core.Models;
using LTTQ_BTL_N12.Core.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ_BTL_N12.Forms
{
    public partial class PhieuNhap : UserControl
    {
        private NhaCungCapRepo nhaCungCapRepo = new NhaCungCapRepo();
        private NhanVienRepo nhanVienRepo = new NhanVienRepo();
        private KhoDiaRepo khoDiaRepo = new KhoDiaRepo();


        private List<NhaCungCap> ncc;
        private List<NhanVien> nv;
        private List<KhoDia> kd;

        private List<ChiTietHoaDonNhap> cthdn = new List<ChiTietHoaDonNhap>();

        private List<HoaDonNhap> hdnList;
        public PhieuNhap()
        {
            InitializeComponent();
            ncc = nhaCungCapRepo.FindAll().ToList();
            nv = nhanVienRepo.FindAll().ToList();
            kd = khoDiaRepo.FindAll().ToList();

            cbbNCC.DisplayMember = "TenNcc";
            cbbNCC.ValueMember = "MaNCC";
            cbbNCC.DataSource = ncc;

            cbbDia.DisplayMember = "TenDia";
            cbbDia.ValueMember = "MaDia";
            cbbDia.DataSource = kd;

            cbbNV.DisplayMember = "TenNV";
            cbbNV.ValueMember = "MaNV";
            cbbNV.DataSource = nv;

            dataGridView2.DataSource = cthdn;
            cbbGiamGia.SelectedIndex = 0;

            hdnList = khoDiaRepo.context.HoaDonNhaps.ToList();
            dataGridView1.DataSource = hdnList;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var dia = ((KhoDia)cbbDia.SelectedItem);
            var sl = (int)numicUD.Value;
            var gg = Convert.ToDouble(cbbGiamGia.SelectedItem);
            var tt = ((KhoDia)cbbDia.SelectedItem).DonGiaBan * (1 - gg) * sl;
            txtThanhTien.Text = tt.ToString();

            var cthd = new ChiTietHoaDonNhap()
            {
                MaChiTietHoaDonNhap = Convert.ToInt32((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds).ToString(),
                MaDia = dia.MaDia,
                SoLuong = (int)numicUD.Value,
                GiamGia = gg,
                DonGia = Convert.ToInt32(txtDonGia.Text),
                ThanhTien = tt,
            };

            var exist = cthdn.Where(i => i.MaDia.Equals(dia.MaDia)).FirstOrDefault();
            if (exist != null)
            {
                cthdn.Remove(exist);
            }

            cthdn.Add(cthd);

            txtTongTien.Text = cthdn.Select(i => i.ThanhTien)
                .Aggregate(Convert.ToDouble(0), (acc, cur) => acc + cur)
                .ToString();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = cthdn;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            var shdn = Convert.ToInt32((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds).ToString();
            var ngayTao = DateTime.Now;
            var hdn = new HoaDonNhap()
            {
                SoHDN = shdn,
                NgayNhap = ngayTao,
                MaNCC = ((NhaCungCap)cbbNCC.SelectedItem).MaNCC,
                MaNV = ((NhanVien)cbbNV.SelectedItem).MaNV,
                TongTien = Convert.ToDouble(txtTongTien.Text),
                ChiTietHoaDonNhaps = cthdn,
            };
            try
            {
                khoDiaRepo.context.HoaDonNhaps.Add(hdn);
                khoDiaRepo.context.SaveChanges();
                MessageBox.Show("Thêm mới hóa đơn nhập thành công!");
                dataGridView1.DataSource = null;
                hdnList = khoDiaRepo.context.HoaDonNhaps.ToList();
                dataGridView1.DataSource = hdnList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            var data = (HoaDonNhap)dataGridView1.SelectedRows[0].DataBoundItem;

            cthdn = data.ChiTietHoaDonNhaps.ToList();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = cthdn;

            cbbNV.SelectedItem = nv.Where(i => i.MaNV.Equals(data.MaNV)).FirstOrDefault();
            cbbNCC.SelectedItem = ncc.Where(i => i.MaNCC.Equals(data.MaNCC)).FirstOrDefault();
            txtHDN.Text = data.SoHDN.ToString();
            txtNgay.Text = data.NgayNhap.ToString();
            txtTongTien.Text = data.TongTien.ToString();
        }
    }
}
