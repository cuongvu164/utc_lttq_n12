using DevExpress.XtraEditors;
using LTTQ_BTL_N12.Core.Models;
using LTTQ_BTL_N12.Core.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ_BTL_N12.Forms
{
    public partial class Sales : DevExpress.XtraEditors.XtraUserControl
    {
        private KhachHangRepo khachHangRepo = new KhachHangRepo();
        private NhanVienRepo nhanVienRepo = new NhanVienRepo();
        private KhoDiaRepo khoDiaRepo = new KhoDiaRepo();


        private List<KhachHang> kh;
        private List<NhanVien> nv;
        private List<KhoDia> kd;

        private List<ChiTietHoaDonBan> cthdb = new List<ChiTietHoaDonBan>();

        private List<HoaDonBan> hdbList;

        public Sales()
        {
            InitializeComponent();
            kh = khachHangRepo.FindAll().ToList();
            nv = nhanVienRepo.FindAll().ToList();
            kd = khoDiaRepo.FindAll().ToList();

            comboBox2.DisplayMember = "TenKhach";
            comboBox2.ValueMember = "MaKhach";
            comboBox2.DataSource = kh;

            comboBox1.DisplayMember = "TenDia";
            comboBox1.ValueMember = "MaDia";
            comboBox1.DataSource = kd;

            comboBox3.DisplayMember = "TenNV";
            comboBox3.ValueMember = "MaNV";
            comboBox3.DataSource = nv;

            dataGridView2.DataSource = cthdb;
            cbbGiamGia.SelectedIndex = 0;

            hdbList = khoDiaRepo.context.HoaDonBans.ToList();
            dataGridView1.DataSource = hdbList;
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var shdb = Convert.ToInt32((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds).ToString();
            var ngayTao = DateTime.Now;
            var hdb = new HoaDonBan()
            {
                SoHDB = shdb,
                NgayBan = ngayTao,
                MaKhach = ((KhachHang)comboBox2.SelectedItem).MaKhach,
                MaNV = ((NhanVien)comboBox3.SelectedItem).MaNV,
                TongTien = Convert.ToDouble(txtTongTien.Text),
                ChiTietHoaDonBans = cthdb,
            };
            try
            {
                khoDiaRepo.context.HoaDonBans.Add(hdb);
                khoDiaRepo.context.SaveChanges();
                MessageBox.Show("Thêm mới hóa đơn bán thành công!");
                dataGridView1.DataSource = null;
                hdbList = khoDiaRepo.context.HoaDonBans.ToList();
                dataGridView1.DataSource = hdbList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            var dia = ((KhoDia)comboBox1.SelectedItem);
            var sl = (int)numericUpDown1.Value;
            var gg = Convert.ToDouble(cbbGiamGia.SelectedItem);
            var tt = ((KhoDia)comboBox1.SelectedItem).DonGiaBan * (1 - gg) * sl;
            textEdit1.Text = tt.ToString();
            var cthd = new ChiTietHoaDonBan()
            {
                MaChiTietHoaDonBan = Convert.ToInt32((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds).ToString(),
                MaDia = dia.MaDia,
                SoLuong = (int)numericUpDown1.Value,
                GiamGIa = gg,
                ThanhTien = tt,
            };
            var exist = cthdb.Where(i => i.MaDia.Equals(dia.MaDia)).FirstOrDefault();
            if (exist != null)
            {
                cthdb.Remove(exist);
            }
            cthdb.Add(cthd);
            txtTongTien.Text = cthdb.Select(i => i.ThanhTien)
                .Aggregate(Convert.ToDouble(0), (acc, cur) => acc + cur)
                .ToString();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = cthdb;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            var data = (HoaDonBan)dataGridView1.SelectedRows[0].DataBoundItem;

            cthdb = data.ChiTietHoaDonBans.ToList();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = cthdb;

            comboBox3.SelectedItem = nv.Where(i => i.MaNV.Equals(data.MaNV)).FirstOrDefault();
            comboBox2.SelectedItem = kh.Where(i => i.MaKhach.Equals(data.MaKhach)).FirstOrDefault();
            txtSHD.Text = data.SoHDB.ToString();
            txtNgay.Text = data.NgayBan.ToString();
            txtTongTien.Text = data.TongTien.ToString();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            var data = (ChiTietHoaDonBan)dataGridView2.SelectedRows[0].DataBoundItem;

            comboBox1.SelectedItem = kd.Where(i => i.MaDia.Equals(data.MaDia)).FirstOrDefault();
            numericUpDown1.Value = Convert.ToDecimal(data.SoLuong);
            cbbGiamGia.SelectedItem = Convert.ToInt32(data.GiamGIa);
            textEdit1.Text = Convert.ToString(data.ThanhTien);
        }
    }
}
