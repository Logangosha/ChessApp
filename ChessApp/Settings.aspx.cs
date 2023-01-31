using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChessApp
{
    public partial class Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Session["AccountInfo"] != null)
                {
                    PlayerAccount player = (PlayerAccount)Session["AccountInfo"];
                }
                else
                {
                    btnChangeLogin.Attributes["class"] = "d-none invisible";
                    btnChangeAccountInfo.Attributes["class"] = "d-none invisible";
                    btnDeleteAccount.Attributes["class"] = "d-none invisible";
                }
            }
        }

        protected void BtnChangeLogin_Click(object sender, EventArgs e)
        {

        }

        protected void BtnChangeTheme_Click(object sender, EventArgs e)
        {

        }

        protected void BtnChangeAccountInfo_Click(object sender, EventArgs e)
        {

        }

        protected void BtnDeleteAccount_Click(object sender, EventArgs e)
        {

        }
    }
}