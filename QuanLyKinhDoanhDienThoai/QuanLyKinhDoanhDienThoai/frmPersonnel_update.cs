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
    public partial class frmPersonnel_update : Form
    {
        SqlConnection conn;
        public frmPersonnel_update()
        {
            InitializeComponent();
        }

        private void frmPersonnel_update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLIKINHDOANHDIENTHOAIDataSet.tblPersonnel' table. You can move, or remove it, as needed.
            this.tblPersonnelTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblPersonnel);
            String strCon = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            conn = new SqlConnection(strCon);
            conn.Open();
            Share.update_data_dgv(Share.Select_tblPersonnel, dgvPersonnel, txtTotalPersonnel, " nhân viên");
        }

        private void tsmiPersonnel_New_Click(object sender, EventArgs e)
        {
            txtPersonnel_Id.Enabled = false;
            txtPersonnel_Name.Focus();
            label44.Hide();
            txtPersonnel_Id.Text = "addnew";
            txtPersonnel_Id.Hide();
            txtPersonnel_Name.Text = "";
            txtPersonnel_Competance.Text = "";
            txtPersonnel_Address.Text = "";
            txtPersonnel_Phone.Text = "";
        }

        private void tsmiPersonnel_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPersonnel_Id.Text == "")
                {
                    MessageBox.Show("Hãy nhập thông tin nhân viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPersonnel_Id.Focus();
                }
                else
                {
                    if (txtPersonnel_Id.Text != "addnew")
                    {
                        String strSQL = @"Update [tblPersonnel] set [Name]=@name, [Competence]=@competence, [Address]=@address, [Phone]=@phone where [Id]=@id";
                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add(new SqlParameter("id", txtPersonnel_Id.Text));
                        cmd.Parameters.Add(new SqlParameter("name", txtPersonnel_Name.Text));
                        cmd.Parameters.Add(new SqlParameter("competence", txtPersonnel_Competance.Text));
                        cmd.Parameters.Add(new SqlParameter("address", txtPersonnel_Address.Text));
                        cmd.Parameters.Add(new SqlParameter("phone", txtPersonnel_Phone.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lưu thay đổi thành công !");
                        Share.update_data_dgv(Share.Select_tblPersonnel, dgvPersonnel, txtTotalPersonnel, " nhân viên");
                    }
                    else
                    {
                        String strSQL = @"INSERT INTO tblPersonnel VALUES(@name, @competence, @address, @phone)";
                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add(new SqlParameter("name", txtPersonnel_Name.Text));
                        cmd.Parameters.Add(new SqlParameter("competence", txtPersonnel_Competance.Text));
                        cmd.Parameters.Add(new SqlParameter("address", txtPersonnel_Address.Text));
                        cmd.Parameters.Add(new SqlParameter("phone", txtPersonnel_Phone.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới thành công !");
                        Share.update_data_dgv(Share.Select_tblPersonnel, dgvPersonnel, txtTotalPersonnel, " nhân viên");
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
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên : '" + dgvPersonnel.CurrentRow.Cells[1].Value.ToString() + "' không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String idPersonnel = dgvPersonnel.CurrentRow.Cells[0].Value.ToString();
                    string strSQL = @"DELETE FROM tblPersonnel WHERE Id=@id";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("id", idPersonnel));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thông tin khách hàng : " + dgvPersonnel.CurrentRow.Cells[1].Value.ToString() + " đã bị xóa khỏi CSDL...!");
                    Share.update_data_dgv(Share.Select_tblPersonnel, dgvPersonnel, txtTotalPersonnel, " nhân viên");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn phải xóa các dữ liệu ràng buộc nhân viên : " + dgvPersonnel.CurrentRow.Cells[1].Value.ToString() + " trước khi xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvPersonnel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonnel_Id.Enabled = false;
            txtPersonnel_Id.Show();
            label44.Show();
            txtPersonnel_Id.Text = dgvPersonnel.CurrentRow.Cells[0].Value.ToString();
            txtPersonnel_Name.Text = dgvPersonnel.CurrentRow.Cells[1].Value.ToString();
            txtPersonnel_Competance.Text = dgvPersonnel.CurrentRow.Cells[2].Value.ToString();
            txtPersonnel_Address.Text = dgvPersonnel.CurrentRow.Cells[3].Value.ToString();
            txtPersonnel_Phone.Text = dgvPersonnel.CurrentRow.Cells[4].Value.ToString();
        }

        private void dgvPersonnel_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvPersonnel.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
