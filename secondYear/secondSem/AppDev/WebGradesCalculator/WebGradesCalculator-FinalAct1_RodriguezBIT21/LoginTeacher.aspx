<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LoginTeacher.aspx.cs" Inherits="WebGradesCalculator_FinalAct1_RodriguezBIT21.LoginTeacher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


    .auto-style5 {
        font-size: x-large;
    }
    .auto-style1 {
        width: 100%;
    }
    .auto-style3 {
        width: 167px;
        text-align: right;
        height: 30px;
    }
    .auto-style4 {
        height: 30px;
    }
    .auto-style2 {
        width: 167px;
        text-align: right;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style5">
        Teacher Login</p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3"><strong>TeacherID</strong></td>
            <td class="auto-style4">
                <asp:TextBox ID="txtTeacherID" runat="server" Width="171px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTeacherID" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
        &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"><strong>Password</strong></td>
            <td>
                <asp:TextBox ID="txtPass" runat="server" Width="171px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPass" ErrorMessage="*required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Label ID="txtError" runat="server" CssClass="auto-style6" ForeColor="#FF3300" Text="*incorrect details" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnLogin" runat="server" Text="Login" Width="113px" OnClick="btnReg_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
