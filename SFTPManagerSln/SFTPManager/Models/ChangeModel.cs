using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SFTPManager.Models
{
    public class ChangeModel
    {
        private string _currentPass { get; set; }
        private string _newPass { get; set; }
        private string _confPass { get; set; }


        public string CurrentPassword
        {
            get { return _currentPass; }
            set { _currentPass = value; }
        }

        public string NewPassword
        {
            get { return _newPass; }
            set { _newPass = value; }
        }

        public string ConfirmationPassword
        {
            get { return _confPass; }
            set { _confPass = value; }
        }
    }
}