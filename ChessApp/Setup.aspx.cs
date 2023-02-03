using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ChessApp.Classes;

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
                divGameDetails.Attributes["class"] = "d-none invisible";
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
        protected void BtnSetTimer_Click(object sender, EventArgs e)
        {
            ViewState["Timer"] = "10 min";
            Response.Write("Timer set");
        }
        protected void BtnSetGameMode_Click(object sender, EventArgs e)
        {
            ViewState["GameMode"] = "Standard";
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
            ViewState["Difficulty"] = 1000;
            Response.Write("Selected Computer Difficulty");
        }
        protected void BtnStartGame_Click(object sender, EventArgs e)
        {
            string gameMode = ViewState["GameMode"].ToString();
            string timeSettings;
            //who are the players and what side are they on
            Player[] players = new Player[2];
            if (Session["AccountInfo"].GetType() == typeof(PlayerAccount))
            {
                PlayerAccount account = (PlayerAccount)Session["AccountInfo"];
                players[0] = new Player(account, true);
            }
            else if (Session["AccountInfo"].GetType() == typeof(Guest))
            {
                Guest guest = (Guest)Session["AccountInfo"];
                players[0] = new Player(guest, true);
            }
            switch (Session["GameType"].ToString())
            {
                case "Computer":
                    players[1] = new Player(new Computer(Convert.ToInt32(ViewState["Difficulty"])), false);
                    timeSettings = "No Timer";
                    break;
                case "Online":
                    /**/
                    timeSettings = ViewState["Timer"].ToString();
                    break;
                case "PassPlay":
                    PlayerAccount account = (PlayerAccount)Session["AccountInfo"];
                    players[1] = new Player(account, false);
                    timeSettings = ViewState["Timer"].ToString();
                    break;
                default: timeSettings = "No Timer"; break;
            }
            Session["GameData"] = new Classes.Game(players, gameMode, timeSettings);
            Response.Redirect("Game.aspx");
        }
        protected void BtnGameType_Command(object sender, CommandEventArgs e)
        {
            divGameType.Attributes["class"] = "d-none invisible";
            divGameDetails.Attributes["class"] = "d-block visible";
            
            switch (e.CommandName.ToString())
            {
                case "Computer":
                    Session["GameType"] = "Computer";
                    divChooseFriend.Attributes["class"] = "d-none invisible";
                    divSetTimer.Attributes["class"] = "d-none invisible";
                    break;
                case "Online":
                    Session["GameType"] = "Online";
                    if (Session["AccountInfo"] != null)
                    {
                        divChooseFriend.Attributes["class"] = "d-block visible";
                    }
                    else
                    {
                        divChooseFriend.Attributes["class"] = "d-none invisible";
                    }
                    divSelectComputerDifficulty.Attributes["class"] = "d-none invisible";
                    break;
                case "Pass":
                    Session["GameType"] = "Pass";
                    divSelectComputerDifficulty.Attributes["class"] = "d-none invisible";
                    divPickSide.Attributes["class"] = "d-none invisible";
                    divChooseFriend.Attributes["class"] = "d-none invisible";
                    break;
            }
        }
    }
}