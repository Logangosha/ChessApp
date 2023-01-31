using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ChessApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccountInfo"] != null)
            {
                Session["AccountInfo"] = null;
            }
        }

        protected void BtnDisplayModal_Click(object sender, EventArgs e)
        {
            loginModal.Style["visibility"] = "visible";
            loginModal.Style["display"] = "block";
        }

        protected void BtnPlayAsGuest_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            PlayerAccount player = new PlayerAccount("fName", "lName", "uName", "email", "dob", new AccountPassword("password"));
            Session["AccountInfo"] = player;
            Response.Redirect("Home.aspx");
        }
    }
}