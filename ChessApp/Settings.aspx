<%@ Page Language="C#" Title="Settings" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="ChessApp.Settings" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid h-100">
        <div class="row h-100">
            <asp:button runat="server" ID="btnChangeLogin" Text="Change Login" OnClick="BtnChangeLogin_Click"/>
            <asp:button runat="server" ID="btnChangeTheme" Text="Change Theme" OnCLick="BtnChangeTheme_Click"/>
            <asp:button runat="server" ID="btnChangeAccountInfo" Text="Change Account Info" OnClick="BtnChangeAccountInfo_Click"/>
            <asp:button runat="server" ID="btnDeleteAccount" Text="Delete Account" OnClick="BtnDeleteAccount_Click"/>
        </div>
    </div>
</asp:Content>
