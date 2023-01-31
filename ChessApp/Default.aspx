<%@ Page Title="Welcome to Chess!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChessApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="/Styles/LoginPage.css" rel="stylesheet" />
    <div class="container-fluid h-100">
        <div class="row h-100">
          <h1>CHESS</h1>
            <div runat="server" ID="loginModal" style="visibility:hidden; display:none;" >
                <asp:TextBox runat="server" Placeholder="Username" ID="tbxUname" />
                <asp:TextBox runat="server" Placeholder="Password" ID="tbxPassword" TextMode="Password"/>
                <asp:Button runat="server"  Text="Login"           ID="btnLogin"    OnClick="BtnLogin_Click" />
                <hr/>
                <asp:HyperLink runat="server" NavigateUrl="Recover_Login.aspx" Text="Frogot Login" />
            </div>
            <div id="defaultMenu">
                <asp:Button runat="server" Text="Login" ID="btnDisplayModal" OnClick="BtnDisplayModal_Click"/>
                <asp:Button runat="server" Text="Play as Guest" ID="btnPlayAsGuest" OnClick="BtnPlayAsGuest_Click"/>
                <asp:Button runat="server" Text="Register" ID="btnRegister" OnClick="BtnRegister_Click"/>
            </div>
        </div>
    </div>
</asp:Content>