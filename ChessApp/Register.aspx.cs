using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChessApp.Classes;

namespace ChessApp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            PlayerAccount player = new PlayerAccount(tbxFname.Text, tbxLname.Text, tbxUname.Text, tbxEmail.Text, tbxDob.Text,  new AccountPassword(tbxPassword.Text));
            Session["AccountInfo"] = player;
            Response.Redirect("Home.aspx");
        }
    }
}