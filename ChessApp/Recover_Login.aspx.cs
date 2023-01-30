using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChessApp
{
    public partial class Recover_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        } 

        protected void recoveryBtn_Click(object sender, EventArgs e)
        {
            recoverySentCodeSection.Attributes["class"] = "d-block visible";
            recoverySubmitEmailSection.Attributes["class"] = "d-none invisible";
        }

        protected void recoveryResendBtn_Click(object sender, EventArgs e)
        {
            recoveryLb.Text = "Link has been resent.";
            recoveryResendBtn.Attributes["class"] = "d-none invisible";
        }
    }
}