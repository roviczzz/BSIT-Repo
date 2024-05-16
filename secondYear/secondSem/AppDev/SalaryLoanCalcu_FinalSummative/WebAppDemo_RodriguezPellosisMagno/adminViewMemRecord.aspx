<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="adminViewMemRecord.aspx.cs" Inherits="WebAppDemo_RodriguezPellosisMagno.adminViewMemRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 458px;
        }
        .auto-style5 {
            width: 684px;
        }
        .auto-style6 {
            width: 253px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style1" Width="999px">
        <table class="w-100">
            <tr>
                <td class="auto-style2">
                    <h1>MEMBER RECORDS</h1>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="GridView1" runat="server" Width="955px">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back to Dashboard" Width="171px" />
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
