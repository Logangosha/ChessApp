<%@ Page Language="C#" Title="Game Setup" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Setup.aspx.cs" Inherits="ChessApp.Setup" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid h-100">
        <div class="row h-100">
             <asp:Button runat="server" ID="btnSetGameMode" Text="Game Mode" OnClick="BtnSetGameMode_Click"/>
             <asp:Button runat="server" ID="btnSetTimer" CssClass="d-none invisible" Text="Timer" OnClick="BtnSetTimer_Click"/>
             <asp:Button runat="server" ID="btnPickSide" Text="Pick Side" CssClass="d-none invisible" OnClick="BtnPickSide_Click"/>
             <asp:Button runat="server" ID="btnChooseFriend" Text="Choose Friend" CssClass="d-none invisible" OnClick="BtnChooseFriend_Click"/>
             <asp:Button runat="server" ID="btnSelectComputerDifficulty" CssClass="d-none invisible" Text="Computer Difficulty" OnClick="BtnSelectComputerDifficulty_Click" />
             <asp:Button runat="server" ID="btnStartGame" Text="Start Game" OnClick="BtnStartGame_Click" />
        </div>
    </div>
</asp:Content>
