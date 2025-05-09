﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegTeacher.aspx.cs" Inherits="WebGradesCalculator_FinalAct1_RodriguezBIT21.Teacher_Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 167px;
        text-align: right;
    }
    .auto-style3 {
        width: 167px;
        text-align: right;
        height: 30px;
    }
    .auto-style4 {
        height: 30px;
    }
    .auto-style5 {
        font-size: x-large;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style5">
    Teacher Registration</p>
<table class="auto-style1">
    <tr>
        <td class="auto-style3"><strong>TeacherID</strong></td>
        <td class="auto-style4">
            <asp:TextBox ID="txtTeacherID" runat="server" Width="171px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTeacherID" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtTeacherID" ErrorMessage="*only numbers" ForeColor="#FF3300" ValidationExpression="^\d+$" ValidationGroup="OnlyNumbers"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3"><strong>Teacher Name</strong></td>
        <td class="auto-style4">
            <asp:TextBox ID="txtName" runat="server" Width="171px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtName" ErrorMessage="*only alphabetic letters" ForeColor="#FF3300" ValidationExpression="^[a-zA-Z\s]+$"></asp:RegularExpressionValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style2"><strong>Password</strong></td>
        <td>
            <asp:TextBox ID="txtPass" runat="server" Width="171px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPass" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3"><strong>Confirm Password</strong></td>
        <td class="auto-style4">
            <asp:TextBox ID="txtConfirmPass" runat="server" Width="171px"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPass" ControlToValidate="txtConfirmPass" ErrorMessage="*Password doesn't match" ForeColor="Red"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>
            <asp:Label ID="txtError" runat="server" CssClass="auto-style6" ForeColor="#FF3300" Text="*Teacher already registered" Visible="False"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>
            <asp:Button ID="btnReg" runat="server" Text="Confirm" Width="113px" OnClick="btnReg_Click" />
        &nbsp;</td>
    </tr>
</table>
</asp:Content>
