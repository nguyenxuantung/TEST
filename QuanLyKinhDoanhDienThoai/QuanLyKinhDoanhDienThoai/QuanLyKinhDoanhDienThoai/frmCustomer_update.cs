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
    public partial class frmCustomer_update : Form
    {
        SqlConnection conn;
        public frmCustomer_update()
        {
            InitializeComponent();
        }

        private void frmCustomer_update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLIKINHDOANHDIENTHOAIDataSet.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblCustomer);
            Share.update_data_dgv(Share.Select_tblCustomer, dgvCustomer, txtTotalCustomer, " khách hàng");

            String strCon = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            conn = new SqlConnection(strCon);
            conn.Open();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCustomerId.Enabled = false;
            txtCustomerId.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtCustomerName.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            txtCustomerAdress.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
            txtCustomerPhone.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
        }

        private void tmsiCustomer_New_Click(object sender, EventArgs e)
        {
            txtCustomerId.Enabled = true;
            txtCustomerId.Focus();
            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
            txtCustomerAdress.Text = "";
            txtCustomerId.Text = "";
        }

        private void tmsiCustomer_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerId.Text == "")
                {
                    MessageBox.Show("Hãy nhập thông tin khách hàng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCustomerId.Focus();
                }
                else
                {
                    if (txtCustomerId.Enabled == false)
                    {
                        String strSQL = @"Update [tblCustomer] set [Name]=@name, [Address]=@address, [Phone]=@phone where [Id]=@id";
                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add(new SqlParameter("id", txtCustomerId.Text));
                        cmd.Parameters.Add(new SqlParameter("name", txtCustomerName.Text));
                        cmd.Parameters.Add(new SqlParameter("address", txtCustomerAdress.Text));
                        cmd.Parameters.Add(new SqlParameter("phone", txtCustomerPhone.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lưu thay đổi thành công !");
                        Share.update_data_dgv(Share.Select_tblCustomer, dgvCustomer, txtTotalCustomer, " khách hàng");
                    }
                    else
                        if (txtCustomerId.Enabled == true)
                        {
                            String strSQL = @"INSERT INTO tblCustomer VALUES(@id, @name, @address, @phone)";
                            SqlCommand cmd = new SqlCommand(strSQL, conn);
                            cmd.Parameters.Add(new SqlParameter("id", txtCustomerId.Text));
                            cmd.Parameters.Add(new SqlParameter("name", txtCustomerName.Text));
                            cmd.Parameters.Add(new SqlParameter("address", txtCustomerAdress.Text));
                            cmd.Parameters.Add(new SqlParameter("phone", txtCustomerPhone.Text));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm mới thành công !");
                            Share.update_data_dgv(Share.Select_tblCustomer, dgvCustomer, txtTotalCustomer, " khách hàng");
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tmsiCustomer_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng : '" + dgvCustomer.CurrentRow.Cells[1].Value.ToString() + "' không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String idCustomer = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
                    string strSQL = @"DELETE FROM tblCustomer WHERE Id=@id";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("id", idCustomer));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thông tin khách hàng : " + dgvCustomer.CurrentRow.Cells[1].Value.ToString() + " đã bị xóa khỏi CSDL...!");
                    Share.update_data_dgv(Share.Select_tblCustomer, dgvCustomer, txtTotalCustomer, " khách hàng");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn phải xóa các dữ liệu ràng buộc khách hàng : " + dgvCustomer.CurrentRow.Cells[1].Value.ToString() + " trước khi xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCustomer_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvCustomer.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
