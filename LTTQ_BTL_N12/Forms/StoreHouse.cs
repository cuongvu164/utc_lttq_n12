using DevExpress.XtraEditors;
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
    public partial class StoreHouse : DevExpress.XtraEditors.XtraUserControl
    {
        private KhoDiaRepo khoDiaRepo = new KhoDiaRepo();
        private NoiSanXuatRepo noiSanXuatRepo = new NoiSanXuatRepo();
        private TheLoaiRepo theLoaiRepo = new TheLoaiRepo();

        ProcessDataBase db = new ProcessDataBase();
        private List<NoiSanXuat> nsx;
        private List<TheLoai> tl;
        public StoreHouse()
        {
            InitializeComponent();
        }

        private void StoreHouse_Load(object sender, EventArgs e)
        {
            reloadTable();
            nsx = noiSanXuatRepo.FindAll().ToList();
            tl = theLoaiRepo.FindAll().ToList();

            cbbNSX.DisplayMember = "TenNSX";
            cbbNSX.ValueMember = "MaNSX";
            cbbNSX.DataSource = nsx;

            cbbTL.DisplayMember = "TenTheLoai";
            cbbTL.ValueMember = "MaTheLoai";
            cbbTL.DataSource = tl;
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtGVShowStoreHouse.SelectedCells.Count == 0) return;
            var dia = new KhoDia()
            {
                TenDia = txtTenDia.Text,
                MaDia = txtMDia.Text,
                DonGiaBan = Convert.ToInt32(txtDGBan.Text),
                DonGiaNhap = Convert.ToInt32(txtDGNhap.Text),
                SoLuong = Convert.ToInt32(numUD.Value),
                MaNSX = ((NoiSanXuat)cbbNSX.SelectedItem).MaNSX,
                MaTheLoai = ((TheLoai)cbbTL.SelectedItem).MaTheLoai,
            };
            if (khoDiaRepo.Update(dia))
            {
                MessageBox.Show("Cap nhat thanh cong");
                reloadTable();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var data = (List<KhoDiaVM>) dtGVShowStoreHouse.DataSource;
                ExcelUtil.ExportExcel<KhoDiaVM>(data, @"E:\utc_lttq_n12\khodia.xlsx", "Kho Đĩa");
                MessageBox.Show("Xuất báo cáo thành công!\nE:\\utc_lttq_n12\\khodia.xlsx");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reloadTable()
        {
            dtGVShowStoreHouse.DataSource = khoDiaRepo.FindAll().Select(kd => new KhoDiaVM()
            { 
                MaDia = kd.MaDia,
                DonGiaBan = kd.DonGiaBan,
                TenDia=kd.TenDia,
                SoLuong=kd.SoLuong,
                DonGiaNhap=kd.DonGiaNhap,
                TenNoiSanXuat=kd.NoiSanXuat.TenNSX,
                TenTheLoai=kd.TheLoai.TenTheLoai,
                MaTheLoai=kd.TheLoai.MaTheLoai,
                MaNSX=kd.NoiSanXuat.MaNSX,
                GhiChu=kd.GhiChu,
            }).ToList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult remove = MessageBox.Show("Bạn có xóa dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (remove == System.Windows.Forms.DialogResult.Yes)
            {

                db.CapNhatDuLieu("delete KhoDia where MaDia=N'"+txtMDia.Text+"'");
                dtGVShowStoreHouse.DataSource = db.DocBang("select * from KhoDia");
            }
        }

        private void dtGVShowStoreHouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGVShowStoreHouse.SelectedRows.Count == 0)
            {
                return;
            }
            var data = (KhoDiaVM)dtGVShowStoreHouse.SelectedRows[0].DataBoundItem;
            txtMDia.Text = data.MaDia;
            txtTenDia.Text = data.TenDia;
            numUD.Text = data.SoLuong.ToString();
            txtDGBan.Text = data.DonGiaBan.ToString();
            txtDGNhap.Text = data.DonGiaNhap.ToString();
            cbbNSX.SelectedItem = nsx.Where(i => i.MaNSX.Equals(data.MaNSX)).FirstOrDefault();
            cbbTL.SelectedItem= tl.Where(i => i.MaTheLoai.Equals(data.MaTheLoai)).FirstOrDefault();
        }
    }
}
