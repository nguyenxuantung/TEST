namespace QuanLyKinhDoanhDienThoai
{
    partial class frmPersonnel_update
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonnel_update));
            this.tctPersonnel = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.txtTotalPersonnel = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txtPersonnel_Competance = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtPersonnel_Address = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtPersonnel_Phone = new System.Windows.Forms.TextBox();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonnelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLIKINHDOANHDIENTHOAIDataSet = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSet();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.txtPersonnel_Name = new System.Windows.Forms.TextBox();
            this.txtPersonnel_Id = new System.Windows.Forms.TextBox();
            this.menuStrip10 = new System.Windows.Forms.MenuStrip();
            this.tsmiPersonnel_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPersonnel_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPersonnel_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tblPersonnelTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblPersonnelTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tctPersonnel.SuspendLayout();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonnelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLIKINHDOANHDIENTHOAIDataSet)).BeginInit();
            this.menuStrip10.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctPersonnel
            // 
            this.tctPersonnel.Controls.Add(this.tabPage10);
            this.tctPersonnel.Location = new System.Drawing.Point(0, 0);
            this.tctPersonnel.Name = "tctPersonnel";
            this.tctPersonnel.SelectedIndex = 0;
            this.tctPersonnel.Size = new System.Drawing.Size(889, 651);
            this.tctPersonnel.TabIndex = 1;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.txtTotalPersonnel);
            this.tabPage10.Controls.Add(this.label31);
            this.tabPage10.Controls.Add(this.label40);
            this.tabPage10.Controls.Add(this.txtPersonnel_Competance);
            this.tabPage10.Controls.Add(this.label41);
            this.tabPage10.Controls.Add(this.txtPersonnel_Address);
            this.tabPage10.Controls.Add(this.label42);
            this.tabPage10.Controls.Add(this.txtPersonnel_Phone);
            this.tabPage10.Controls.Add(this.dgvPersonnel);
            this.tabPage10.Controls.Add(this.label44);
            this.tabPage10.Controls.Add(this.label45);
            this.tabPage10.Controls.Add(this.txtPersonnel_Name);
            this.tabPage10.Controls.Add(this.txtPersonnel_Id);
            this.tabPage10.Controls.Add(this.menuStrip10);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(881, 625);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "Nhân viên";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // txtTotalPersonnel
            // 
            this.txtTotalPersonnel.Location = new System.Drawing.Point(55, 598);
            this.txtTotalPersonnel.Name = "txtTotalPersonnel";
            this.txtTotalPersonnel.Size = new System.Drawing.Size(180, 20);
            this.txtTotalPersonnel.TabIndex = 20;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(17, 601);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(35, 13);
            this.label31.TabIndex = 19;
            this.label31.Text = "Tổng:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(554, 118);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(50, 13);
            this.label40.TabIndex = 18;
            this.label40.Text = "Chức vụ:";
            // 
            // txtPersonnel_Competance
            // 
            this.txtPersonnel_Competance.Location = new System.Drawing.Point(650, 115);
            this.txtPersonnel_Competance.Name = "txtPersonnel_Competance";
            this.txtPersonnel_Competance.Size = new System.Drawing.Size(217, 20);
            this.txtPersonnel_Competance.TabIndex = 3;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(554, 154);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(43, 13);
            this.label41.TabIndex = 16;
            this.label41.Text = "Địa chỉ:";
            // 
            // txtPersonnel_Address
            // 
            this.txtPersonnel_Address.Location = new System.Drawing.Point(650, 151);
            this.txtPersonnel_Address.Name = "txtPersonnel_Address";
            this.txtPersonnel_Address.Size = new System.Drawing.Size(217, 20);
            this.txtPersonnel_Address.TabIndex = 4;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(554, 190);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(70, 13);
            this.label42.TabIndex = 14;
            this.label42.Text = "Số điện thoại";
            // 
            // txtPersonnel_Phone
            // 
            this.txtPersonnel_Phone.Location = new System.Drawing.Point(650, 187);
            this.txtPersonnel_Phone.Name = "txtPersonnel_Phone";
            this.txtPersonnel_Phone.Size = new System.Drawing.Size(217, 20);
            this.txtPersonnel_Phone.TabIndex = 5;
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.AutoGenerateColumns = false;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn0,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.competenceDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dgvPersonnel.DataSource = this.tblPersonnelBindingSource;
            this.dgvPersonnel.Location = new System.Drawing.Point(20, 40);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(524, 554);
            this.dgvPersonnel.TabIndex = 10;
            this.dgvPersonnel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonnel_CellClick);
            this.dgvPersonnel.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPersonnel_RowPostPaint);
            // 
            // dataGridViewTextBoxColumn0
            // 
            this.dataGridViewTextBoxColumn0.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn0.HeaderText = "Mã NV";
            this.dataGridViewTextBoxColumn0.Name = "dataGridViewTextBoxColumn0";
            this.dataGridViewTextBoxColumn0.ReadOnly = true;
            this.dataGridViewTextBoxColumn0.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Họ và tên";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Competence";
            this.dataGridViewTextBoxColumn2.HeaderText = "Chức vụ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "SĐT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tblPersonnelBindingSource
            // 
            this.tblPersonnelBindingSource.DataMember = "tblPersonnel";
            this.tblPersonnelBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // qUANLIKINHDOANHDIENTHOAIDataSet
            // 
            this.qUANLIKINHDOANHDIENTHOAIDataSet.DataSetName = "QUANLIKINHDOANHDIENTHOAIDataSet";
            this.qUANLIKINHDOANHDIENTHOAIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(555, 44);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(75, 13);
            this.label44.TabIndex = 6;
            this.label44.Text = "Mã nhân viên:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(554, 82);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(57, 13);
            this.label45.TabIndex = 7;
            this.label45.Text = "Họ và tên:";
            // 
            // txtPersonnel_Name
            // 
            this.txtPersonnel_Name.Location = new System.Drawing.Point(650, 80);
            this.txtPersonnel_Name.Name = "txtPersonnel_Name";
            this.txtPersonnel_Name.Size = new System.Drawing.Size(217, 20);
            this.txtPersonnel_Name.TabIndex = 2;
            // 
            // txtPersonnel_Id
            // 
            this.txtPersonnel_Id.Location = new System.Drawing.Point(650, 41);
            this.txtPersonnel_Id.Name = "txtPersonnel_Id";
            this.txtPersonnel_Id.Size = new System.Drawing.Size(217, 20);
            this.txtPersonnel_Id.TabIndex = 1;
            // 
            // menuStrip10
            // 
            this.menuStrip10.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip10.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPersonnel_New,
            this.tsmiPersonnel_Save,
            this.tsmiPersonnel_Delete});
            this.menuStrip10.Location = new System.Drawing.Point(3, 3);
            this.menuStrip10.Name = "menuStrip10";
            this.menuStrip10.Size = new System.Drawing.Size(875, 24);
            this.menuStrip10.TabIndex = 9;
            this.menuStrip10.Text = "menuStrip10";
            // 
            // tsmiPersonnel_New
            // 
            this.tsmiPersonnel_New.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPersonnel_New.Image")));
            this.tsmiPersonnel_New.Name = "tsmiPersonnel_New";
            this.tsmiPersonnel_New.Size = new System.Drawing.Size(90, 20);
            this.tsmiPersonnel_New.Text = "Thêm mới";
            this.tsmiPersonnel_New.Click += new System.EventHandler(this.tsmiPersonnel_New_Click);
            // 
            // tsmiPersonnel_Save
            // 
            this.tsmiPersonnel_Save.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPersonnel_Save.Image")));
            this.tsmiPersonnel_Save.Name = "tsmiPersonnel_Save";
            this.tsmiPersonnel_Save.Size = new System.Drawing.Size(55, 20);
            this.tsmiPersonnel_Save.Text = "Lưu";
            this.tsmiPersonnel_Save.Click += new System.EventHandler(this.tsmiPersonnel_Save_Click);
            // 
            // tsmiPersonnel_Delete
            // 
            this.tsmiPersonnel_Delete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPersonnel_Delete.Image")));
            this.tsmiPersonnel_Delete.Name = "tsmiPersonnel_Delete";
            this.tsmiPersonnel_Delete.Size = new System.Drawing.Size(55, 20);
            this.tsmiPersonnel_Delete.Text = "Xóa";
            this.tsmiPersonnel_Delete.Click += new System.EventHandler(this.tsmiPersonnel_Delete_Click);
            // 
            // tblPersonnelTableAdapter
            // 
            this.tblPersonnelTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // competenceDataGridViewTextBoxColumn
            // 
            this.competenceDataGridViewTextBoxColumn.DataPropertyName = "Competence";
            this.competenceDataGridViewTextBoxColumn.HeaderText = "Competence";
            this.competenceDataGridViewTextBoxColumn.Name = "competenceDataGridViewTextBoxColumn";
            this.competenceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmPersonnel_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 645);
            this.Controls.Add(this.tctPersonnel);
            this.Name = "frmPersonnel_update";
            this.Text = "frmPersonnel_update";
            this.Load += new System.EventHandler(this.frmPersonnel_update_Load);
            this.tctPersonnel.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonnelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLIKINHDOANHDIENTHOAIDataSet)).EndInit();
            this.menuStrip10.ResumeLayout(false);
            this.menuStrip10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctPersonnel;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TextBox txtTotalPersonnel;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtPersonnel_Competance;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtPersonnel_Address;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtPersonnel_Phone;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtPersonnel_Name;
        private System.Windows.Forms.TextBox txtPersonnel_Id;
        private System.Windows.Forms.MenuStrip menuStrip10;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonnel_New;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonnel_Save;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonnel_Delete;
        private QUANLIKINHDOANHDIENTHOAIDataSet qUANLIKINHDOANHDIENTHOAIDataSet;
        private System.Windows.Forms.BindingSource tblPersonnelBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblPersonnelTableAdapter tblPersonnelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn0;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn competenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}