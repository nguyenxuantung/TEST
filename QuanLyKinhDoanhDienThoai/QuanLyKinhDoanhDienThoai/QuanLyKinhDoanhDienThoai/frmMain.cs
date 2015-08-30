using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKinhDoanhDienThoai
{
    public partial class frmMain : Form
    {
        public String AccessContent;
        CurrentUser cu;

        public frmMain(CurrentUser cu)
        {
            InitializeComponent();
            this.cu = cu;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvMenu_child_admin.DefaultCellStyle.BackColor = Share.backcolor_menuchild_select;
            dgvMenu_child_admin.DefaultCellStyle.ForeColor = Share.forecolor_menuchild_select;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (dgvMenu_child_admin.RowCount == 0)
            {
                switch (cu.Rule)
                {
                    case 1: //quyền nhân viên
                        
                        String[] row10 = new String[] { "Sản phẩm", "0" };
                        String[] row11 = new String[] { "Đơn hàng", "1" };
                        String[] row12 = new String[] { "Nhập kho", "2" };
                        String[] row13 = new String[] { "Khách hàng", "3" };
                        String[] row14 = new String[] { "Nhà cung cấp", "4" };

                        dgvMenu_child_admin.Rows.Add(row10);
                        dgvMenu_child_admin.Rows.Add(row11);
                        dgvMenu_child_admin.Rows.Add(row12);
                        dgvMenu_child_admin.Rows.Add(row13);
                        dgvMenu_child_admin.Rows.Add(row14);
                        break;

                    case 0: // quyền admin
                        
                        String[] row0 = new String[] { "Sản phẩm", "0" };
                        String[] row1 = new String[] { "Đơn hàng", "1" };
                        String[] row2 = new String[] { "Nhập kho", "2" };
                        String[] row3 = new String[] { "Khách hàng", "3" };
                        String[] row5 = new String[] { "Nhân viên", "5" };
                        String[] row4 = new String[] { "Nhà cung cấp", "4" };

                        dgvMenu_child_admin.Rows.Add(row0);
                        dgvMenu_child_admin.Rows.Add(row1);
                        dgvMenu_child_admin.Rows.Add(row2);
                        dgvMenu_child_admin.Rows.Add(row3);
                        dgvMenu_child_admin.Rows.Add(row4);
                        dgvMenu_child_admin.Rows.Add(row5);
                        break;

                    default:
                        MessageBox.Show("Phát hiện nghi vấn hack !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            else
            {
                dgvMenu_child_admin.DataSource = null;
                dgvMenu_child_admin.Refresh();
            }
        }

        private void dgvMenu_child_admin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.RowIndex)
            {
                case 0:
                    pnlMain.Controls.Clear();
                    frmProduct_update frmP = new frmProduct_update();
                    frmP.TopLevel = false;
                    pnlMain.Controls.Add(frmP);
                    frmP.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frmP.Dock = DockStyle.Fill;
                    frmP.Show();
                    break;

                case 1:
                    pnlMain.Controls.Clear();
                    frmBill_update frmB = new frmBill_update();
                    frmB.TopLevel = false;
                    pnlMain.Controls.Add(frmB);
                    frmB.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frmB.Dock = DockStyle.Fill;
                    frmB.Show();
                    break;

                case 2:
                    pnlMain.Controls.Clear();
                    frmStoreIn_update frmS = new frmStoreIn_update();
                    frmS.TopLevel = false;
                    pnlMain.Controls.Add(frmS);
                    frmS.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frmS.Dock = DockStyle.Fill;
                    frmS.Show();
                    break;

                case 3:
                    pnlMain.Controls.Clear();
                    frmCustomer_update frmC = new frmCustomer_update();
                    frmC.TopLevel = false;
                    pnlMain.Controls.Add(frmC);
                    frmC.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frmC.Dock = DockStyle.Fill;
                    frmC.Show();
                    break;

                case 4:
                    pnlMain.Controls.Clear();
                    frmProviders_update frmPs = new frmProviders_update();
                    frmPs.TopLevel = false;
                    pnlMain.Controls.Add(frmPs);
                    frmPs.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frmPs.Dock = DockStyle.Fill;
                    frmPs.Show();
                    break;

                case 5:
                    pnlMain.Controls.Clear();
                    frmPersonnel_update frmPl = new frmPersonnel_update();
                    frmPl.TopLevel = false;
                    pnlMain.Controls.Add(frmPl);
                    frmPl.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    frmPl.Dock = DockStyle.Fill;
                    frmPl.Show();
                    break;

                default:
                    break;
            }
        }

        private void btn_User_Manager_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            frmUserInfomation frmUI = new frmUserInfomation(cu);
            frmUI.TopLevel = false;
            pnlMain.Controls.Add(frmUI);
            frmUI.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frmUI.Dock = DockStyle.Fill;
            frmUI.Show();
        } 
    }
}
