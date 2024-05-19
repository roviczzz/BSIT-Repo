<%@ Page Title="" Language="C#" MasterPageFile="~/defaultMaster.Master" AutoEventWireup="true" CodeBehind="signinUser.aspx.cs" Inherits="SalaryLoanCalcu_FinalSummative_Rodriguez.signinUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style2 {
            height: 547px;
            width: 1117px;
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
        .auto-style16 {
            width: 273px;
            height: 99px;
        }
        .auto-style17 {
            width: 273px;
            height: 93px;
        }
        .auto-style12 {
            width: 75px;
            height: 51px;
        }
        .auto-style18 {
            width: 273px;
            height: 51px;
        }
        .auto-style14 {
            width: 75px;
            height: 44px;
        }
        .auto-style19 {
            width: 273px;
            height: 44px;
        }
        .auto-style15 {
            width: 75px;
            height: 59px;
        }
        .auto-style20 {
            width: 273px;
            height: 59px;
        }
        .auto-style3 {
            width: 75px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
        <tr>
            <td class="auto-style4"></td>
            <td class="auto-style16"></td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style17">
                <h1>user login</h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">
                <asp:Label ID="userEmail" runat="server"></asp:Label>
            </td>
            <td class="auto-style18">
                <asp:TextBox ID="txtUserEmail" runat="server" placeholder="email"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserEmail" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">
                <asp:Label ID="userPass" runat="server"></asp:Label>
            </td>
            <td class="auto-style19">
                <asp:TextBox ID="txtUserPass" runat="server" placeholder="password" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtUserPass" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                &nbsp;<asp:Label ID="lblError" runat="server" ForeColor="#FF3300" Text="*invalid details" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style15"></td>
            <td class="auto-style20">
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="125px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
