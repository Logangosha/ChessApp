<%@ Page Language="C#" Title="Play Chess" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Play.aspx.cs" Inherits="ChessApp.Play" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid h-100">
        <div class="row h-100">
            <asp:Button runat="server" ID="btnPlayComputer" text="Play Computer" OnClick="BtnPlayComputer_Click" OnCommand="BtnPlayChess_Command" CommandName="Computer"/>
            <asp:Button runat="server" ID="btnPlayOnline" Text="Play Online" OnClick="BtnPlayOnline_Click" OnCommand="BtnPlayChess_Command" CommandName="Online"/>
            <asp:Button runat="server" ID="btnPassPlay" Text="Pass and Play" OnClick="BtnPassPlay_Click" OnCommand="BtnPlayChess_Command" CommandName="Pass"/>
        </div>
    </div>
</asp:Content>
