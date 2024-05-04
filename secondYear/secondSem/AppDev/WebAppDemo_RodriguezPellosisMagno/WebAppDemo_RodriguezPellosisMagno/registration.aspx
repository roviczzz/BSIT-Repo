<%@ Page Title="" Language="C#" MasterPageFile="~/defaultMaster.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="WebAppDemo_RodriguezPellosisMagno.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style14 {
            height: 547px;
            width: 1127px;
        }
        .auto-style21 {
            height: 66px;
            text-align: center;
        }
        .auto-style27 {
            width: 784px;
            height: 66px;
        }
        .auto-style28 {
            height: 34px;
            width: 784px;
        }
        .auto-style30 {
            text-align: center;
            height: 25px;
        }
        .auto-style31 {
            height: 25px;
            width: 784px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style14">
        <tr>
            <td class="auto-style27"></td>
            <td class="auto-style21"><h1 class="text-center">Sign Up</h1></td>
        </tr>
        <tr>
            <td class="auto-style31"></td>
            <td class="auto-style30">select your account type</td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="text-center">
                <asp:Button ID="btnUser" runat="server" CssClass="auto-style7" OnClick="btnUser_Click" Text="User" Width="198px" />
                <asp:Button ID="btnAdmin" runat="server" OnClick="btnAdmin_Click" Text="Admin" Width="201px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="text-center">&nbsp;</td>
        </tr>
        </table>
</asp:Content>
