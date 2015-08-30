using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKinhDoanhDienThoai
{
    public partial class frmUserInfomation : Form
    {
        CurrentUser cu;

        public frmUserInfomation(CurrentUser cu)
        {
            InitializeComponent();
            this.cu = cu;
        }

        private void btnPassword_change_Click(object sender, EventArgs e)
        {
            frmPasswordChange frmPC = new frmPasswordChange(cu);
            frmPC.Show();
            //this.Close();
        }

        private void frmUserInfomation_Load(object sender, EventArgs e)
        {
            txtUserName.Text = cu.Username;
            txtPassword.Text = cu.Pass;
            txtRule.Text = cu.Rule.ToString();
            cbStatus.Checked = cu.Status;
        }
    }
}
