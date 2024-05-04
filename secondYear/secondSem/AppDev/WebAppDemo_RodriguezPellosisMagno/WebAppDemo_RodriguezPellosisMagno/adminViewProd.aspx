<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="adminViewProd.aspx.cs" Inherits="WebAppDemo_RodriguezPellosisMagno.adminViewProd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 740px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100" __designer:mapid="a0">
        <tr __designer:mapid="a1">
            <td class="auto-style2" __designer:mapid="a2">
                <h1 __designer:mapid="a3">PRODUCT RECORDS</h1>
            </td>
            <td class="auto-style5" __designer:mapid="a4">&nbsp;</td>
            <td class="auto-style6" __designer:mapid="a5">&nbsp;</td>
            <td __designer:mapid="a6">&nbsp;</td>
        </tr>
        <tr __designer:mapid="a7">
            <td colspan="3" __designer:mapid="a8">
                <asp:GridView ID="GridView1" runat="server" Width="955px">
                </asp:GridView>
            </td>
            <td __designer:mapid="aa">&nbsp;</td>
        </tr>
        <tr __designer:mapid="ab">
            <td class="auto-style2" __designer:mapid="ac">
                <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back to Dashboard" Width="171px" />
            </td>
            <td class="auto-style5" __designer:mapid="ad">&nbsp;</td>
            <td class="auto-style6" __designer:mapid="ae">&nbsp;</td>
            <td __designer:mapid="b0">&nbsp;</td>
        </tr>
    </table>
</asp:Content>
