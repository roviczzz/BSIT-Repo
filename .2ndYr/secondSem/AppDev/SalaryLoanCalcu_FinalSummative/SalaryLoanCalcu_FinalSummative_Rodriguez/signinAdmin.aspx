<%@ Page Title="" Language="C#" MasterPageFile="~/defaultMaster.Master" AutoEventWireup="true" CodeBehind="signinAdmin.aspx.cs" Inherits="SalaryLoanCalcu_FinalSummative_Rodriguez.signinAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style1 {
            height: 547px;
        }
    
table {
  border-collapse: collapse;
}

  * {
    text-shadow: none !important;
    box-shadow: none !important;
  }
  
* {
  box-sizing: border-box;
}

  tr {
    page-break-inside: avoid;
  }
        .auto-style14 {
            width: 75px;
            height: 99px;
        }
        .auto-style15 {
            height: 99px;
            width: 1042px;
        }
        .auto-style16 {
            width: 75px;
            height: 93px;
        }
        .auto-style17 {
            height: 93px;
            width: 1042px;
        }
        .auto-style18 {
            width: 75px;
            height: 51px;
        }
        .auto-style19 {
            height: 51px;
            width: 1042px;
        }
        .auto-style8 {
            width: 75px;
            height: 44px;
        }
        .auto-style9 {
            height: 44px;
            width: 1042px;
        }
        .auto-style10 {
            width: 75px;
            height: 59px;
        }
        .auto-style11 {
            height: 59px;
            width: 1042px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style14"></td>
            <td class="auto-style15"></td>
        </tr>
        <tr>
            <td class="auto-style16"></td>
            <td class="auto-style17">
                <h1>admin login</h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style18">
                <asp:Label ID="adminEmail" runat="server"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtAdminEmail" runat="server" placeholder="email"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAdminEmail" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="adminPass" runat="server"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtAdminPass" runat="server" placeholder="password" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAdminPass" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                &nbsp;<asp:Label ID="lblError" runat="server" ForeColor="#FF3300" Text="*invalid details" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style10"></td>
            <td class="auto-style11">
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="125px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
