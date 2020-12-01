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
    public partial class Provided : DevExpress.XtraEditors.XtraUserControl
    {
        private NhaCungCapRepo nhaCungCapRepo = new NhaCungCapRepo();
        private List<NhaCungCap> ncc;
        ProcessDataBase db = new ProcessDataBase();
        public Provided()
        {
            InitializeComponent();
        }

        private void Provided_Load(object sender, EventArgs e)
        {
            dtGVShowProvided.DataSource = nhaCungCapRepo.FindAll();
            ncc = nhaCungCapRepo.FindAll().ToList();
            dtGVShowProvided.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            dtGVShowProvided.Columns[0].Width = 130;
            dtGVShowProvided.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            dtGVShowProvided.Columns[1].Width = 130;
            dtGVShowProvided.Columns[2].HeaderText = "Địa chỉ";
            dtGVShowProvided.Columns[2].Width = 350;
            dtGVShowProvided.Columns[3].HeaderText = "Số Điện Thoại";
        }

        private void dtGVShowProvided_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtGVShowProvided.SelectedRows.Count == 0) return;
            var data = (NhaCungCap)dtGVShowProvided.SelectedRows[0].DataBoundItem;
            txtTenNcc.Text = data.TenNcc.ToString();
            txtDiaChi.Text = data.DiaChi.ToString();
            txtNcc.Text = data.MaNCC.ToString();
            txtSDT.Text = data.DienThoai.ToString();
            
        }

        private void dtGVShowProvided_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtGVShowProvided_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtGVShowProvided_Click(object sender, EventArgs e)
        {
            txtNcc.Text = dtGVShowProvided.CurrentRow.Cells[0].Value.ToString();
            txtTenNcc.Text = dtGVShowProvided.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dtGVShowProvided.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dtGVShowProvided.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtGVShowProvided.SelectedCells.Count == 0) return;
            var nhacungcap = new NhaCungCap()
            {
                MaNCC = txtNcc.Text,
                TenNcc = txtTenNcc.Text,
                DiaChi = txtDiaChi.Text,
                DienThoai = Convert.ToInt32(txtSDT.Text),
            };
            if (nhaCungCapRepo.Update(nhacungcap))
            {
                MessageBox.Show("Sửa thành công");
                reloadTable();
                txtNcc.ReadOnly = true;
                txtTenNcc.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                txtSDT.ReadOnly = true;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //db.CapNhatDuLieu("delete NhaCungCap where MaNCC=N'"+txtNcc.Text+"')");
            //dtGVShowProvided.DataSource = db.DocBang("select * from NhaCungCap");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var nhacungcap = new NhaCungCap()
            {
                MaNCC = txtNcc.Text,
                TenNcc = txtTenNcc.Text,
                DiaChi = txtDiaChi.Text,
                DienThoai = Convert.ToInt32(txtSDT.Text),
            };
            if (nhaCungCapRepo.Add(nhacungcap))
            {
                MessageBox.Show("Add thành công");
                reloadTable();
                txtNcc.ReadOnly = true;
                txtTenNcc.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                txtSDT.ReadOnly = true;
            }
        }
        private void reloadTable()
        {
            dtGVShowProvided.DataSource = nhaCungCapRepo.FindAll().Select(ncc => new NhaCungCapVM()
            {
                MaNCC = ncc.MaNCC,
                TenNcc = ncc.TenNcc,
                DiaChi = ncc.DiaChi,
                DienThoai = (int)ncc.DienThoai,

            }).ToList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtDiaChi.ReadOnly = false;
            txtNcc.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtTenNcc.ReadOnly = false;
            txtDiaChi.Text = "";
            txtNcc.Text = "";
            txtSDT.Text = "";
            txtTenNcc.Text = "";
        }
    }
}
