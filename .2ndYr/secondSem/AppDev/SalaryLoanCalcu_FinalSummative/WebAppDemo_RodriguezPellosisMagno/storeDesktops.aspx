<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="storeDesktops.aspx.cs" Inherits="WebAppDemo_RodriguezPellosisMagno.storeDesktops" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <table class="w-100">
           <tr>
               <td class="auto-style2">
                   <h1>Desktops</h1>
               </td>
               <td>&nbsp;</td>
               <td>&nbsp;</td>
           </tr>
           <tr>
               <td colspan="3">
                   <asp:GridView ID="GridView1" runat="server" DataKeyNames="ProductName" Width="1201px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Height="290px">
                       <SelectedRowStyle CssClass="add-to-cart-button" />
                   </asp:GridView>
               </td>
           </tr>
       </table>




    </asp:Content>
