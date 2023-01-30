<%@ Page Title="Welcome to Chess!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChessApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="/Styles/LoginPage.css" rel="stylesheet" />
    <div class="container-fluid h-100">
        <div class="row h-100">
          <h1>CHESS</h1>
            <div runat="server" ID="loginModal" style="visibility:hidden; display:none;" >
                <asp:TextBox runat="server" Placeholder="Username" ID="unameTbx" />
                <asp:TextBox runat="server" Placeholder="Password" ID="passwordTbx" TextMode="Password"/>
                <asp:Button runat="server"  Text="Login"           ID="loginBtn"    OnClick="loginBtn_Click" />
                <hr/>
                <asp:HyperLink runat="server" NavigateUrl="Recover_Login.aspx" Text="Frogot Login" />
            </div>
            <div id="defaultMenu">
                <asp:Button runat="server" Text="Login" ID="displayModalBtn" OnClick="displayModalBtn_Click"/>
                <asp:Button runat="server" Text="Play as Guest" ID="playAsGuestBtn" OnClick="playAsGuestBtn_Click"/>
                <asp:Button runat="server" Text="Register" ID="registerBtn" OnClick="registerBtn_Click"/>
            </div>
        </div>
    </div>
    <script type="text/javascript">
    </script>
</asp:Content>