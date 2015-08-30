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
    public partial class frmProviders_update : Form
    {
        SqlConnection conn;
        public frmProviders_update()
        {
            InitializeComponent();
        }

        private void frmProviders_update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLIKINHDOANHDIENTHOAIDataSet.tblProviders' table. You can move, or remove it, as needed.
            this.tblProvidersTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblProviders);

            String strCon = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            conn = new SqlConnection(strCon);
            conn.Open();

            Share.update_data_dgv(Share.Select_tblProviders, dgvProviders, txtProvider_Total, " nhà cung cấp");
        }

        private void dgvProviders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProviderId.Enabled = false;
            txtProviderId.Text = dgvProviders.CurrentRow.Cells[0].Value.ToString();
            txtProviderName.Text = dgvProviders.CurrentRow.Cells[1].Value.ToString();
            txtProvidersAddress.Text = dgvProviders.CurrentRow.Cells[2].Value.ToString();
            txtProvidersPhone.Text = dgvProviders.CurrentRow.Cells[3].Value.ToString();
            txtProvidersEmail.Text = dgvProviders.CurrentRow.Cells[4].Value.ToString();
            txtProvidersFax.Text = dgvProviders.CurrentRow.Cells[5].Value.ToString();
            txtProvidersTaxNumber.Text = dgvProviders.CurrentRow.Cells[6].Value.ToString();
        }

        private void tsmiProvidersAdd_Click(object sender, EventArgs e)
        {
            txtProviderId.Text = "";
            txtProviderName.Text = "";
            txtProvidersAddress.Text = "";
            txtProvidersEmail.Text = "";
            txtProvidersFax.Text = "";
            txtProvidersPhone.Text = "";
            txtProvidersTaxNumber.Text = "";
            txtProviderId.Focus();
            txtProviderId.Enabled = true;
        }

        private void tsmiProviderSave_Click(object sender, EventArgs e)
        {
            if (txtProviderId.Text.Length == 0 && txtProviderName.Text.Length == 0)
            {
                MessageBox.Show("Hãy nhập thông tin nhà cung cấp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProviderId.Focus();
            }
            else
            {
                if (txtProviderId.Enabled == true)
                {
                    String strSQL = @"INSERT INTO tblProviders VALUES(@id, @name, @address, @phone, @email, @fax, @taxnumber)";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("id", txtProviderId.Text));
                    cmd.Parameters.Add(new SqlParameter("name", txtProviderName.Text));
                    cmd.Parameters.Add(new SqlParameter("address", txtProvidersAddress.Text));
                    cmd.Parameters.Add(new SqlParameter("phone", txtProvidersPhone.Text));
                    cmd.Parameters.Add(new SqlParameter("email", txtProvidersEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("fax", txtProvidersFax.Text));
                    cmd.Parameters.Add(new SqlParameter("taxnumber", txtProvidersTaxNumber.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công !");
                    Share.update_data_dgv(Share.Select_tblProviders, dgvProviders, txtProvider_Total, " nhà cung cấp");
                }
                else
                {
                    try
                    {
                        String strSQL = @"Update [tblProviders] set [Name]=@name, [Address]=@address, [Phone]=@phone, [Email]=@email, [Fax]=@fax, [Taxnumber]=@taxnumber  Where Id=@id";
                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add(new SqlParameter("id", txtProviderId.Text));
                        cmd.Parameters.Add(new SqlParameter("name", txtProviderName.Text));
                        cmd.Parameters.Add(new SqlParameter("address", txtProvidersAddress.Text));
                        cmd.Parameters.Add(new SqlParameter("phone", txtProvidersPhone.Text));
                        cmd.Parameters.Add(new SqlParameter("email", txtProvidersEmail.Text));
                        cmd.Parameters.Add(new SqlParameter("fax", txtProvidersFax.Text));
                        cmd.Parameters.Add(new SqlParameter("taxnumber", txtProvidersTaxNumber.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lưu thay đổi thành công !");
                        Share.update_data_dgv(Share.Select_tblProviders, dgvProviders, txtProvider_Total, " nhà cung cấp");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã nhà sản xuất : '" + txtProviderId.Text + "' đã tồn tại, hãy đổi mã khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void tsmiProvidersDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp : " + dgvProviders.CurrentRow.Cells[1].Value.ToString() + " không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String idProviders = dgvProviders.CurrentRow.Cells[0].Value.ToString();
                    String strSQL = @"DELETE FROM tblProviders WHERE Id=@id";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("id", idProviders));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Nhà cung cấp : " + dgvProviders.CurrentRow.Cells[1].Value.ToString() + " đã bị xóa khỏi CSDL...!");
                    Share.update_data_dgv(Share.Select_tblProviders, dgvProviders, txtProvider_Total, " nhà cung cấp");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn hãy xóa các ràng buộc của nhà cung cấp : " + dgvProviders.CurrentRow.Cells[1].Value.ToString() + " trước khi xóa !");
            } 
        }

        private void dgvProviders_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvProviders.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
