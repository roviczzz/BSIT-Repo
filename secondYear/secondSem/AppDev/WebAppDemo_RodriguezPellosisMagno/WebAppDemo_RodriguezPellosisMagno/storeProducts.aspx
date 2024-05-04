<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="storeProducts.aspx.cs" Inherits="WebAppDemo_RodriguezPellosisMagno.storeProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 481px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style2">    <h1>All Products</h1>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
<asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" DataKeyNames="ProductName" Width="1201px" AutoGenerateSelectButton="True" OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Height="290px">
<SelectedRowStyle CssClass="add-to-cart-button" />
</asp:GridView>




            </td>
        </tr>
    </table>




    </asp:Content>
