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
    public partial class frmProduct : Form
    {
        SqlConnection conn;
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLIKINHDOANHDIENTHOAIDataSet.tblKindBill' table. You can move, or remove it, as needed.
            this.tblKindBillTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblKindBill);
            // TODO: This line of code loads data into the 'qUANLIKINHDOANHDIENTHOAIDataSet.tblPersonnel' table. You can move, or remove it, as needed.
            this.tblPersonnelTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblPersonnel);
            // TODO: This line of code loads data into the 'qUANLIKINHDOANHDIENTHOAIDataSet.tblCustomer' table. You can move, or remove it, as needed.
            this.tblCustomerTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblCustomer);
            // TODO: This line of code loads data into the 'qUANLIKINHDOANHDIENTHOAIDataSet.bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.bill);
            txtBill_Id.Visible = false;

            if (cmbBill_Status.DataSource == null)
            {
                cmbBill_Status.Items.Add("Đã thanh toán và giao hàng");
                cmbBill_Status.Items.Add("Đã thanh toán, chưa giao hàng");
                cmbBill_Status.Items.Add("Chưa thanh toán");
                cmbBill_Status.SelectedText = "Đã thanh toán và giao hàng";
            }

            String strCon = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            conn = new SqlConnection(strCon);
            conn.Open();

            Share.update_data_dgv(Share.Select_tblBill, dgvBill, txtBill_Total, " đơn hàng");
            //Share.update_data_dgv(Share.Select_tblBillDetail, dgvBillDetail, txtBillDetail_Total, " chi tiết hóa đơn");
            Share.update_data_dgv(Share.Select_tblKindBill, dgvKindBill, txtKindBill_Total, " loại đơn hàng");

        }

        private void tsmiBill_New_Click(object sender, EventArgs e)
        {
            txtBill_Id.Text = "";
            dtpBill_Date.Value = DateTime.Now;
        }

        private void tsmiBill_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBill_Id.Text == null)
                {
                    MessageBox.Show("Hãy nhập thông tin đơn hàng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBill_Id.Focus();
                }
                else
                {
                    if (txtBill_Id.Text != "")
                    {
                        String strSQL = @"Update [tblBill] set [PersonnelId]=@personnelId, [CustomerId]=@customerId, [KindBillId]=@kindbillId,[Status]=@status, [Date]=@date Where [Id]=@id";
                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add(new SqlParameter("id", int.Parse(txtBill_Id.Text)));
                        cmd.Parameters.Add(new SqlParameter("personnelId", int.Parse(cmbPersonnel_Id.SelectedValue.ToString())));
                        cmd.Parameters.Add(new SqlParameter("customerId", cmbCustomer_Id.SelectedValue.ToString()));
                        cmd.Parameters.Add(new SqlParameter("kindbillId", cmbKindBill_Id.SelectedValue.ToString()));
                        cmd.Parameters.Add(new SqlParameter("status", cmbBill_Status.SelectedText.ToString()));
                        cmd.Parameters.Add(new SqlParameter("date", (DateTime)dtpBill_Date.Value));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lưu thay đổi thành công !");
                        Share.update_data_dgv(Share.Select_tblBill, dgvBill, txtBill_Total, " đơn hàng");
                    }
                    else
                    {
                        String strSQL = @"INSERT INTO tblBill VALUES(@personnelId, @customerId, @kindbillId, @status, @date)";
                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add(new SqlParameter("personnelId", (int)cmbPersonnel_Id.SelectedValue));
                        cmd.Parameters.Add(new SqlParameter("customerId", cmbCustomer_Id.SelectedValue.ToString()));
                        cmd.Parameters.Add(new SqlParameter("kindbillId", cmbKindBill_Id.SelectedValue.ToString()));
                        cmd.Parameters.Add(new SqlParameter("status", cmbBill_Status.SelectedText.ToString()));
                        cmd.Parameters.Add(new SqlParameter("date", (DateTime)dtpBill_Date.Value));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới thành công !");
                        Share.update_data_dgv(Share.Select_tblBill, dgvBill, txtBill_Total, " đơn hàng");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsmiBIll_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng : '" + dgvBill.CurrentRow.Cells[0].Value.ToString() + "' không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String idBill = dgvBill.CurrentRow.Cells[0].Value.ToString();
                    string strSQL = @"DELETE FROM tblBill WHERE Id=@idb";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("idb", idBill));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Loại đơn hàng : " + dgvBill.CurrentRow.Cells[1].Value.ToString() + " đã bị xóa khỏi CSDL...!");
                    Share.update_data_dgv(Share.Select_tblBill, dgvBill, txtBill_Total, " đơn hàng");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn phải xóa các dữ liệu ràng buộc của đơn hàng " + dgvBill.CurrentRow.Cells[0].Value.ToString() + " trước khi xóa nhóm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBill_Id.Visible = false;
            txtBill_Id.Text = dgvBill.CurrentRow.Cells[0].Value.ToString();
            cmbCustomer_Id.SelectedValue = dgvBill.CurrentRow.Cells[1].Value;
            cmbPersonnel_Id.SelectedValue = dgvBill.CurrentRow.Cells[2].Value;
            cmbKindBill_Id.SelectedValue = dgvBill.CurrentRow.Cells[3].Value;
            cmbBill_Status.Text = dgvBill.CurrentRow.Cells[4].Value.ToString();
            dtpBill_Date.Value = (DateTime)dgvBill.CurrentRow.Cells[5].Value;
        }

        //private void tsmiBillDetail_New_Click(object sender, EventArgs e)
        //{
        //    cmbBill_Id.Enabled = true;
        //    cmbBillDetail_ParcelNumber.Enabled = true;
        //    cmbBillDetail_ProductId.Enabled = true;
        //    txtBillDetail_Quantity.Text = "";
        //    cmbBill_Id.Focus();
        //}

        //private void tsmiBillDetail_Save_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (txtBillDetail_Quantity.Text == "")
        //        {
        //            txtBillDetail_Quantity.Text = "0";
        //        }
        //        if (cmbBill_Id.Enabled == false)
        //        {
        //            String strSQL = @"Update [tblBillDetail] set [Quantity]=@quantity Where [BillId]=@billid and [ProductId]=@productid and [PacelNumber]=@pacelNumber";
        //            SqlCommand cmd = new SqlCommand(strSQL, conn);
        //            cmd.Parameters.Add(new SqlParameter("billid", int.Parse(cmbBill_Id.SelectedValue.ToString())));
        //            cmd.Parameters.Add(new SqlParameter("productid", cmbBillDetail_ProductId.SelectedValue.ToString()));
        //            cmd.Parameters.Add(new SqlParameter("pacelNumber", cmbBillDetail_ParcelNumber.SelectedValue.ToString()));
        //            cmd.Parameters.Add(new SqlParameter("quantity", int.Parse(txtBillDetail_Quantity.Text)));
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Lưu thay đổi thành công !");
        //            Share.update_data_dgv(Share.Select_tblBillDetail, dgvBillDetail, txtBillDetail_Total, " chi tiết hóa đơn");
        //        }
        //        else
        //            if (cmbBill_Id.Enabled == true)
        //            {
        //                String strSQL = @"INSERT INTO tblBillDetail VALUES(@personnelId, @customerId, @kindbillId, @status, @date)";
        //                SqlCommand cmd = new SqlCommand(strSQL, conn);
        //                cmd.Parameters.Add(new SqlParameter("billid", int.Parse(cmbBill_Id.SelectedValue.ToString())));
        //                cmd.Parameters.Add(new SqlParameter("productid", cmbBillDetail_ProductId.SelectedValue.ToString()));
        //                cmd.Parameters.Add(new SqlParameter("pacelNumber", cmbBillDetail_ParcelNumber.SelectedValue.ToString()));
        //                cmd.Parameters.Add(new SqlParameter("quantity", int.Parse(txtBillDetail_Quantity.Text)));
        //                cmd.ExecuteNonQuery();
        //                MessageBox.Show("Thêm mới thành công !");
        //                Share.update_data_dgv(Share.Select_tblBillDetail, dgvBillDetail, txtBillDetail_Total, " chi tiết hóa đơn");
        //            }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        //private void tsmiBillDetail_Delete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết đơn hàng : '" + dgvBillDetail.CurrentRow.Cells[0].Value.ToString() + "' không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
        //        {
        //            String idBillDetail = dgvBillDetail.CurrentRow.Cells[0].Value.ToString();
        //            String ProductId = dgvBillDetail.CurrentRow.Cells[1].Value.ToString();
        //            String PacelNumber = dgvBillDetail.CurrentRow.Cells[2].Value.ToString();
        //            string strSQL = @"DELETE FROM tblBillDetail WHERE BillId=@idb and ProductId=@pid and PacelNumber=@pn";
        //            SqlCommand cmd = new SqlCommand(strSQL, conn);
        //            cmd.Parameters.Add(new SqlParameter("idb", idBillDetail));
        //            cmd.Parameters.Add(new SqlParameter("pid", ProductId));
        //            cmd.Parameters.Add(new SqlParameter("pn", PacelNumber));
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Chi tiết đơn hàng : " + dgvBillDetail.CurrentRow.Cells[0].Value.ToString() + " đã bị xóa khỏi CSDL...!");
        //            Share.update_data_dgv(Share.Select_tblBillDetail, dgvBillDetail, txtBillDetail_Total, " chi tiết hóa đơn");
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Bạn phải xóa các dữ liệu ràng buộc của chi tiết đơn hàng " + dgvBillDetail.CurrentRow.Cells[0].Value.ToString() + " trước khi xóa nhóm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        private void tsmiKindBill_New_Click(object sender, EventArgs e)
        {
            txtKindBill_Id.Text = "";
            txtKindBill_Name.Text = "";
            txtKindBill_Id.Enabled = true;
            txtKindBill_Id.Focus();
        }

        private void tsmiKindBill_Save_Click(object sender, EventArgs e)
        {
            if (txtKindBill_Id.Text.Length == 0 && txtKindBill_Name.Text.Length == 0)
            {
                MessageBox.Show("Hãy nhập thông tin loại đơn hàng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKindBill_Id.Focus();
            }
            else
                if (txtKindBill_Id.Enabled == false)
                {
                    String strSQL = @"Update [tblKindBill] set [Name]=@name Where Id=@idkb";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("idkb", txtKindBill_Id.Text));
                    cmd.Parameters.Add(new SqlParameter("name", txtKindBill_Name.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lưu thay đổi thành công !");
                    Share.update_data_dgv(Share.Select_tblKindBill, dgvKindBill, txtKindBill_Total, " loại đơn hàng");
                }
                else
                {
                    try
                    {
                        String strSQL = @"INSERT INTO tblKindBill VALUES(@id, @name)";
                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add(new SqlParameter("id", txtKindBill_Id.Text));
                        cmd.Parameters.Add(new SqlParameter("name", txtKindBill_Name.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới thành công !");
                        Share.update_data_dgv(Share.Select_tblKindBill, dgvKindBill, txtKindBill_Total, " loại đơn hàng");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Mã nhóm sản phẩm '" + txtKindBill_Id.Text + "' đã tồn tại, hãy đổi mã khác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
        }

        private void tsmiKindBill_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhóm " + dgvKindBill.CurrentRow.Cells[1].Value.ToString() + " không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String idKindBill = dgvKindBill.CurrentRow.Cells[0].Value.ToString();
                    string strSQL = @"DELETE FROM tblKindBill WHERE Id=@idkb";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("idkb", idKindBill));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Loại đơn hàng : " + dgvKindBill.CurrentRow.Cells[1].Value.ToString() + " đã bị xóa khỏi CSDL...!");
                    Share.update_data_dgv(Share.Select_tblKindBill, dgvKindBill, txtKindBill_Total, " loại đơn hàng");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn phải xóa các dữ liệu ràng buộc của nhóm " + dgvKindBill.CurrentRow.Cells[1].Value.ToString() + " trước khi xóa nhóm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvKindBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbBillDetail_ProductId_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvBill_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvBill.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dgvKindBill_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void tctBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.tblBillDetailTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblBillDetail);
            //this.tblBillTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblBill);
            this.tblKindBillTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblKindBill);
        }
    }
}
