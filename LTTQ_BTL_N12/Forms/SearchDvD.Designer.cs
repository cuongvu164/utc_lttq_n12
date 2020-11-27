
namespace LTTQ_BTL_N12.Forms
{
    partial class SearchDvD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDvD));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.rbtnCategory = new System.Windows.Forms.RadioButton();
            this.rbtnProducer = new System.Windows.Forms.RadioButton();
            this.txtCategory = new DevExpress.XtraEditors.TextEdit();
            this.txtProducer = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(94, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 21);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tìm kiếm đĩa:";
            // 
            // rbtnCategory
            // 
            this.rbtnCategory.AutoSize = true;
            this.rbtnCategory.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCategory.Location = new System.Drawing.Point(178, 94);
            this.rbtnCategory.Name = "rbtnCategory";
            this.rbtnCategory.Size = new System.Drawing.Size(103, 24);
            this.rbtnCategory.TabIndex = 2;
            this.rbtnCategory.TabStop = true;
            this.rbtnCategory.Text = "Thể loại";
            this.rbtnCategory.UseVisualStyleBackColor = true;
            this.rbtnCategory.CheckedChanged += new System.EventHandler(this.rbtnCategory_CheckedChanged);
            // 
            // rbtnProducer
            // 
            this.rbtnProducer.AutoSize = true;
            this.rbtnProducer.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold);
            this.rbtnProducer.Location = new System.Drawing.Point(178, 140);
            this.rbtnProducer.Name = "rbtnProducer";
            this.rbtnProducer.Size = new System.Drawing.Size(150, 24);
            this.rbtnProducer.TabIndex = 3;
            this.rbtnProducer.TabStop = true;
            this.rbtnProducer.Text = "Nhà Sản Xuất";
            this.rbtnProducer.UseVisualStyleBackColor = true;
            this.rbtnProducer.CheckedChanged += new System.EventHandler(this.rbtnProducer_CheckedChanged);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(360, 92);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Properties.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtCategory.Properties.Appearance.Options.UseFont = true;
            this.txtCategory.Properties.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(208, 26);
            this.txtCategory.TabIndex = 4;
            // 
            // txtProducer
            // 
            this.txtProducer.Location = new System.Drawing.Point(360, 137);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Properties.Appearance.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtProducer.Properties.Appearance.Options.UseFont = true;
            this.txtProducer.Properties.ReadOnly = true;
            this.txtProducer.Size = new System.Drawing.Size(208, 26);
            this.txtProducer.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveBorderThickness = 1;
            this.btnSearch.ActiveCornerRadius = 40;
            this.btnSearch.ActiveFillColor = System.Drawing.Color.White;
            this.btnSearch.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnSearch.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.ButtonText = "Tìm kiếm";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleCornerRadius = 40;
            this.btnSearch.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(250)))));
            this.btnSearch.IdleForecolor = System.Drawing.Color.White;
            this.btnSearch.IdleLineColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(622, 95);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(170, 68);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(850, 368);
            this.dataGridView1.TabIndex = 7;
            // 
            // SearchDvD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtProducer);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.rbtnProducer);
            this.Controls.Add(this.rbtnCategory);
            this.Controls.Add(this.labelControl1);
            this.Name = "SearchDvD";
            this.Size = new System.Drawing.Size(873, 587);
            ((System.ComponentModel.ISupportInitialize)(this.txtCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RadioButton rbtnCategory;
        private System.Windows.Forms.RadioButton rbtnProducer;
        private DevExpress.XtraEditors.TextEdit txtCategory;
        private DevExpress.XtraEditors.TextEdit txtProducer;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
