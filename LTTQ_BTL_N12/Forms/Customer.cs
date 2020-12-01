using DevExpress.XtraEditors;
using LTTQ_BTL_N12.Core.Repos;
using LTTQ_BTL_N12.Core.Models;
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
    public partial class Customer : DevExpress.XtraEditors.XtraUserControl
    {
        private KhachHangRepo khachHangRepo = new KhachHangRepo();
        private List<KhachHang> kh;

        public Customer()
        {           
            InitializeComponent();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //DialogResult notification = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            //if (notification == System.Windows.Forms.DialogResult.Yes)
            //{

            //}
        }

        private void dtgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvCustomer.SelectedRows.Count == 0) return;
            var data = (KhachHang)dtgvCustomer.SelectedRows[0].DataBoundItem;
            txtName.Text = data.TenKhach.ToString();
            txtAddress.Text = data.DiaChi.ToString();
            txtID.Text = data.MaKhach.ToString();
            txtPhoneNumber.Text = data.DienThoai.ToString();
            
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            dtgvCustomer.DataSource = khachHangRepo.FindAll();
            kh = khachHangRepo.FindAll().ToList();
            dtgvCustomer.Columns[0].HeaderText = "Mã Khách Hàng";
            dtgvCustomer.Columns[0].Width = 110;
            dtgvCustomer.Columns[1].HeaderText = "Tên Khách Hàng";
            dtgvCustomer.Columns[1].Width = 130;
            dtgvCustomer.Columns[2].HeaderText = "Địa chỉ";
            dtgvCustomer.Columns[2].Width = 350;
            dtgvCustomer.Columns[3].HeaderText = "Số Điện Thoại";
        }

        private void dtgvCustomer_Click(object sender, EventArgs e)
        {
            txtID.Text = dtgvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dtgvCustomer.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dtgvCustomer.CurrentRow.Cells[2].Value.ToString();
            txtPhoneNumber.Text = dtgvCustomer.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var khachhang = new KhachHang()
            {
                MaKhach = txtID.Text,
                TenKhach = txtName.Text,
                DiaChi = txtAddress.Text,
                DienThoai = Convert.ToInt32(txtPhoneNumber.Text),
            };
            if (khachHangRepo.Add(khachhang))
            {
                MessageBox.Show("Add thành công");
                reloadTable();
                txtAddress.ReadOnly = true;
                txtID.ReadOnly = true;
                txtName.ReadOnly = true;
                txtPhoneNumber.ReadOnly = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtgvCustomer.SelectedCells.Count == 0) return;
            var khachhang = new KhachHang()
            {
                MaKhach = txtID.Text,
                TenKhach = txtName.Text,
                DiaChi = txtAddress.Text,
                DienThoai = Convert.ToInt32(txtPhoneNumber.Text),
            };
            if (khachHangRepo.Update(khachhang))
            {
                MessageBox.Show("Sửa thành công");
                reloadTable();
                txtAddress.ReadOnly = true;
                txtID.ReadOnly = true;
                txtName.ReadOnly = true;
                txtPhoneNumber.ReadOnly = true;
            }
        }
        private void reloadTable()
        {
            dtgvCustomer.DataSource = khachHangRepo.FindAll().Select(kh => new KhachHangVM()
            {
                MaKhach = kh.MaKhach,
                TenKhach = kh.TenKhach,
                DiaChi = kh.DiaChi,
                DienThoai = (int)kh.DienThoai,

            }).ToList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtAddress.ReadOnly = false;
            txtID.ReadOnly = false;
            txtName.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
            txtAddress.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            txtPhoneNumber.Text = "";
        }
    }
}
