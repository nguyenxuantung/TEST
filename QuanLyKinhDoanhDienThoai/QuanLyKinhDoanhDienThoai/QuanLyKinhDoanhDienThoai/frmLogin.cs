using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKinhDoanhDienThoai
{
    public partial class frmLogin : Form
    {
        CurrentUser cu = new CurrentUser();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lbBanner_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.TextLength!=0 && txtPass.TextLength!=0)
            {
                if (checkLogin(txtUser.Text, txtPass.Text) == 1)
                {

                    frmMain frmmain = new frmMain(cu);
                    frmmain.Show();
                    this.Close();
                }
                else if (checkLogin(txtUser.Text, txtPass.Text) == 2)
                {
                    MessageBox.Show("Tài khoản này đã bị cấm sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu của bạn không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin tài khoản !", "Thông báo",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int checkLogin(string user, string pass)
        {
            AccessData acc = new AccessData();
            string strSQL = Share.select_tblUser;
            SqlDataReader reader = acc.ExecuteReader(strSQL);
            while (reader.Read())
            {
                if (reader[0].ToString() == user && reader[1].ToString() == pass)
                {
                    if ((bool)reader[3] == false)
                    {
                        return 2;
                    }
                    else
                    {
                        cu.Username = reader[0].ToString();
                        cu.Pass = reader[1].ToString();
                        cu.Rule = (int)reader[2];
                        cu.Status = (bool)reader[3];
                        return 1;
                    }
                }
            }
            return 0;
        }
    }
}
