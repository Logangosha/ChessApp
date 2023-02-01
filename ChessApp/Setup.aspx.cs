using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChessApp
{
    public partial class Setup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                switch (Session["GameType"].ToString())
                {
                    case "Computer":
                        btnSelectComputerDifficulty.Attributes["class"] = "d-block visible";
                        btnSetGameMode.Attributes["class"] = "d-block visible";
                        btnPickSide.Attributes["class"] = "d-block visible";
                        break;
                    case "Online":
                        btnChooseFriend.Attributes["class"] = "d-block visible";
                        btnPickSide.Attributes["class"] = "d-block visible";
                        btnSetGameMode.Attributes["class"] = "d-block visible";
                        break;
                    case "Pass":
                        btnSetGameMode.Attributes["class"] = "d-block visible";
                        btnSetTimer.Attributes["class"] = "d-block visible";
                        break;
                }
            }
        }
        protected void BtnSetTimer_Click(object sender, EventArgs e)
        {
            Response.Write("Timer set");
        }
        protected void BtnSetGameMode_Click(object sender, EventArgs e)
        {
            Response.Write("Game Mode Set");
        }
        protected void BtnPickSide_Click(object sender, EventArgs e)
        {
            Response.Write("Side Picked");
        }
        protected void BtnChooseFriend_Click(object sender, EventArgs e)
        {
            Response.Write("Friend Choosen");
        }
        protected void BtnSelectComputerDifficulty_Click(object sender, EventArgs e)
        {
            Response.Write("Selected Computer Difficulty");
        }
        protected void BtnStartGame_Click(object sender, EventArgs e)
        {
            Response.Write("Game Started");
        }
    }
}