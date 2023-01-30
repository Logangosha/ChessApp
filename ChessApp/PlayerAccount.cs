using ChessApp;
using Microsoft.AspNet.FriendlyUrls.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessApp
{
    public class PlayerAccount
    {
        // first name property
        public string fName { get; set; }
        // last name property
        public string lName { get; set; }
        public string uName { get; set; }
        public string email { get; set; }
        public AccountPassword password { get; set; }
        public string dob { get; set; }
        public List<string> friends { get; set; }
        public List<string> MyProperty { get; set; }

    }
}