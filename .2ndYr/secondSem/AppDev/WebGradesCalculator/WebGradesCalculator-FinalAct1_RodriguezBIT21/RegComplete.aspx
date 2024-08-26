<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegComplete.aspx.cs" Inherits="WebGradesCalculator_FinalAct1_RodriguezBIT21.RegComplete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style2 {
            text-align: center;
            font-size: xx-large;
            color: #00CC00;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style2">
        <strong>Registration Success</strong></p>
    <p class="auto-style1">
        <strong>
        <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" Width="77px" />
        </strong>&nbsp;<strong><asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="height: 26px" Text="Login" Width="77px" />
        </strong>
    </p>
</asp:Content>
