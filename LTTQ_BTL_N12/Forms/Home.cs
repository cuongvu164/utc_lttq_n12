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



namespace LTTQ_BTL_N12.Forms
{
    public partial class Home : DevExpress.XtraEditors.XtraForm
    {
        int panelWidth;
        bool isCollapsed;
        public Home()
        {
            InitializeComponent();
            panelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            moveSlide(btnLogOut);
            DialogResult logOut = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (logOut == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width += 10;
                if (panelLeft.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width -= 10;
                if (panelLeft.Width <= 62)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveSlide(btnSearch);
            XtraUserControl1 user = new XtraUserControl1();
            addPanel(user);
            
        }
        private void moveSlide(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }
        private void panelSlide_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            moveSlide(btnInput);
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            moveSlide(btnOutput);
        }

        private void btnStoreHouse_Click(object sender, EventArgs e)
        {
            moveSlide(btnStoreHouse);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            moveSlide(btnCustomer);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            moveSlide(btnSupplier);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void addPanel(UserControl usc)
        {
            panelMain.Controls.Clear();
            usc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(usc);
            usc.BringToFront();
        }
    }
}