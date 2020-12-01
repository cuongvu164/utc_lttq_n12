
namespace LTTQ_BTL_N12.Forms
{
    partial class SearchBill
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBill));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchBill = new Bunifu.Framework.UI.BunifuThinButton2();
            this.rbtnNhanVien = new System.Windows.Forms.RadioButton();
            this.rbtnMahang = new System.Windows.Forms.RadioButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rbtnKhachhang = new System.Windows.Forms.RadioButton();
            this.cbbMaHang = new System.Windows.Forms.ComboBox();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.cbbKhachHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(881, 433);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.ActiveBorderThickness = 1;
            this.btnSearchBill.ActiveCornerRadius = 40;
            this.btnSearchBill.ActiveFillColor = System.Drawing.Color.White;
            this.btnSearchBill.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnSearchBill.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnSearchBill.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchBill.BackgroundImage")));
            this.btnSearchBill.ButtonText = "Tìm kiếm";
            this.btnSearchBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBill.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBill.ForeColor = System.Drawing.Color.White;
            this.btnSearchBill.IdleBorderThickness = 1;
            this.btnSearchBill.IdleCornerRadius = 40;
            this.btnSearchBill.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnSearchBill.IdleForecolor = System.Drawing.Color.White;
            this.btnSearchBill.IdleLineColor = System.Drawing.Color.White;
            this.btnSearchBill.Location = new System.Drawing.Point(623, 117);
            this.btnSearchBill.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(170, 68);
            this.btnSearchBill.TabIndex = 13;
            this.btnSearchBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchBill.Click += new System.EventHandler(this.btnSearchBill_Click);
            // 
            // rbtnNhanVien
            // 
            this.rbtnNhanVien.AutoSize = true;
            this.rbtnNhanVien.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold);
            this.rbtnNhanVien.Location = new System.Drawing.Point(181, 146);
            this.rbtnNhanVien.Name = "rbtnNhanVien";
            this.rbtnNhanVien.Size = new System.Drawing.Size(147, 24);
            this.rbtnNhanVien.TabIndex = 10;
            this.rbtnNhanVien.TabStop = true;
            this.rbtnNhanVien.Text = "NV thực hiện";
            this.rbtnNhanVien.UseVisualStyleBackColor = true;
            this.rbtnNhanVien.CheckedChanged += new System.EventHandler(this.rbtnNhanVien_CheckedChanged);
            // 
            // rbtnMahang
            // 
            this.rbtnMahang.AutoSize = true;
            this.rbtnMahang.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMahang.Location = new System.Drawing.Point(181, 100);
            this.rbtnMahang.Name = "rbtnMahang";
            this.rbtnMahang.Size = new System.Drawing.Size(95, 24);
            this.rbtnMahang.TabIndex = 9;
            this.rbtnMahang.TabStop = true;
            this.rbtnMahang.Text = "Tên đĩa";
            this.rbtnMahang.UseVisualStyleBackColor = true;
            this.rbtnMahang.CheckedChanged += new System.EventHandler(this.rbtnMahang_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(97, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(171, 21);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Tìm kiếm hóa đơn bán:";
            // 
            // rbtnKhachhang
            // 
            this.rbtnKhachhang.AutoSize = true;
            this.rbtnKhachhang.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold);
            this.rbtnKhachhang.Location = new System.Drawing.Point(181, 188);
            this.rbtnKhachhang.Name = "rbtnKhachhang";
            this.rbtnKhachhang.Size = new System.Drawing.Size(138, 24);
            this.rbtnKhachhang.TabIndex = 15;
            this.rbtnKhachhang.TabStop = true;
            this.rbtnKhachhang.Text = "Khách hàng";
            this.rbtnKhachhang.UseVisualStyleBackColor = true;
            this.rbtnKhachhang.CheckedChanged += new System.EventHandler(this.rbtnKhachhang_CheckedChanged);
            // 
            // cbbMaHang
            // 
            this.cbbMaHang.FormattingEnabled = true;
            this.cbbMaHang.Location = new System.Drawing.Point(370, 100);
            this.cbbMaHang.Name = "cbbMaHang";
            this.cbbMaHang.Size = new System.Drawing.Size(201, 24);
            this.cbbMaHang.TabIndex = 16;
            // 
            // cbbNV
            // 
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(370, 146);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(201, 24);
            this.cbbNV.TabIndex = 17;
            // 
            // cbbKhachHang
            // 
            this.cbbKhachHang.FormattingEnabled = true;
            this.cbbKhachHang.Location = new System.Drawing.Point(370, 190);
            this.cbbKhachHang.Name = "cbbKhachHang";
            this.cbbKhachHang.Size = new System.Drawing.Size(201, 24);
            this.cbbKhachHang.TabIndex = 18;
            // 
            // SearchBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbbKhachHang);
            this.Controls.Add(this.cbbNV);
            this.Controls.Add(this.cbbMaHang);
            this.Controls.Add(this.rbtnKhachhang);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearchBill);
            this.Controls.Add(this.rbtnNhanVien);
            this.Controls.Add(this.rbtnMahang);
            this.Controls.Add(this.labelControl1);
            this.Name = "SearchBill";
            this.Size = new System.Drawing.Size(881, 689);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearchBill;
        private System.Windows.Forms.RadioButton rbtnNhanVien;
        private System.Windows.Forms.RadioButton rbtnMahang;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RadioButton rbtnKhachhang;
        private System.Windows.Forms.ComboBox cbbMaHang;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.ComboBox cbbKhachHang;
    }
}
