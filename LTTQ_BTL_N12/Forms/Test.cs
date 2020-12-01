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
    public partial class Test : Form
    {
        ProcessDataBase db = new ProcessDataBase();
        public Test()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Test_Load(object sender, EventArgs e)
        {
            var data = db.DocBang("select * from TheLoai");
            ExcelUtil.ExportExcel(data, @"E:\utc_lttq_n12\theloai.xlsx", "The Loai");
            MessageBox.Show("Xuất báo cáo thành công!\nE:\\utc_lttq_n12\\theloai.xlsx");
        }
    }
}
