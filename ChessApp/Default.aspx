<%@ Page Title="Welcome to Chess!" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
CodeBehind="Default.aspx.cs" Inherits="ChessApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid h-100">
        <div class="row h-100">
            <!-- Left side col -->
            <div class="col-md-4 bg-warning"></div>
            <!-- Middle col -->
            <div class="col-md-4 align-self-center bg-primary">
                <div class="row">
                    <!-- Login Form -->
                    <div class="col-md-6 bg-secondary">
                        <h1 class="text-center">Welcome to Chess!</h1>
                    </div>
                    <!-- Image col -->
                    <div class="col-md-6 bg-warning">
                        <h1 class="text-center">Welcome to Chess!</h1>
                    </div>
                </div>
            </div>
            <!-- Right side col -->
            <div class="col-md-4 bg-info"></div>
        </div>
    </div>
</asp:Content>