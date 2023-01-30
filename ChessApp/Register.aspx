<%@ Page Language="C#" Title="Register" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ChessApp.Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid h-100">
        <div class="row h-100">
            <h1>Create Account</h1>
            <asp:TextBox runat="server" Placeholder="First Name"                            ID="fnameTbx"/>
            <asp:TextBox runat="server" Placeholder="Last Name"                             ID="lnameTbx"/>
            <asp:TextBox runat="server" Text='<%# Bind("DateofBirth", "{0:dd-MM-yyyy}") %>' ID="TxtDob"             TextMode="Date"/>  
            <asp:TextBox runat="server" Placeholder="Username"                              ID="unameTbx"/>
            <asp:TextBox runat="server" Placeholder="Email"                                 ID="emailTbx"           TextMode="Email"/>
            <asp:TextBox runat="server" Placeholder="Password"                              ID="passwordTbx"        TextMode="Password"/>
            <asp:TextBox runat="server" Placeholder="Confirm Password"                      ID="passwordConfirmTbx" TextMode="Password"/>
            <asp:Button  runat="server" Text="Register"                                     ID="registerBtn"        OnClick="registerBtn_Click"/>
        </div>
    </div>
</asp:Content>
