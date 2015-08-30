using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace QuanLyKinhDoanhDienThoai
{
    public partial class frmPasswordChange : Form
    {
        CurrentUser cu;
        String pass = "";
        SqlConnection conn;

        public frmPasswordChange(CurrentUser cu)
        {
            InitializeComponent();
            this.cu = cu;
            
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            AccessData acc = new AccessData();
            string StrSQL = Share.select_tblUser;
            SqlDataReader reader = acc.ExecuteReader(StrSQL);
            while (reader.Read())
            {
                if (reader[0].ToString() == cu.Username)
                {
                     pass = reader[1].ToString();
                     break;
                }
            }
            
            if (txtOld_Pass.Text.CompareTo(pass) != 0)
            {
                MessageBox.Show("Mật khẩu cũ không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOld_Pass.Text = "";
                txtOld_Pass.Focus();
            }
            else
            {
                if (txtNew_Pass.Text.CompareTo(txtNew_Pass_EnterAgain.Text) != 0)
                {
                    MessageBox.Show("Nhập lại mật khẩu mới không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNew_Pass_EnterAgain.Focus();
                }
                else
                {
                    cu.Pass = txtNew_Pass.Text;
                    StrSQL = @"Update [tblUser] set [Pass]=@pass where [Name]=@name";
                    SqlCommand cmd = new SqlCommand(StrSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("name", txtUserName.Text));
                    cmd.Parameters.Add(new SqlParameter("pass", txtNew_Pass.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mật khẩu thay đổi thành công !");
                    this.Close();

                    frmUserInfomation frm_ui = new frmUserInfomation(cu);
                    frm_ui.Show();
                }
            }
        }

        private void frmPasswordChange_Load(object sender, EventArgs e)
        {
            txtOld_Pass.Focus();
            txtUserName.Text = cu.Username;

            String strConn = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            conn = new SqlConnection(strConn);
            conn.Open();
        }
    }
}
