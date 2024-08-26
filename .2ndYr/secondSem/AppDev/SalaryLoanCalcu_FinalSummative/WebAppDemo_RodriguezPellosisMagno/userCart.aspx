<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="userCart.aspx.cs" Inherits="WebAppDemo_RodriguezPellosisMagno.userCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            margin-top: 17;
        }
        .auto-style3 {
            height: 59px;
        }
        .auto-style4 {
            font-weight: bold;
        }
        .auto-style5 {
            height: 59px;
            width: 170px;
        }
        .auto-style6 {
            width: 170px;
        }
        .auto-style7 {
            height: 59px;
            width: 170px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Shopping Cart</h1>
         <div>
<asp:GridView ID="GridView1" runat="server" DataKeyNames="ProductName" Width="525px">
<SelectedRowStyle CssClass="add-to-cart-button" />
</asp:GridView>


             <br />
             <table class="w-100">
                 <tr>
                     <td class="auto-style7"><strong>Total Amount</strong>: Php
             
                     </td>
                     <td class="auto-style3">
             <asp:Label ID="lblTotalAmount" runat="server"></asp:Label>

                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style7"><strong>V</strong><span class="auto-style4">AT</span>: Php
             
                     </td>
                     <td class="auto-style3">
             <asp:Label ID="lblVAT" runat="server"></asp:Label>

                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style7"><strong>Final Amount</strong>: Php
             
                     </td>
                     <td class="auto-style3">
             <asp:Label ID="lblFinalPrice" runat="server"></asp:Label>

                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style5">&nbsp;</td>
                     <td class="auto-style3">
             <asp:Button ID="btnCheckout" runat="server" CssClass="auto-style2" OnClick="btnCheckout_Click1" Text="Checkout" Width="135px" />
             <asp:Label ID="lblError" runat="server" Visible="False" ForeColor="#FF3300">*add items to cart</asp:Label>

                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style6">
                         &nbsp;</td>
                     <td>
                         &nbsp;</td>
                 </tr>
             </table>
             <br />

            <br />
            <br />
        </div>
</asp:Content>
