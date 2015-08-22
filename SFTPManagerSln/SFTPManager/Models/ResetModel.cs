using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SFTPManager.Models
{
    public class ResetModel
    {
        private string _email { get; set; }

        public string Email 
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}