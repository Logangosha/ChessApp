<%@ Page Language="C#" Title="Play Chess" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Setup.aspx.cs" Inherits="ChessApp.Play" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid h-100">
        <div class="row h-100">
            <div runat="server" id="divGameType">
            <asp:Button runat="server" ID="btnPlayComputer" text="Play Computer" OnClick="BtnPlayComputer_Click" OnCommand="BtnGameType_Command" CommandName="Computer"/>
            <asp:Button runat="server" ID="btnPlayOnline" Text="Play Online" OnClick="BtnPlayOnline_Click" OnCommand="BtnGameType_Command" CommandName="Online"/>
            <asp:Button runat="server" ID="btnPassPlay" Text="Pass and Play" OnClick="BtnPassPlay_Click" OnCommand="BtnGameType_Command" CommandName="Pass"/>
            </div>
            <div runat="server" id="divGameDetails"> 
                <asp:Button runat="server" ID="btnSetGameMode" Text="Game Mode" OnClick="BtnSetGameMode_Click"/>
                <div runat="server" id="divSetTimer">
                    <asp:Button runat="server" ID="btnSetTimer"  Text="Timer" OnClick="BtnSetTimer_Click"/>
                </div>
                <div runat="server" id="divPickSide">
                    <asp:Button runat="server" ID="btnPickSide" Text="Pick Side"  OnClick="BtnPickSide_Click"/>
                </div>
                <div runat="server" id="divChooseFriend">
                    <asp:Button runat="server" ID="btnChooseFriend" Text="Choose Friend"  OnClick="BtnChooseFriend_Click"/>
                </div>
                <div runat="server" id="divSelectComputerDifficulty">
                    <asp:Button runat="server" ID="btnSelectComputerDifficulty"  Text="Computer Difficulty" OnClick="BtnSelectComputerDifficulty_Click" />
                </div>
                <asp:Button runat="server" ID="btnStartGame" Text="Start Game" OnClick="BtnStartGame_Click" />
            </div>
        </div>
    </div>
</asp:Content>
