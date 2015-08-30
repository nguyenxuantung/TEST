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
    public partial class frmStoreIn_update : Form
    {
        SqlConnection conn;
        public frmStoreIn_update()
        {
            InitializeComponent();
        }

        private void frmStoreIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qUANLIKINHDOANHDIENTHOAIDataSet.tblProduct' table. You can move, or remove it, as needed.
            this.tblProductTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblProduct);
            // TODO: This line of code loads data into the 'qUANLIKINHDOANHDIENTHOAIDataSet.tblStoreInDetail' table. You can move, or remove it, as needed.
            this.tblStoreInDetailTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblStoreInDetail);
            // TODO: This line of code loads data into the 'qUANLIKINHDOANHDIENTHOAIDataSet.tblProviders' table. You can move, or remove it, as needed.
            this.tblProvidersTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblProviders);
            // TODO: This line of code loads data into the 'qUANLIKINHDOANHDIENTHOAIDataSet.tblStoreIn' table. You can move, or remove it, as needed.
            this.tblStoreInTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblStoreIn);

            String strCon = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            conn = new SqlConnection(strCon);
            conn.Open();

            Share.update_data_dgv(Share.Select_tblStoreIn, dgvStoreIn, txtStoreIn_Total, " nhập kho");
            Share.update_data_dgv(Share.Select_tblStoreInDetail, dgvStoreDetail, txtStoreInDetail_Total, " chi tiết nhập");
        }

        private void tsmiStoreInNew_Click(object sender, EventArgs e)
        {
            txtStoreInId.Enabled = false;
            txtStoreInId.Text = "";
            cmbProvidersId.Focus();
            cmbProvidersId.SelectedText = "";
            dtpStoreInDate.Value = DateTime.Now;
        }

        private void tsmiStoreInSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProvidersId.SelectedText == "" && dtpStoreInDate.Value == null)
                {
                    MessageBox.Show("Hãy nhập thông tin nhập kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbProvidersId.Focus();
                }
                else
                    if (txtStoreInId.Text != "")
                    {
                        String strSQL = @"Update [tblStoreIn] set [ProvidersId]=@providersId, [DateIn]=@dateIn Where Id=@id";
                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add(new SqlParameter("id", txtStoreInId.Text));
                        cmd.Parameters.Add(new SqlParameter("providersId", cmbProvidersId.SelectedValue.ToString()));
                        cmd.Parameters.Add(new SqlParameter("dateIn", dtpStoreInDate.Value));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lưu thay đổi thành công !");
                        Share.update_data_dgv(Share.Select_tblStoreIn, dgvStoreIn, txtStoreIn_Total, " nhập kho");
                    }
                    else
                    {
                        String strSQL = @"INSERT INTO tblStoreIn VALUES(@providerId, @dateIn)";
                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add(new SqlParameter("providerId", cmbProvidersId.SelectedValue.ToString()));
                        cmd.Parameters.Add(new SqlParameter("dateIn", (DateTime)dtpStoreInDate.Value));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Providers: " + cmbProvidersId.SelectedValue.ToString() + " Date:  " + dtpStoreInDate.Value);
                        MessageBox.Show("Thêm mới thành công !");
                        Share.update_data_dgv(Share.Select_tblStoreIn, dgvStoreIn, txtStoreIn_Total, " nhập kho");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tsmiStoreInDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhập kho : " + dgvStoreIn.CurrentRow.Cells[0].Value.ToString() + " không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String idStoreIn = dgvStoreIn.CurrentRow.Cells[0].Value.ToString();
                    String strSQL = @"DELETE FROM tblStoreIn WHERE Id=@id";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("id", idStoreIn));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Nhập kho : " + dgvStoreIn.CurrentRow.Cells[0].Value.ToString() + " đã bị xóa khỏi CSDL...!");
                    Share.update_data_dgv(Share.Select_tblStoreIn, dgvStoreIn, txtStoreIn_Total, " nhập kho");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn phải xóa ràng buộc của nhập kho : " + dgvStoreIn.CurrentRow.Cells[0].Value.ToString() + " trước khi xóa !");
            }
        }

        private void dgvStoreIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStoreInId.Enabled = false;
            txtStoreInId.Text = dgvStoreIn.CurrentRow.Cells[0].Value.ToString();
            cmbProvidersId.SelectedValue = dgvStoreIn.CurrentRow.Cells[1].Value.ToString();
            dtpStoreInDate.Value = (DateTime)dgvStoreIn.CurrentRow.Cells[2].Value;
        }

        private void dgvStoreDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbProductId.Enabled = false;
            cmbStoreId.Enabled = false;
            cmbStoreId.SelectedValue = dgvStoreDetail.CurrentRow.Cells[0].Value;
            cmbProductId.SelectedValue = dgvStoreDetail.CurrentRow.Cells[1].Value;
            txtStoreDetail_ParceNumber.Text = dgvStoreDetail.CurrentRow.Cells[2].Value.ToString();
            txtStoreDetail_Quantity.Text = dgvStoreDetail.CurrentRow.Cells[3].Value.ToString();
            txtStoreDetail_Price.Text = dgvStoreDetail.CurrentRow.Cells[4].Value.ToString();
        }

        private void tsmiStoreDetailNew_Click(object sender, EventArgs e)
        {
            cmbProductId.Enabled = true;
            cmbStoreId.Enabled = true;
            cmbStoreId.Focus();
            txtStoreDetail_Price.Text = "";
            txtStoreDetail_Quantity.Text = "";
            txtStoreDetail_ParceNumber.Text = "";
        }

        private void tsmiStoreDetailSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProductId.SelectedValue == null && cmbStoreId.SelectedValue == null)
                {
                    MessageBox.Show("Hãy nhập thông tin chi tiết nhập !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbStoreId.Focus();
                }
                else
                {
                    if (txtStoreDetail_Price.Text == "")
                    {
                        txtStoreDetail_Price.Text = "0";
                    }

                    if (txtStoreDetail_Quantity.Text == "")
                    {
                        txtStoreDetail_Quantity.Text = "0";
                    }
                    if (cmbProductId.Enabled == false && cmbStoreId.Enabled == false)
                    {
                        String strSQL = @"Update [tblStoreInDetail] set [QuantityIn]=@quantityIn, [PriceIn]=@priceIn Where [StoreInId]=@storeinId, [ProductId]=@productId, [PacelNumber]=@pacelNumber";
                        SqlCommand cmd = new SqlCommand(strSQL, conn);
                        cmd.Parameters.Add(new SqlParameter("providersId", cmbProvidersId.SelectedValue.ToString()));
                        cmd.Parameters.Add(new SqlParameter("providersId", cmbProvidersId.SelectedValue.ToString()));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lưu thay đổi thành công !");
                        Share.update_data_dgv(Share.Select_tblStoreInDetail, dgvStoreDetail, txtStoreInDetail_Total, " chi tiết nhập");
                    }
                    else
                        if (cmbProductId.Enabled == true && cmbStoreId.Enabled == true)
                        {
                            String strSQL = @"INSERT INTO tblStoreInDetail VALUES(@storeId, @productId, @parceNumber, @quantity, @priceIn)";
                            SqlCommand cmd = new SqlCommand(strSQL, conn);
                            cmd.Parameters.Add(new SqlParameter("storeId", cmbStoreId.SelectedValue.ToString()));
                            cmd.Parameters.Add(new SqlParameter("productId", cmbProductId.SelectedValue.ToString()));
                            cmd.Parameters.Add(new SqlParameter("parceNumber", txtStoreDetail_ParceNumber.Text));
                            cmd.Parameters.Add(new SqlParameter("quantity", int.Parse(txtStoreDetail_Quantity.Text)));
                            cmd.Parameters.Add(new SqlParameter("priceIn", int.Parse(txtStoreDetail_Price.Text)));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm mới thành công !");
                            Share.update_data_dgv(Share.Select_tblStoreInDetail, dgvStoreDetail, txtStoreInDetail_Total, " chi tiết nhập");
                        }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Số lượng và giá phải là số nguyên dương");
            }
        }

        private void tsmiStoreDetailDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết nhập : " + dgvStoreDetail.CurrentRow.Cells[0].Value.ToString() + " không?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int idStoreInDetail = int.Parse(dgvStoreDetail.CurrentRow.Cells[0].Value.ToString());
                    String idProduct = dgvStoreDetail.CurrentRow.Cells[1].Value.ToString();
                    String pacelNumber = dgvStoreDetail.CurrentRow.Cells[2].Value.ToString();
                    String strSQL = @"DELETE FROM tblStoreInDetail WHERE StoreInId=@idsi and ProductId=@idp and PacelNumber=@pn";
                    SqlCommand cmd = new SqlCommand(strSQL, conn);
                    cmd.Parameters.Add(new SqlParameter("idsi", idStoreInDetail));
                    cmd.Parameters.Add(new SqlParameter("idp", idProduct));
                    cmd.Parameters.Add(new SqlParameter("pn", pacelNumber));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Chi tiết nhập kho : " + dgvStoreDetail.CurrentRow.Cells[0].Value.ToString() + " đã bị xóa khỏi CSDL...!");
                    Share.update_data_dgv(Share.Select_tblStoreInDetail, dgvStoreDetail, txtStoreInDetail_Total, " chi tiết nhập");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }

        private void dgvStoreIn_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvStoreIn.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tblProductTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblProduct);
            this.tblStoreInDetailTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblStoreInDetail);
            this.tblProvidersTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblProviders);
            this.tblStoreInTableAdapter.Fill(this.qUANLIKINHDOANHDIENTHOAIDataSet.tblStoreIn);
        }
    }
}
