using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChessApp
{
    public class AccountPassword
    {
        public string userPassword { get; set; }
        public AccountPassword(string _userPassword)
        {
            userPassword = _userPassword;
        }
    }
}