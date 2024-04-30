<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LoginSelect.aspx.cs" Inherits="WebGradesCalculator_FinalAct1_RodriguezBIT21.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style1">
        <strong>
        <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Select Login"></asp:Label>
        </strong>
    </p>
    <p class="auto-style1">
        <strong>
        <asp:Button ID="btnStudent" runat="server" OnClick="btnHome_Click" Text="Student" Width="145px" />
        </strong>
    </p>
    <p class="auto-style1">
        <strong>
        <asp:Button ID="btnTeacher" runat="server" OnClick="btnLogin_Click" style="height: 26px" Text="Teacher" Width="77px" />
        </strong>
    </p>
</asp:Content>
