namespace QuanLyKinhDoanhDienThoai
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMenuParent = new System.Windows.Forms.Panel();
            this.btn_User_Manager = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvMenu_child_admin = new System.Windows.Forms.DataGridView();
            this.menu_child = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMenuParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu_child_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuParent
            // 
            this.pnlMenuParent.Controls.Add(this.btn_User_Manager);
            this.pnlMenuParent.Controls.Add(this.button4);
            this.pnlMenuParent.Controls.Add(this.button3);
            this.pnlMenuParent.Controls.Add(this.button2);
            this.pnlMenuParent.Controls.Add(this.btn);
            this.pnlMenuParent.Controls.Add(this.btnList);
            this.pnlMenuParent.Location = new System.Drawing.Point(12, 425);
            this.pnlMenuParent.Name = "pnlMenuParent";
            this.pnlMenuParent.Size = new System.Drawing.Size(200, 272);
            this.pnlMenuParent.TabIndex = 16;
            // 
            // btn_User_Manager
            // 
            this.btn_User_Manager.BackColor = System.Drawing.Color.Turquoise;
            this.btn_User_Manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_User_Manager.Location = new System.Drawing.Point(0, 226);
            this.btn_User_Manager.Name = "btn_User_Manager";
            this.btn_User_Manager.Size = new System.Drawing.Size(200, 38);
            this.btn_User_Manager.TabIndex = 12;
            this.btn_User_Manager.Text = "Người dùng";
            this.btn_User_Manager.UseVisualStyleBackColor = false;
            this.btn_User_Manager.Click += new System.EventHandler(this.btn_User_Manager_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Turquoise;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 182);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 43);
            this.button4.TabIndex = 11;
            this.button4.Text = "Cấu hình";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Turquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(0, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 43);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cấu hình";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cấu hình";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Turquoise;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Location = new System.Drawing.Point(0, 50);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(200, 43);
            this.btn.TabIndex = 8;
            this.btn.Text = "Cấu hình";
            this.btn.UseVisualStyleBackColor = false;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Turquoise;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Location = new System.Drawing.Point(0, 6);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(200, 43);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "Danh mục";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(219, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(894, 685);
            this.pnlMain.TabIndex = 17;
            // 
            // dgvMenu_child_admin
            // 
            this.dgvMenu_child_admin.AllowUserToAddRows = false;
            this.dgvMenu_child_admin.AllowUserToDeleteRows = false;
            this.dgvMenu_child_admin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu_child_admin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenu_child_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu_child_admin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menu_child,
            this.id});
            this.dgvMenu_child_admin.Location = new System.Drawing.Point(12, 12);
            this.dgvMenu_child_admin.Name = "dgvMenu_child_admin";
            this.dgvMenu_child_admin.ReadOnly = true;
            this.dgvMenu_child_admin.RowHeadersVisible = false;
            this.dgvMenu_child_admin.RowTemplate.ReadOnly = true;
            this.dgvMenu_child_admin.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenu_child_admin.Size = new System.Drawing.Size(199, 398);
            this.dgvMenu_child_admin.TabIndex = 3;
            this.dgvMenu_child_admin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_child_admin_CellClick);
            // 
            // menu_child
            // 
            this.menu_child.HeaderText = "Danh mục";
            this.menu_child.MinimumWidth = 197;
            this.menu_child.Name = "menu_child";
            this.menu_child.ReadOnly = true;
            this.menu_child.Width = 197;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 709);
            this.Controls.Add(this.dgvMenu_child_admin);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenuParent);
            this.Name = "frmMain";
            this.Text = "CHƯƠNG TRÌNH QUẢN LÝ KINH DOANH ĐIỆN THOẠI";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenuParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu_child_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuParent;
        private System.Windows.Forms.Button btn_User_Manager;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvMenu_child_admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_child;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}