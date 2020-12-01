
namespace LTTQ_BTL_N12.Forms
{
    partial class StoreHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreHouse));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMDia = new DevExpress.XtraEditors.TextEdit();
            this.txtTenDia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.numUD = new System.Windows.Forms.NumericUpDown();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDGBan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDGNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cbbNSX = new System.Windows.Forms.ComboBox();
            this.cbbTL = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtGVShowStoreHouse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtMDia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDGBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDGNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVShowStoreHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Đĩa:";
            // 
            // txtMDia
            // 
            this.txtMDia.Location = new System.Drawing.Point(109, 41);
            this.txtMDia.Name = "txtMDia";
            this.txtMDia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMDia.Properties.Appearance.Options.UseFont = true;
            this.txtMDia.Properties.ReadOnly = true;
            this.txtMDia.Size = new System.Drawing.Size(117, 28);
            this.txtMDia.TabIndex = 1;
            // 
            // txtTenDia
            // 
            this.txtTenDia.Location = new System.Drawing.Point(109, 84);
            this.txtTenDia.Name = "txtTenDia";
            this.txtTenDia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDia.Properties.Appearance.Options.UseFont = true;
            this.txtTenDia.Size = new System.Drawing.Size(117, 28);
            this.txtTenDia.TabIndex = 3;
            this.txtTenDia.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 21);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên Đĩa:";
            // 
            // numUD
            // 
            this.numUD.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUD.Location = new System.Drawing.Point(109, 131);
            this.numUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUD.Name = "numUD";
            this.numUD.Size = new System.Drawing.Size(60, 28);
            this.numUD.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(16, 133);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 21);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Số Lượng:";
            // 
            // txtDGBan
            // 
            this.txtDGBan.Location = new System.Drawing.Point(426, 84);
            this.txtDGBan.Name = "txtDGBan";
            this.txtDGBan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGBan.Properties.Appearance.Options.UseFont = true;
            this.txtDGBan.Size = new System.Drawing.Size(117, 28);
            this.txtDGBan.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(299, 91);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(98, 21);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Đơn Giá Bán:";
            // 
            // txtDGNhap
            // 
            this.txtDGNhap.Location = new System.Drawing.Point(426, 41);
            this.txtDGNhap.Name = "txtDGNhap";
            this.txtDGNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGNhap.Properties.Appearance.Options.UseFont = true;
            this.txtDGNhap.Size = new System.Drawing.Size(117, 28);
            this.txtDGNhap.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(299, 48);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(108, 21);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Đơn Giá Nhập:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(587, 91);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(96, 21);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Mã Thể Loại:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(587, 48);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 21);
            this.labelControl7.TabIndex = 10;
            this.labelControl7.Text = "Mã NSX:";
            // 
            // cbbNSX
            // 
            this.cbbNSX.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNSX.FormattingEnabled = true;
            this.cbbNSX.Location = new System.Drawing.Point(714, 40);
            this.cbbNSX.Name = "cbbNSX";
            this.cbbNSX.Size = new System.Drawing.Size(119, 29);
            this.cbbNSX.TabIndex = 14;
            // 
            // cbbTL
            // 
            this.cbbTL.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTL.FormattingEnabled = true;
            this.cbbTL.Location = new System.Drawing.Point(714, 88);
            this.cbbTL.Name = "cbbTL";
            this.cbbTL.Size = new System.Drawing.Size(119, 29);
            this.cbbTL.TabIndex = 15;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEdit.Location = new System.Drawing.Point(376, 191);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(137, 47);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "   Sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRemove.Location = new System.Drawing.Point(631, 191);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(137, 47);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "   Xóa";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdd.Location = new System.Drawing.Point(109, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 47);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Xuất Excel";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnRemove);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.cbbTL);
            this.groupControl1.Controls.Add(this.cbbNSX);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtDGBan);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtDGNhap);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.numUD);
            this.groupControl1.Controls.Add(this.txtTenDia);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtMDia);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(0, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(881, 261);
            this.groupControl1.TabIndex = 24;
            this.groupControl1.Text = "Thông Tin Đĩa";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // dtGVShowStoreHouse
            // 
            this.dtGVShowStoreHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVShowStoreHouse.Location = new System.Drawing.Point(0, 313);
            this.dtGVShowStoreHouse.Name = "dtGVShowStoreHouse";
            this.dtGVShowStoreHouse.RowHeadersWidth = 51;
            this.dtGVShowStoreHouse.RowTemplate.Height = 24;
            this.dtGVShowStoreHouse.Size = new System.Drawing.Size(881, 324);
            this.dtGVShowStoreHouse.TabIndex = 25;
            this.dtGVShowStoreHouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVShowStoreHouse_CellClick);
            // 
            // StoreHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtGVShowStoreHouse);
            this.Controls.Add(this.groupControl1);
            this.Name = "StoreHouse";
            this.Size = new System.Drawing.Size(881, 637);
            this.Load += new System.EventHandler(this.StoreHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMDia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDGBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDGNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVShowStoreHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMDia;
        private DevExpress.XtraEditors.TextEdit txtTenDia;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.NumericUpDown numUD;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDGBan;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDGNhap;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox cbbNSX;
        private System.Windows.Forms.ComboBox cbbTL;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dtGVShowStoreHouse;
    }
}
