<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="userCheckoutComplete.aspx.cs" Inherits="WebAppDemo_RodriguezPellosisMagno.userCheckoutComplete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td>&nbsp;</td>
            <td class="text-center">
                <p class="auto-style2">
                    <h1><strong>Order Success</strong></h1>Thank you for shopping with us!</p>
                <p class="auto-style4">
                    <strong>
                    <asp:Button ID="btnHome" runat="server" Height="30px" OnClick="btnHome_Click" Text="Home" Width="132px" />
                    </strong>&nbsp;</p>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="text-center">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
