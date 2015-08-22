using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SFTPManager.Models
{
    public class LoginModel
    {
        private string _usrname { get; set; }
        private string _pwd { get; set; }

        public string Username 
        {
            get { return _usrname; }
            set { _usrname = value; }
        }

        public string Password
        {
            get { return _pwd; }
            set { _pwd = value; }
        }
    }
}