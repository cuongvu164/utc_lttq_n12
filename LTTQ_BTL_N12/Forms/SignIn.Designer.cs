
namespace LTTQ_BTL_N12.Forms
{
    partial class SignIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.gBoxSignIn = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSignIn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.gBoxSignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxSignIn
            // 
            this.gBoxSignIn.Controls.Add(this.btnSignIn);
            this.gBoxSignIn.Controls.Add(this.btnExit);
            this.gBoxSignIn.Controls.Add(this.txtPass);
            this.gBoxSignIn.Controls.Add(this.labelControl2);
            this.gBoxSignIn.Controls.Add(this.txtUser);
            this.gBoxSignIn.Controls.Add(this.labelControl1);
            this.gBoxSignIn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxSignIn.Location = new System.Drawing.Point(393, 79);
            this.gBoxSignIn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.gBoxSignIn.Name = "gBoxSignIn";
            this.gBoxSignIn.Padding = new System.Windows.Forms.Padding(6);
            this.gBoxSignIn.Size = new System.Drawing.Size(372, 357);
            this.gBoxSignIn.TabIndex = 0;
            this.gBoxSignIn.TabStop = false;
            this.gBoxSignIn.Text = "Đăng nhập";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(22, 212);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(321, 36);
            this.txtPass.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(23, 169);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(22, 107);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(321, 36);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "User Name:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // btnExit
            // 
            this.btnExit.ActiveBorderThickness = 1;
            this.btnExit.ActiveCornerRadius = 40;
            this.btnExit.ActiveFillColor = System.Drawing.Color.White;
            this.btnExit.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnExit.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.ButtonText = "Đóng";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IdleBorderThickness = 1;
            this.btnExit.IdleCornerRadius = 40;
            this.btnExit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnExit.IdleForecolor = System.Drawing.Color.White;
            this.btnExit.IdleLineColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(203, 269);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 62);
            this.btnExit.TabIndex = 4;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnSignIn
            // 
            this.btnSignIn.ActiveBorderThickness = 1;
            this.btnSignIn.ActiveCornerRadius = 40;
            this.btnSignIn.ActiveFillColor = System.Drawing.Color.White;
            this.btnSignIn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnSignIn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignIn.BackgroundImage")));
            this.btnSignIn.ButtonText = "Đăng nhập";
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.IdleBorderThickness = 1;
            this.btnSignIn.IdleCornerRadius = 40;
            this.btnSignIn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnSignIn.IdleForecolor = System.Drawing.Color.White;
            this.btnSignIn.IdleLineColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(23, 269);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(5);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(140, 62);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Georgia", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(29, 348);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(334, 39);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Cửa hàng băng đĩa";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 507);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gBoxSignIn);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("SignIn.IconOptions.LargeImage")));
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.gBoxSignIn.ResumeLayout(false);
            this.gBoxSignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxSignIn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txtPass;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtUser;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}