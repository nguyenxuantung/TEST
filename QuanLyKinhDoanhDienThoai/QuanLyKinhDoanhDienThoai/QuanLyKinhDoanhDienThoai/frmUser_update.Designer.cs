namespace QuanLyKinhDoanhDienThoai
{
    partial class frmUser_update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser_update));
            this.tctPersonnel = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.txtTotalUser = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.txtRule = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.tblUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLIKINHDOANHDIENTHOAIDataSet = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSet();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser_Name = new System.Windows.Forms.TextBox();
            this.menuStrip10 = new System.Windows.Forms.MenuStrip();
            this.tsmiPersonnel_New = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPersonnel_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPersonnel_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tblUserTableAdapter = new QuanLyKinhDoanhDienThoai.QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblUserTableAdapter();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tctPersonnel.SuspendLayout();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).BeginInit();
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
            this.tctPersonnel.TabIndex = 2;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.cbStatus);
            this.tabPage10.Controls.Add(this.txtTotalUser);
            this.tabPage10.Controls.Add(this.label31);
            this.tabPage10.Controls.Add(this.label40);
            this.tabPage10.Controls.Add(this.txtRule);
            this.tabPage10.Controls.Add(this.label41);
            this.tabPage10.Controls.Add(this.dgvUser);
            this.tabPage10.Controls.Add(this.label44);
            this.tabPage10.Controls.Add(this.label45);
            this.tabPage10.Controls.Add(this.txtPassword);
            this.tabPage10.Controls.Add(this.txtUser_Name);
            this.tabPage10.Controls.Add(this.menuStrip10);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(881, 625);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "Người dùng";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(623, 159);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(148, 17);
            this.cbStatus.TabIndex = 21;
            this.cbStatus.Text = "(Sử dụng/ngừng sử dụng)";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // txtTotalUser
            // 
            this.txtTotalUser.Location = new System.Drawing.Point(55, 598);
            this.txtTotalUser.Name = "txtTotalUser";
            this.txtTotalUser.Size = new System.Drawing.Size(180, 20);
            this.txtTotalUser.TabIndex = 20;
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
            this.label40.Location = new System.Drawing.Point(526, 122);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(67, 13);
            this.label40.TabIndex = 18;
            this.label40.Text = "Phân quyền:";
            // 
            // txtRule
            // 
            this.txtRule.Location = new System.Drawing.Point(622, 119);
            this.txtRule.Name = "txtRule";
            this.txtRule.Size = new System.Drawing.Size(217, 20);
            this.txtRule.TabIndex = 3;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(525, 159);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(61, 13);
            this.label41.TabIndex = 16;
            this.label41.Text = "Trạng thái :";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.passDataGridViewTextBoxColumn1,
            this.ruleDataGridViewTextBoxColumn1,
            this.statusDataGridViewCheckBoxColumn});
            this.dgvUser.DataSource = this.tblUserBindingSource;
            this.dgvUser.Location = new System.Drawing.Point(20, 40);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(473, 554);
            this.dgvUser.TabIndex = 10;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.dgvUser.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvUser_CellFormatting);
            // 
            // tblUserBindingSource
            // 
            this.tblUserBindingSource.DataMember = "tblUser";
            this.tblUserBindingSource.DataSource = this.qUANLIKINHDOANHDIENTHOAIDataSet;
            // 
            // qUANLIKINHDOANHDIENTHOAIDataSet
            // 
            this.qUANLIKINHDOANHDIENTHOAIDataSet.DataSetName = "QUANLIKINHDOANHDIENTHOAIDataSet";
            this.qUANLIKINHDOANHDIENTHOAIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(525, 44);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(58, 13);
            this.label44.TabIndex = 6;
            this.label44.Text = "Tài khoản:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(526, 82);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(55, 13);
            this.label45.TabIndex = 7;
            this.label45.Text = "Mật khẩu:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(622, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(217, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUser_Name
            // 
            this.txtUser_Name.Location = new System.Drawing.Point(622, 41);
            this.txtUser_Name.Name = "txtUser_Name";
            this.txtUser_Name.Size = new System.Drawing.Size(217, 20);
            this.txtUser_Name.TabIndex = 1;
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
            // tblUserTableAdapter
            // 
            this.tblUserTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Tài khoản";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // passDataGridViewTextBoxColumn1
            // 
            this.passDataGridViewTextBoxColumn1.DataPropertyName = "Pass";
            this.passDataGridViewTextBoxColumn1.HeaderText = "Mật khẩu";
            this.passDataGridViewTextBoxColumn1.Name = "passDataGridViewTextBoxColumn1";
            this.passDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ruleDataGridViewTextBoxColumn1
            // 
            this.ruleDataGridViewTextBoxColumn1.DataPropertyName = "Rule";
            this.ruleDataGridViewTextBoxColumn1.HeaderText = "Phân quyền";
            this.ruleDataGridViewTextBoxColumn1.Name = "ruleDataGridViewTextBoxColumn1";
            this.ruleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Trạng thái";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // frmUser_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 647);
            this.Controls.Add(this.tctPersonnel);
            this.Name = "frmUser_update";
            this.Text = "frmUser_update";
            this.Load += new System.EventHandler(this.frmUser_update_Load);
            this.tctPersonnel.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLIKINHDOANHDIENTHOAIDataSet)).EndInit();
            this.menuStrip10.ResumeLayout(false);
            this.menuStrip10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctPersonnel;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TextBox txtTotalUser;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtRule;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser_Name;
        private System.Windows.Forms.MenuStrip menuStrip10;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonnel_New;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonnel_Save;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonnel_Delete;
        private QUANLIKINHDOANHDIENTHOAIDataSet qUANLIKINHDOANHDIENTHOAIDataSet;
        private System.Windows.Forms.BindingSource tblUserBindingSource;
        private QUANLIKINHDOANHDIENTHOAIDataSetTableAdapters.tblUserTableAdapter tblUserTableAdapter;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}