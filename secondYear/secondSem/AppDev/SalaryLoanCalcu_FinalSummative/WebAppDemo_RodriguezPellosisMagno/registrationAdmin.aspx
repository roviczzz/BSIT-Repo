<%@ Page Title="" Language="C#" MasterPageFile="~/defaultMaster.Master" AutoEventWireup="true" CodeBehind="registrationAdmin.aspx.cs" Inherits="WebAppDemo_RodriguezPellosisMagno.registrationAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 825px;
        }
        .auto-style5 {
            width: 825px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table __designer:mapid="3" class="auto-style16">
        <tr __designer:mapid="4">
            <td __designer:mapid="5" class="auto-style2"></td>
            <td __designer:mapid="5" class="auto-style36">&nbsp;</td>
            <td __designer:mapid="6" class="auto-style31">
                <h1>admin sign up</h1>
            </td>
            <td __designer:mapid="6" class="auto-style25">&nbsp;</td>
        </tr>
        <tr __designer:mapid="7">
            <td __designer:mapid="8" class="auto-style5">
                <asp:Label ID="adminEmail" runat="server"></asp:Label>
            </td>
            <td __designer:mapid="8" class="auto-style37">&nbsp;</td>
            <td __designer:mapid="a" class="auto-style35">
                <asp:TextBox ID="txtAdminEmail" runat="server" placeholder="email" Width="265px"></asp:TextBox>
            </td>
            <td __designer:mapid="a">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAdminEmail" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr __designer:mapid="d">
            <td __designer:mapid="e" class="auto-style5">
                <asp:Label ID="adminName" runat="server"></asp:Label>
            </td>
            <td __designer:mapid="e" class="auto-style37">&nbsp;</td>
            <td __designer:mapid="10" class="auto-style33">
                <asp:TextBox ID="txtAdminName" runat="server" placeholder="name" Width="265px"></asp:TextBox>
            </td>
            <td __designer:mapid="10" class="auto-style27">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAdminName" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr __designer:mapid="1d">
            <td __designer:mapid="1e" class="auto-style5">
                <asp:Label ID="adminPhone" runat="server"></asp:Label>
            </td>
            <td __designer:mapid="1e" class="auto-style37">&nbsp;</td>
            <td __designer:mapid="20" class="auto-style35">
                <asp:TextBox ID="txtAdminPhone" runat="server" placeholder="phone no." Width="265px"></asp:TextBox>
            </td>
            <td __designer:mapid="20">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAdminPhone" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr __designer:mapid="23">
            <td __designer:mapid="24" class="auto-style5">
                <asp:Label ID="adminPass" runat="server"></asp:Label>
            </td>
            <td __designer:mapid="24" class="auto-style37">&nbsp;</td>
            <td __designer:mapid="26" class="auto-style35">
                <asp:TextBox ID="txtAdminPassword" runat="server" placeholder="password" Width="265px" TextMode="Password"></asp:TextBox>
            </td>
            <td __designer:mapid="26">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAdminPassword" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr __designer:mapid="29">
            <td __designer:mapid="2a" class="auto-style5">
                <asp:Label ID="adminConf" runat="server"></asp:Label>
            </td>
            <td __designer:mapid="2a" class="auto-style37"></td>
            <td __designer:mapid="2c" class="auto-style33">
                <asp:TextBox ID="txtAdminConf" runat="server" placeholder="confirm password" Width="265px" TextMode="Password"></asp:TextBox>
            &nbsp;</td>
            <td __designer:mapid="2c" class="auto-style27">
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtAdminPassword" ControlToValidate="txtAdminConf" ErrorMessage="*password doesn't match" ForeColor="#FF3300"></asp:CompareValidator>
&nbsp;<asp:Label ID="lblError" runat="server" ForeColor="#FF3300" Text="*account already exists" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr __designer:mapid="2f">
            <td __designer:mapid="30" class="auto-style2">&nbsp;</td>
            <td __designer:mapid="30" class="auto-style39">&nbsp;</td>
            <td __designer:mapid="31" class="auto-style35">
                <asp:Button ID="btnUserRegister" runat="server" OnClick="btnUpdate_Click" Text="Sign Up" Width="265px" />
                <br __designer:mapid="33" /></td>
            <td __designer:mapid="31">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
