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
    public partial class frmProduct_update : Form
    {
        SqlConnection conn;
        public frmProduct_update()
        {
            InitializeComponent();
        }

        private void frmProduct_update_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLIKINHDOANHDIENTHOAIDataSet.tblGroupProduct' table. You can move, or remove it, as needed.
            this.tblGroupProductTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblGroupProduct);
            // TODO: This line of code loads data into the 'qUANLIKINHDOANHDIENTHOAIDataSet.tblProductDetail' table. You can move, or remove it, as needed.
            this.tblProductDetailTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblProductDetail);
            // TODO: This line of code loads data into the 'qUANLIKINHDOANHDIENTHOAIDataSet.tblProduct' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblProduct);

            String strCon = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            conn = new SqlConnection(strCon);
            conn.Open();

            Share.update_data_dgv(Share.Select_tblProduct, dgvProduct, txtProduct_Total, " sản phẩm");
            Share.update_data_dgv(Share.Select_tblProductDetail, dgvProductDetail, txtProductDetail_Total, " chi tiết sản phẩm");
            Share.update_data_dgv(Share.Select_tblGroupProduct, dgvGroupProduct, txtGroupProduct_Total, " nhóm sản phẩm");
        }

        private void tsmiNew_GroupProduct_Click(object sender, EventArgs e)
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtProductDetail.Text = "";
            cmbGroupProduct.SelectedValue = "";
            txtProductId.Focus();
            txtProductId.Enabled = true;
        }

        private void tsmiSave_GroupProduct_Click(object sender, EventArgs e)
        {
            if (txtProductId.Text.Length == 0 && txtProductName.Text.Length == 0)
            {
                MessageBox.Show("Hãy nhập thông tin sản phẩm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductId.Focus();
            }
            else
                if (txtProductId.Enabled == true)
                {
                    String strSQL = @"INSERT INTO tblProduct VALUES(@id, @name, @detail, @groupproduct)";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("id", txtProductId.Text));
                    cmd.Parameters.Add(new SqlParameter("name", txtProductName.Text));
                    cmd.Parameters.Add(new SqlParameter("detail", txtProductDetail.Text));
                    cmd.Parameters.Add(new SqlParameter("groupproduct", cmbGroupProduct.SelectedValue.ToString()));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công !");
                    Share.update_data_dgv(Share.Select_tblProduct, dgvProduct, txtProduct_Total, " sản phẩm");
                }
                else
                {
                    try
                    {
                        String strSQL = @"Update [tblProduct] set [Name]=@name, [Detail]=@detail, [GroupProduct]=@gp Where Id=@id";
                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add(new SqlParameter("id", txtProductId.Text));
                        cmd.Parameters.Add(new SqlParameter("name", txtProductName.Text));
                        cmd.Parameters.Add(new SqlParameter("detail", txtProductDetail.Text));
                        cmd.Parameters.Add(new SqlParameter("gp", cmbGroupProduct.SelectedText));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lưu thay đổi thành công !");
                        Share.update_data_dgv(Share.Select_tblProduct, dgvProduct, txtProduct_Total, " sản phẩm");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã sản phẩm '" + txtProductId.Text + "' đã tồn tại, hãy đổi mã khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
        }

        private void tsmiDelete_GroupProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm : " + dgvProduct.CurrentRow.Cells[1].Value.ToString() + " không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String idProduct = dgvProduct.CurrentRow.Cells[0].Value.ToString();
                    String strSQL = @"DELETE FROM tblProduct WHERE Id=@id";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("id", idProduct));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sản phẩm : " + dgvProduct.CurrentRow.Cells[1].Value.ToString() + " đã bị xóa khỏi CSDL...!");
                    Share.update_data_dgv(Share.Select_tblProduct, dgvProduct, txtProduct_Total, " sản phẩm");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn hãy xóa các ràng buộc của sản phẩm : " + dgvProduct.CurrentRow.Cells[1].Value.ToString() + " trước khi xóa sản phẩm !");
            } 
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductId.Enabled = false;
            txtProductId.Text = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            txtProductName.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            txtProductDetail.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            cmbGroupProduct.SelectedValue = dgvProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void cmbProductId_ProductDetail_SelectedValueChanged(object sender, EventArgs e)
        {
            String values = cmbProductId_ProductDetail.Text;
            String condition = "ProductId='" + values + "'";
            DataView dv = Share.get_data(Share.Select_tblStoreInDetail);

            dv.RowFilter = condition;
            cmbParceNumber_ProductDetail.DataSource = dv;
        }

        private void tsmiProductDetail_New_Click(object sender, EventArgs e)
        {
            cmbParceNumber_ProductDetail.Enabled = true;
            cmbProductId_ProductDetail.Enabled = true;
            txtPrice_ProductDetail.Text = "";
            dtpFromDay_ProductDetail.Value = DateTime.Now;
            dtpToDay_ProductDetail.Value = DateTime.Now;
            cmbProductId_ProductDetail.Focus();
        }

        private void tsmiProductDetail_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProductId_ProductDetail.Enabled == false && cmbParceNumber_ProductDetail.Enabled == false)
                {
                    if (dtpFromDay_ProductDetail.Value < dtpToDay_ProductDetail.Value)
                    {
                        String strSQL = @"Update [tblProductDetail] set [Price]=@price, [FromDay]=@fromday, [ToDay]=@today Where [ProductId]=@Idp and [PacelNumber]=@pn";
                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add(new SqlParameter("Idp", cmbProductId_ProductDetail.SelectedValue.ToString()));
                        cmd.Parameters.Add(new SqlParameter("pn", cmbParceNumber_ProductDetail.SelectedValue.ToString()));
                        cmd.Parameters.Add(new SqlParameter("price", int.Parse(txtPrice_ProductDetail.Text)));
                        cmd.Parameters.Add(new SqlParameter("fromday", (DateTime)dtpFromDay_ProductDetail.Value));
                        cmd.Parameters.Add(new SqlParameter("today", (DateTime)dtpToDay_ProductDetail.Value));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lưu thay đổi thành công !");
                        Share.update_data_dgv(Share.Select_tblProductDetail, dgvProductDetail, txtProductDetail_Total, " chi tiết sản phẩm");
                    }
                    else
                    {
                        MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu !");
                    }
                }
                else
                    if (cmbProductId_ProductDetail.Enabled == true && cmbParceNumber_ProductDetail.Enabled == true)
                    {
                        if (dtpFromDay_ProductDetail.Value < dtpToDay_ProductDetail.Value)
                        {
                            String strSQL = @"INSERT INTO tblProductDetail VALUES(@Idp, @pn, @price, @fromday, @today)";
                            SqlCommand cmd = new SqlCommand(strSQL, conn);
                            cmd.Parameters.Add(new SqlParameter("Idp", cmbProductId_ProductDetail.SelectedValue.ToString()));
                            cmd.Parameters.Add(new SqlParameter("pn", cmbParceNumber_ProductDetail.SelectedValue.ToString()));
                            cmd.Parameters.Add(new SqlParameter("price", int.Parse(txtPrice_ProductDetail.Text)));
                            cmd.Parameters.Add(new SqlParameter("fromday", (DateTime)dtpFromDay_ProductDetail.Value));
                            cmd.Parameters.Add(new SqlParameter("today", (DateTime)dtpToDay_ProductDetail.Value));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm mới thành công !");
                            Share.update_data_dgv(Share.Select_tblProductDetail, dgvProductDetail, txtProductDetail_Total, " chi tiết sản phẩm");
                        }
                        else
                        {
                            MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu !");
                        }
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin chi tiết sản phẩm đã tồn tại !");
            }
        }

        private void tsmiProductDetail_Delete_Click(object sender, EventArgs e)
        {
            int idProduct = int.Parse(dgvProductDetail.CurrentRow.Cells[0].Value.ToString());
            String pacelNumber = dgvProductDetail.CurrentRow.Cells[1].Value.ToString();
            String strSQL = @"DELETE FROM tblProductDetail WHERE ProductId=@idp and PacelNumber=@pn";
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            cmd.Parameters.Add(new SqlParameter("idp", idProduct));
            cmd.Parameters.Add(new SqlParameter("pn", pacelNumber));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Chi tiết sản phẩm : " + dgvProductDetail.CurrentRow.Cells[0].Value.ToString() + " đã bị xóa khỏi CSDL...!");
            Share.update_data_dgv(Share.Select_tblProductDetail, dgvProductDetail, txtProductDetail_Total, " chi tiết sản phẩm");
        }

        private void dgvProductDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbParceNumber_ProductDetail.Enabled = false;
            cmbProductId_ProductDetail.Enabled = false;
            cmbProductId_ProductDetail.SelectedValue = dgvProductDetail.CurrentRow.Cells[0].Value;
            cmbParceNumber_ProductDetail.SelectedValue = dgvProductDetail.CurrentRow.Cells[1].Value;
            txtPrice_ProductDetail.Text = dgvProductDetail.CurrentRow.Cells[2].Value.ToString();
            dtpFromDay_ProductDetail.Value = (DateTime)dgvProductDetail.CurrentRow.Cells[3].Value;
            dtpToDay_ProductDetail.Value = (DateTime)dgvProductDetail.CurrentRow.Cells[4].Value;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtIdGroupProduct.Text = "";
            txtNameGroupProduct.Text = "";
            txtIdGroupProduct.Enabled = true;
            txtIdGroupProduct.Focus();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (txtIdGroupProduct.Text.Length == 0 && txtNameGroupProduct.Text.Length == 0)
            {
                MessageBox.Show("Hãy nhập thông tin nhóm sản phẩm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdGroupProduct.Focus();
            }
            else
                if (txtIdGroupProduct.Enabled == false)
                {
                    String strSQL = @"Update [tblGroupProduct] set [Name]=@name Where Id=@idgp";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("idgp", txtIdGroupProduct.Text));
                    cmd.Parameters.Add(new SqlParameter("name", txtNameGroupProduct.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lưu thay đổi thành công !");
                    Share.update_data_dgv(Share.Select_tblGroupProduct, dgvGroupProduct, txtGroupProduct_Total, " nhóm sản phẩm");
                }
                else
                {
                    try
                    {
                        String strSQL = @"INSERT INTO tblGroupProduct VALUES(@id, @name)";
                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add(new SqlParameter("id", txtIdGroupProduct.Text));
                        cmd.Parameters.Add(new SqlParameter("name", txtNameGroupProduct.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới thành công !");
                        Share.update_data_dgv(Share.Select_tblGroupProduct, dgvGroupProduct, txtGroupProduct_Total, " nhóm sản phẩm");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Mã nhóm sản phẩm '" + txtIdGroupProduct.Text + "' đã tồn tại, hãy đổi mã khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhóm " + dgvGroupProduct.CurrentRow.Cells[1].Value.ToString() + " không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String idGroupProduct = dgvGroupProduct.CurrentRow.Cells[0].Value.ToString();
                    String strSQL = @"DELETE FROM tblGroupProduct WHERE Id=@idgp";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("idgp", idGroupProduct));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Nhóm sản phẩm : " + dgvGroupProduct.CurrentRow.Cells[1].Value.ToString() + " đã bị xóa khỏi CSDL...!");
                    Share.update_data_dgv(Share.Select_tblGroupProduct, dgvGroupProduct, txtGroupProduct_Total, " nhóm sản phẩm");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn phải xóa các dữ liệu ràng buộc của nhóm " + dgvGroupProduct.CurrentRow.Cells[1].Value.ToString() + " trước khi xóa nhóm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
        }

        private void dgvGroupProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdGroupProduct.Enabled = false;
            txtIdGroupProduct.Text = dgvGroupProduct.CurrentRow.Cells[0].Value.ToString();
            txtNameGroupProduct.Text = dgvGroupProduct.CurrentRow.Cells[1].Value.ToString();
        }

        private void tclProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tblGroupProductTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblGroupProduct);
            this.tblProductDetailTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblProductDetail);
            this.tblProductTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblProduct);
        }

        private void dgvProduct_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvProduct.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dgvProductDetail_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvProductDetail.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dgvGroupProduct_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvGroupProduct.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

    }
}
