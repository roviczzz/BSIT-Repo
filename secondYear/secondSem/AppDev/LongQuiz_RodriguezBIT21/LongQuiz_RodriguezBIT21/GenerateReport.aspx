<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="GenerateReport.aspx.cs" Inherits="LongQuiz_RodriguezBIT21.WebForm5" %><%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Font-Names="Rubik Bold" CssClass="auto-style1">
    <h1 class="auto-style3"><strong>GENERATED REPORT</strong></h1>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <br />
    <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="1165px">
    </rsweb:ReportViewer>
    <br />
</asp:Panel>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
    .auto-style1 {
        margin-left: 275px;
    }
        .auto-style2 {
            font-family: Rubik;
            color: #09814A;
        }
        .auto-style3 {
            font-family: Rubik;
            color: #09814A;
            font-weight: bold;
        }
    </style>
</asp:Content>

