<%@ Page Title="" Language="C#" MasterPageFile="~/defaultMaster.Master" AutoEventWireup="true" CodeBehind="registrationComplete.aspx.cs" Inherits="WebAppDemo_RodriguezPellosisMagno.registrationComplete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style2 {
            text-align: center;
            font-size: xx-large;
            color: #00CC00;
        }
        .auto-style3 {
            height: 26px;
            margin-top: 0;
        }
        .auto-style4 {
            height: 547px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style2">
        <strong>Registration Success</strong></p>
    <p class="auto-style4">
        <strong>
        <asp:Button ID="btnHome" runat="server" Height="30px" OnClick="btnHome_Click" Text="Home" Width="77px" />
        </strong>&nbsp;<strong><asp:Button ID="btnLogin" runat="server" CssClass="auto-style3" Height="30px" OnClick="btnLogin_Click" Text="Login" Width="77px" />
        </strong>
    </p>
</asp:Content>
