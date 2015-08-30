using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKinhDoanhDienThoai
{
    class Share
    {
        public static DataView get_data(String sql)
        {
            string strCon = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            String strSQL = @sql;
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            return dv;
        }

        public static void update_data_dgv(String sqlCommand, DataGridView dgv, TextBox txt, String text)
        {
            string strCon = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            SqlConnection conn = new SqlConnection(strCon);
            conn.Open();
            String strSQL = @sqlCommand;
            SqlCommand cmd = new SqlCommand(strSQL, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataView dv = new DataView(dt);
            dgv.DataSource = dv;
            txt.Text = "Hiện tại có " + (dgv.RowCount).ToString() + text;
        }

        static Color color_btn_menuparent_MouseEnter = Color.Orchid;
        static Color color_btn_menuparent_MouseLeave = Color.Turquoise;

        public static Color backcolor_menuchild_select = Color.Green;
        public static Color forecolor_menuchild_select = Color.White;

        public static string select_tblUserPass = "Select Name, pass FROM tblUser";
        public static string select_tblUser = "Select * FROM tblUser";
        static string select_tblGroupProduct = "Select Id, Name from tblGroupProduct";
        static string select_tblProduct = "Select * from tblProduct";
        static string select_tblProductDetail = "Select * from tblProductDetail";
        static string select_tblProviders = "Select * from tblProviders";
        static string select_tblStoreIn = "Select * FROM tblStoreIn";
        static string select_tblBillDetail = "Select * FROM tblBillDetail";

        public static string Select_tblBillDetail
        {
            get { return Share.select_tblBillDetail; }
            set { Share.select_tblBillDetail = value; }
        }

        static string select_tblStoreInDetail = "Select * FROM tblStoreInDetail";
        static string select_tblCustomer = "Select * FROM tblCustomer";
        static string select_tblBill = "Select * FROM tblBill";
        static string select_tblKindBill = "Select * FROM tblKindBill";
        static string select_tblPersonnel = "Select * FROM tblPersonnel";

        public static string Select_tblPersonnel
        {
            get { return Share.select_tblPersonnel; }
            set { Share.select_tblPersonnel = value; }
        }

        public static string Select_tblKindBill
        {
            get { return Share.select_tblKindBill; }
            set { Share.select_tblKindBill = value; }
        }

        public static string Select_tblBill
        {
            get { return Share.select_tblBill; }
            set { Share.select_tblBill = value; }
        }

        public static string Select_tblCustomer
        {
            get { return Share.select_tblCustomer; }
            set { Share.select_tblCustomer = value; }
        }

        public static string Select_tblStoreInDetail
        {
            get { return Share.select_tblStoreInDetail; }
            set { Share.select_tblStoreInDetail = value; }
        }

        public static string Select_tblStoreIn
        {
            get { return Share.select_tblStoreIn; }
            set { Share.select_tblStoreIn = value; }
        }

        public static string Select_tblProviders
        {
            get { return Share.select_tblProviders; }
            set { Share.select_tblProviders = value; }
        }

        public static string Select_tblProductDetail
        {
            get { return Share.select_tblProductDetail; }
            set { Share.select_tblProductDetail = value; }
        }

        public static string Select_tblProduct
        {
            get { return Share.select_tblProduct; }
            set { Share.select_tblProduct = value; }
        }

        public static string Select_tblGroupProduct
        {
            get { return Share.select_tblGroupProduct; }
            set { Share.select_tblGroupProduct = value; }
        }

        public static Color Color_btn_menuparent_MouseLeave
        {
            get { return Share.color_btn_menuparent_MouseLeave; }
            set { Share.color_btn_menuparent_MouseLeave = value; }
        }

        public static Color Color_btn_menuparent_MouseEnter
        {
            get { return color_btn_menuparent_MouseEnter; }
            set { color_btn_menuparent_MouseEnter = value; }
        }

        public static string Select_tblUser
        {
            get { return select_tblUser; }
            set { select_tblUser = value; }
        }
    }
}
