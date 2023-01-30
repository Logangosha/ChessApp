<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ChessApp.Home" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid h-100">
        <div class="row h-100">
             <asp:Button runat="server" Text="Notifications" ID="notificationsBtn" OnClick="notificationsBtn_Click"/>
             <asp:Button runat="server" Text="Play Chess" ID="playChessBtn" OnClick="playChessBtn_Click"/>
             <asp:Button runat="server" Text="Friends" ID="friendsBtn" OnClick="friendsBtn_Click"/>
             <asp:Button runat="server" Text="History" ID="historyBtn" OnClick="historyBtn_Click"/>
             <asp:Button runat="server" Text="Logout" ID="logoutBtn" OnClick="logoutBtn_Click"/>
        </div>
    </div>
</asp:Content>
