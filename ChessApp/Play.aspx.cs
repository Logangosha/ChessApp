using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChessApp
{
    public partial class Play : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["GameType"] != null)
                {
                    Session["GameType"] = null;
                }
            }
        }
        protected void BtnPlayComputer_Click(object sender, EventArgs e)
        {

        }

        protected void BtnPlayOnline_Click(object sender, EventArgs e)
        {

        }

        protected void BtnPassPlay_Click(object sender, EventArgs e)
        {

        }

        protected void BtnPlayChess_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName.ToString())
            {
                case "Computer":
                    Session["GameType"] = "Computer";
                    break;
                case "Online":
                    Session["GameType"] = "Online";
                    break;
                case "Pass":
                    Session["GameType"] = "Pass";
                    break;
            }
            Response.Redirect("Setup.aspx");
        }
    }
}