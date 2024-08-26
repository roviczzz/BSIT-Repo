<%@ Page Title="" Language="C#" MasterPageFile="~/defaultMaster.Master" AutoEventWireup="true" CodeBehind="signupAdmin.aspx.cs" Inherits="SalaryLoanCalcu_FinalSummative_Rodriguez.signupAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">





        .auto-style16 {
            width: 100%;
            height: 386px;
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
        .auto-style3 {
            height: 42px;
            width: 784px;
        }
        .auto-style36 {
            height: 42px;
            width: 52px;
        }
        .auto-style31 {
            height: 42px;
            width: 323px;
            text-align: left;
        }
        .auto-style25 {
            height: 42px;
        }
        .auto-style26 {
            height: 43px;
            width: 784px;
            text-align: right;
        }
        .auto-style37 {
            height: 43px;
            width: 52px;
            text-align: right;
        }
        .auto-style35 {
            width: 323px;
            text-align: left;
        }
        .auto-style33 {
            height: 43px;
            width: 323px;
            text-align: left;
        }
        .auto-style27 {
            height: 43px;
        }
        .auto-style24 {
            height: 43px;
            width: 784px;
        }
        .auto-style39 {
            height: 43px;
            width: 52px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table __designer:mapid="3" class="auto-style16">
        <tr __designer:mapid="4">
            <td __designer:mapid="5" class="auto-style3"></td>
            <td __designer:mapid="5" class="auto-style36">&nbsp;</td>
            <td __designer:mapid="6" class="auto-style31">
                <h1>admin sign up</h1>
            </td>
            <td __designer:mapid="6" class="auto-style25">&nbsp;</td>
        </tr>
        <tr __designer:mapid="7">
            <td __designer:mapid="8" class="auto-style26">
                <asp:Label ID="adminEmail" runat="server"></asp:Label>
            </td>
            <td __designer:mapid="8" class="auto-style37">&nbsp;</td>
            <td __designer:mapid="a" class="auto-style35">
                <asp:TextBox ID="txtAdminEmail" runat="server" placeholder="Email" Width="265px" Height="29px"></asp:TextBox>
            </td>
            <td __designer:mapid="a">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtAdminEmail" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr __designer:mapid="d">
            <td __designer:mapid="e" class="auto-style26">
                <asp:Label ID="adminFirstname" runat="server"></asp:Label>
            </td>
            <td __designer:mapid="e" class="auto-style37">&nbsp;</td>
            <td __designer:mapid="10" class="auto-style33">
                <asp:TextBox ID="txtAdminFirstname" runat="server" placeholder="First Name" Width="265px" Height="29px"></asp:TextBox>
            </td>
            <td __designer:mapid="10" class="auto-style27">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAdminFirstname" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr __designer:mapid="d">
            <td __designer:mapid="e" class="auto-style26">
                <asp:Label ID="adminLastname" runat="server"></asp:Label>
            </td>
            <td __designer:mapid="e" class="auto-style37">&nbsp;</td>
            <td __designer:mapid="10" class="auto-style33">
                <asp:TextBox ID="txtAdminLastname" runat="server" placeholder="Last Name" Width="265px" Height="29px"></asp:TextBox>
            </td>
            <td __designer:mapid="10" class="auto-style27">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtAdminLastname" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr __designer:mapid="23">
            <td __designer:mapid="24" class="auto-style26">
                <asp:Label ID="adminPass" runat="server"></asp:Label>
            </td>
            <td __designer:mapid="24" class="auto-style37">&nbsp;</td>
            <td __designer:mapid="26" class="auto-style35">
                <asp:TextBox ID="txtAdminPassword" runat="server" placeholder="password" TextMode="Password" Width="265px" Height="29px"></asp:TextBox>
            </td>
            <td __designer:mapid="26">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtAdminPassword" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr __designer:mapid="29">
            <td __designer:mapid="2a" class="auto-style26">
                <asp:Label ID="adminConf" runat="server"></asp:Label>
            </td>
            <td __designer:mapid="2a" class="auto-style37"></td>
            <td __designer:mapid="2c" class="auto-style33">
                <asp:TextBox ID="txtAdminConf" runat="server" placeholder="confirm password" TextMode="Password" Width="265px" Height="29px"></asp:TextBox>
                &nbsp;</td>
            <td __designer:mapid="2c" class="auto-style27">
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtAdminPassword" ControlToValidate="txtAdminConf" ErrorMessage="*password doesn't match" ForeColor="#FF3300"></asp:CompareValidator>
                &nbsp;<asp:Label ID="lblError" runat="server" ForeColor="#FF3300" Text="*account already exists" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr __designer:mapid="2f">
            <td __designer:mapid="30" class="auto-style24">&nbsp;</td>
            <td __designer:mapid="30" class="auto-style39">&nbsp;</td>
            <td __designer:mapid="31" class="auto-style35">
                <asp:Button ID="btnAdminRegister" runat="server" OnClick="btnUpdate_Click" Text="Sign Up" Width="265px" />
                <br __designer:mapid="33" /></td>
            <td __designer:mapid="31">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
