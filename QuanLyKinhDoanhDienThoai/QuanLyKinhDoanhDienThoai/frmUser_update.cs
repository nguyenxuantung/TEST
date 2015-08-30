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
    public partial class frmUser_update : Form
    {
        SqlConnection conn;
        public frmUser_update()
        {
            InitializeComponent();
        }

        private void frmUser_update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLIKINHDOANHDIENTHOAIDataSet.tblUser' table. You can move, or remove it, as needed.
            this.tblUserTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblUser);

            String strCon = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            conn = new SqlConnection(strCon);
            conn.Open();
        }

        private void tsmiPersonnel_New_Click(object sender, EventArgs e)
        {
            txtUser_Name.Focus();
            txtUser_Name.Text = "";
            txtPassword.Text = "";
            txtRule.Text = "";
            cbStatus.Checked = true;
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUser_Name.Enabled = false;
            txtPassword.Enabled = false;
            txtUser_Name.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            txtPassword.Text = dgvUser.CurrentRow.Cells[1].Value.ToString();
            txtRule.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
            cbStatus.Checked = (bool)dgvUser.CurrentRow.Cells[3].Value;
        }

        private void tsmiPersonnel_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser_Name.Text == "")
                {
                    MessageBox.Show("Hãy nhập thông tin người dùng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser_Name.Focus();
                }
                else
                {
                    if (txtUser_Name.Enabled == false)
                    {
                        String strSQL = @"Update [tblUser] set [Pass]=@pass, [Rule]=@rule, [Status]=@status where [Name]=@name";
                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add(new SqlParameter("name", txtUser_Name.Text));
                        cmd.Parameters.Add(new SqlParameter("pass", txtPassword.Text));
                        cmd.Parameters.Add(new SqlParameter("rule", txtRule.Text));
                        cmd.Parameters.Add(new SqlParameter("status", cbStatus.Checked.ToString()));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lưu thay đổi thành công !");
                        Share.update_data_dgv(Share.Select_tblUser, dgvUser, txtTotalUser, " tài khoản");
                    }
                    else
                    {
                        String strSQL = @"INSERT INTO tblUser VALUES(@name, @pass, @rule, @status)";
                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add(new SqlParameter("name", txtUser_Name.Text));
                        cmd.Parameters.Add(new SqlParameter("pass", txtPassword.Text));
                        cmd.Parameters.Add(new SqlParameter("rule", txtRule.Text));
                        cmd.Parameters.Add(new SqlParameter("status", cbStatus.Checked.ToString()));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới thành công !");
                        Share.update_data_dgv(Share.Select_tblUser, dgvUser, txtTotalUser, " tài khoản");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsmiPersonnel_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản : '" + dgvUser.CurrentRow.Cells[0].Value.ToString() + "' không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String idUser = dgvUser.CurrentRow.Cells[0].Value.ToString();
                    string strSQL = @"DELETE FROM tblUser WHERE Name=@name";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("name", idUser));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thông tin tài khoản : " + dgvUser.CurrentRow.Cells[0].Value.ToString() + " đã bị xóa khỏi CSDL...!");
                    Share.update_data_dgv(Share.Select_tblUser, dgvUser, txtTotalUser, " tài khoản");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn phải xóa các dữ liệu ràng buộc tài khoản : " + dgvUser.CurrentRow.Cells[0].Value.ToString() + " trước khi xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUser.Columns[e.ColumnIndex].Name == "PassDataGridViewTextBoxColumn" && e.Value != null)
            {
                dgvUser.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }
    }
}
