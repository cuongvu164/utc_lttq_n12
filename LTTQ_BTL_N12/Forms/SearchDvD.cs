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
    public partial class SearchDvD : DevExpress.XtraEditors.XtraUserControl
    {
        private KhoDiaRepo khoDiaRepo = new KhoDiaRepo();
        private NoiSanXuatRepo noiSanXuatRepo = new NoiSanXuatRepo();
        private TheLoaiRepo theLoaiRepo = new TheLoaiRepo();

        private List<NoiSanXuat> nsx;
        private List<TheLoai> tl;

        public SearchDvD()
        {
            InitializeComponent();
            nsx = noiSanXuatRepo.FindAll().ToList();
            tl = theLoaiRepo.FindAll().ToList();

            comboBox2.DisplayMember = "TenNSX";
            comboBox2.ValueMember = "MaNSX";
            comboBox2.DataSource = nsx;

            comboBox1.DisplayMember = "TenTheLoai";
            comboBox1.ValueMember = "MaTheLoai";
            comboBox1.DataSource = tl;
        }

        private void rbtnCategory_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnProducer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var maNSX = ((NoiSanXuat)comboBox2.SelectedItem).MaNSX;
            var maTheLoai = ((TheLoai)comboBox1.SelectedItem).MaTheLoai;
            var rs = khoDiaRepo.context.KhoDias.AsQueryable();
            if (checkBox1.Checked)
            {
                rs = rs.Where(d => d.MaTheLoai.Equals(maTheLoai)).AsQueryable();
            }
            if (checkBox2.Checked)
            {
                rs = rs.Where(d => d.MaNSX.Equals(maNSX)).AsQueryable();
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = rs.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
