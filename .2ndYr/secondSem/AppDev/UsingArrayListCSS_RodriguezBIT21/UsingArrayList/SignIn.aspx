<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="UsingArrayList.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style1 {
            width: 100%;
            font-size: small;
        }
        .auto-style4 {
            width: 141px;
            text-align: right;
        }
        .auto-style5 {
            height: 20px;
        }
    .auto-style6 {
        width: 71%;
        font-size: small;
        float: left;
        height: 180px;
        margin-left: 8px;
        margin-right: 10px;
        margin-top: 0;
        margin-bottom: 0;
        padding: 1%;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" style="font-size: small" Font-Bold="False" Width="661px">
        <table class="auto-style6" >
            <tr>
                <td class="auto-style5" colspan="2"><strong>LOGIN</strong></td>
            </tr>
            <tr>
                <td class="auto-style4">User Name</td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="Required Input *" ForeColor="#CC3300"></asp:RequiredFieldValidator>
                    <asp:Label ID="lblEmail" runat="server" ForeColor="#CC3300" Text="Invalid Email *" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPassword" ErrorMessage="Required Input *" ForeColor="#CC3300"></asp:RequiredFieldValidator>
                    <asp:Label ID="lblPassword" runat="server" ForeColor="#CC3300" Text="Wrong or invalid Password *" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" Width="88px" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
