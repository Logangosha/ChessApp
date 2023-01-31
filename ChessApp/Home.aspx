<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ChessApp.Home" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid h-100">
        <div class="row h-100">
             <asp:Button runat="server" Text="Notifications" ID="btnNotifications" OnClick="BtnNotifications_Click"/>
             <asp:Button runat="server" Text="Play Chess" ID="btnPlayChess" OnClick="BtnPlayChess_Click"/>
             <asp:Button runat="server" Text="Friends" ID="btnFriends" OnClick="BtnFriends_Click"/>
             <asp:Button runat="server" Text="History" ID="btnHistory" OnClick="BtnHistory_Click"/>
             <asp:Button runat="server" Text="Settings" ID="btnSettings" OnClick="BtnSettings_Click" />
             <asp:Button runat="server" Text="Logout" ID="btnLogout" OnClick="BtnLogout_Click"/>
             <asp:Button runat="server" Text="Sign In" ID="btnSignIn" OnClick="BtnSignIn_Click"/>
        </div>
    </div>
</asp:Content>
