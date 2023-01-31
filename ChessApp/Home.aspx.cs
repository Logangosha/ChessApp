using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChessApp
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Session["AccountInfo"] != null)
                {
                    PlayerAccount player = (PlayerAccount)Session["AccountInfo"];
                    btnSignIn.Attributes["class"] = "d-none invisible";
                }
                else
                {
                    btnLogout.Attributes["class"] = "d-none invisible";
                    btnNotifications.Attributes["class"] = "d-none invisible";
                    btnFriends.Attributes["class"] = "d-none invisible";
                    btnHistory.Attributes["class"] = "d-none invisible";
                }
            }
        }

        protected void BtnPlayChess_Click(object sender, EventArgs e)
        {
            Response.Redirect("Play.aspx");
        }

        protected void BtnNotifications_Click(object sender, EventArgs e)
        {
            Response.Redirect("Notifications.aspx");
        }

        protected void BtnFriends_Click(object sender, EventArgs e)
        {
            Response.Redirect("Friends.aspx");
        }

        protected void BtnHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("GameHistory.aspx");
        }

        protected void BtnLogout_Click(object sender, EventArgs e)
        {
            Session["AccountInfo"] = null;
            Response.Redirect("Home.aspx");
        }

        protected void BtnSignIn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void BtnSettings_Click(object sender, EventArgs e)
        {
            Response.Redirect("Settings.aspx");
        }
    }
}