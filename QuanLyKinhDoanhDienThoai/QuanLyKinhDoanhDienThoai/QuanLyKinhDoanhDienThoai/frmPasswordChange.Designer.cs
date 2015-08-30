namespace QuanLyKinhDoanhDienThoai
{
    partial class frmPasswordChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtOld_Pass = new System.Windows.Forms.TextBox();
            this.txtNew_Pass = new System.Windows.Forms.TextBox();
            this.txtNew_Pass_EnterAgain = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu mới:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Location = new System.Drawing.Point(174, 44);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(136, 20);
            this.txtUserName.TabIndex = 4;
            // 
            // txtOld_Pass
            // 
            this.txtOld_Pass.Location = new System.Drawing.Point(174, 79);
            this.txtOld_Pass.Name = "txtOld_Pass";
            this.txtOld_Pass.PasswordChar = '*';
            this.txtOld_Pass.Size = new System.Drawing.Size(136, 20);
            this.txtOld_Pass.TabIndex = 5;
            // 
            // txtNew_Pass
            // 
            this.txtNew_Pass.Location = new System.Drawing.Point(174, 114);
            this.txtNew_Pass.Name = "txtNew_Pass";
            this.txtNew_Pass.PasswordChar = '*';
            this.txtNew_Pass.Size = new System.Drawing.Size(136, 20);
            this.txtNew_Pass.TabIndex = 6;
            // 
            // txtNew_Pass_EnterAgain
            // 
            this.txtNew_Pass_EnterAgain.Location = new System.Drawing.Point(174, 152);
            this.txtNew_Pass_EnterAgain.Name = "txtNew_Pass_EnterAgain";
            this.txtNew_Pass_EnterAgain.PasswordChar = '*';
            this.txtNew_Pass_EnterAgain.Size = new System.Drawing.Size(136, 20);
            this.txtNew_Pass_EnterAgain.TabIndex = 7;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(108, 212);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(170, 23);
            this.btnChangePass.TabIndex = 8;
            this.btnChangePass.Text = "Xác nhận thay đổi";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // frmPasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 261);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.txtNew_Pass_EnterAgain);
            this.Controls.Add(this.txtNew_Pass);
            this.Controls.Add(this.txtOld_Pass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPasswordChange";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmPasswordChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtOld_Pass;
        private System.Windows.Forms.TextBox txtNew_Pass;
        private System.Windows.Forms.TextBox txtNew_Pass_EnterAgain;
        private System.Windows.Forms.Button btnChangePass;
    }
}