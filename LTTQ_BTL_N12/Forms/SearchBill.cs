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
    
    public partial class SearchBill : UserControl
    {
        private KhoDiaRepo khoDiaRepo = new KhoDiaRepo();
        private NhanVienRepo nhanVienRepo = new NhanVienRepo();
        private KhachHangRepo khachHangRepo = new KhachHangRepo();

        private List<NhanVien> nv;
        private List<KhachHang> kh;
        private List<KhoDia> kd;
        public SearchBill()
        {
            InitializeComponent();
            kd = khoDiaRepo.FindAll().ToList();
            kh = khachHangRepo.FindAll().ToList();
            nv = nhanVienRepo.FindAll().ToList();

            cbbKhachHang.DisplayMember = "TenKhach";
            cbbKhachHang.ValueMember = "MaKhach";
            cbbKhachHang.DataSource = kh;

            cbbMaHang.DisplayMember = "TenDia";
            cbbMaHang.ValueMember = "MaDia";
            cbbMaHang.DataSource = kd;

            cbbNV.DisplayMember = "TenNV";
            cbbNV.ValueMember = "MaNV";
            cbbNV.DataSource = nv;
        }

        private void rbtnMahang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnNhanVien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnKhachhang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            var maDia = ((KhoDia)cbbMaHang.SelectedItem).MaDia;
            var maKhachHang = ((KhachHang)cbbKhachHang.SelectedItem).MaKhach;
            var maNhanVien = ((NhanVien)cbbNV.SelectedItem).MaNV;
            var rs = khoDiaRepo.context.KhoDias.AsQueryable();
            var rskh = khachHangRepo.context.KhachHangs.AsQueryable();
            var rsnv = nhanVienRepo.context.NhanViens.AsQueryable();
            if (rbtnMahang.Checked)
            {
                rs = rs.Where(d => d.MaDia.Equals(maDia)).AsQueryable();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = rs.ToList();
            }
            if (rbtnKhachhang.Checked)
            {
                rskh = rskh.Where(d => d.MaKhach.Equals(maKhachHang)).AsQueryable();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = rskh.ToList();
            }
            if (rbtnNhanVien.Checked)
            {
                rsnv = rsnv.Where(d => d.MaNV.Equals(maNhanVien)).AsQueryable();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = rsnv.ToList();
            }
            
        }
    }
}
