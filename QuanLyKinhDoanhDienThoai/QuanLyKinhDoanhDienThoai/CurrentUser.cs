using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKinhDoanhDienThoai
{
    public class CurrentUser
    {
        private string username;
        private string pass;
        private int rule;
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Rule
        {
            get { return rule; }
            set { rule = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}
