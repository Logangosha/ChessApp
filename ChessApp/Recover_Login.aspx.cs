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

        protected void BtnRecovery_Click(object sender, EventArgs e)
        {
            sectionRecoverySentCode.Attributes["class"] = "d-block visible";
            sectionRecoverySubmitEmail.Attributes["class"] = "d-none invisible";
        }

        protected void BtnRecoveryResend_Click(object sender, EventArgs e)
        {
            lbRecovery.Text = "Link has been resent.";
            btnRecoveryResend.Attributes["class"] = "d-none invisible";
        }
    }
}