<%@ Page Title="" Language="C#" MasterPageFile="~/defaultMaster.Master" AutoEventWireup="true" CodeFile="indexSignup.aspx.cs" Inherits="SalaryLoanCalcu_FinalSummative_Rodriguez.indexSignup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


        .auto-style14 {
            height: 547px;
            width: 1127px;
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
        .auto-style27 {
            width: 784px;
            height: 66px;
        }
        .auto-style21 {
            height: 66px;
            text-align: center;
        }
        
.text-center {
  text-align: center !important;
}

        .auto-style31 {
            height: 25px;
            width: 784px;
        }
        .auto-style30 {
            text-align: center;
            height: 25px;
        }
        .auto-style28 {
            height: 34px;
            width: 784px;
        }
        .auto-style32 {
            font-weight: 500;
            line-height: 1.2;
            font-size: 2.5rem;
            margin-top: 0;
            margin-bottom: 0.5rem;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style14">
        <tr>
            <td class="auto-style27"></td>
            <td class="auto-style21">
                <h1 class="auto-style32">Sign Up</h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style31"></td>
            <td class="auto-style30">select your account type</td>
        </tr>
        <tr>
            <td class="auto-style28">&nbsp;</td>
            <td class="text-center">
                <asp:Button ID="btnUser" runat="server" CssClass="auto-style7" OnClick="btnUser_Click" Text="User" Width="198px" />
                <br />
                <br />
                <asp:Button ID="btnAdmin" runat="server" OnClick="btnAdmin_Click" Text="Admin" Width="201px" Height="35px" />
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
