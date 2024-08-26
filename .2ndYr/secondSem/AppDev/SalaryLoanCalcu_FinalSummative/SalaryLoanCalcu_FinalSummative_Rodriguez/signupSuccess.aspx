<%@ Page Title="" Language="C#" MasterPageFile="~/defaultMaster.Master" AutoEventWireup="true" CodeBehind="signupSuccess.aspx.cs" Inherits="SalaryLoanCalcu_FinalSummative_Rodriguez.signupSuccess" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

  * {
    text-shadow: none !important;
    box-shadow: none !important;
  }
  
* {
  box-sizing: border-box;
}

        .auto-style8 {
            text-align: center;
            font-size: xx-large;
            margin-top: 0;
            margin-bottom: 1rem;
            color: lawngreen;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style8" style="orphans: 3; widows: 3;">
        <strong>Registration Success</strong></p>
    <p class="auto-style4">
        <strong>
        <asp:Button ID="btnHome" runat="server" Height="30px" OnClick="btnHome_Click" Text="Home" Width="77px" />
        </strong>&nbsp;<strong><asp:Button ID="btnLogin" runat="server" CssClass="auto-style3" Height="30px" OnClick="btnLogin_Click" Text="Login" Width="77px" />
        </strong>
    </p>
</asp:Content>
