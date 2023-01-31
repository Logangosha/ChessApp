<%@ Page Language="C#" Title="Recover Login" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Recover_Login.aspx.cs" Inherits="ChessApp.Recover_Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid h-100">
        <div class="row h-100">
            <div runat="server" ID="sectionRecoverySentCode" class="d-none invisible h-100">
                 <asp:label runat="server" ID="lbRecovery" Text="A password reset link has been sent to the email of the account."/>
                 <asp:Button runat="server" ID="btnRecoveryResend" Text="Resend Code" OnClick="BtnRecoveryResend_Click"/>
            </div>
            <div runat="server" ID="sectionRecoverySubmitEmail" class="d-block visible h-100">
                <asp:TextBox runat="server" Placeholder="Enter Username or Email" ID="tbxRecovery" />
                <asp:Button runat="server" Text="Recover Account" ID="recoveryBtn" OnClick="BtnRecovery_Click"/>
            </div>
        </div>
    </div>
</asp:Content>
