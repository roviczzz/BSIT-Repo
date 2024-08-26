<%@ Page Title="" Language="C#" MasterPageFile="~/defaultMaster.Master" AutoEventWireup="true" CodeBehind="loginCheck.aspx.cs" Inherits="WebAppDemo_RodriguezPellosisMagno.loginCheck" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 794px;
        }
        .auto-style3 {
            width: 100%;
            height: 374px;
        }
        .auto-style4 {
            height: 47px;
        }
        .auto-style5 {
            width: 794px;
            height: 47px;
        }
        .auto-style7 {
            width: 794px;
            height: 95px;
        }
        .auto-style8 {
            height: 95px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style3">
        <tr>
        <td class="auto-style8"></td>
        <td class="auto-style7"><h1>Welcome!</h1></td>
            <td class="auto-style8"></td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
        <td class="auto-style4"></td>
        <td class="auto-style5">Please login to your account</td>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
        <td class="auto-style21">
            &nbsp;</td>
        <td class="auto-style2">
            <asp:TextBox ID="txtUserName" runat="server" Height="24px" placeholder="email" ToolTip="input email" Width="221px"></asp:TextBox>
        </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
        <td class="auto-style21">
            &nbsp;</td>
        <td class="auto-style2">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
        <td class="auto-style20">
            &nbsp;</td>
        <td class="auto-style2">
            <asp:Button ID="btnCheck" runat="server" OnClick="btnLogin_Click" Text="Login" Width="170px" />
        </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">Don&#39;t have an account? <a href="registration.aspx">Sign up</a></td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
