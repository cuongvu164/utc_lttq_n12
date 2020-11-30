using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LTTQ_BTL_N12.Core.Repos;
using System.Data.Common;

namespace LTTQ_BTL_N12.Forms
{
    public partial class SignIn : DevExpress.XtraEditors.XtraForm
    {
        DbConnection db;
        ProcessDataBase dtBase = new ProcessDataBase();
        public SignIn()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            if (checkValid())
            {
                if (checkLogin())
                {
                    var home = new Home();
                    home.Visible = true;
                    //using (Home home = new Home())
                    //{
                    //    home.ShowDialog();
                    //    this.Visible = false;
                    //}
                    this.Visible = false;
                }
            }
        }
        private bool checkLogin()
        {
            string username = "select MaNV from NhanVien where MaNV = N'" + txtUser.Text + "' and TenNV = N'" + txtPass.Text+"''";
            if (username == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool checkValid()
        {
            if (txtUser.Text.ToString().Trim() == string.Empty || txtPass.Text.ToString().Trim() == string.Empty)
            {
                MessageBox.Show("Không được để trống ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}