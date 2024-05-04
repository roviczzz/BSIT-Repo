<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="userTransactions.aspx.cs" Inherits="WebAppDemo_RodriguezPellosisMagno.userTransactions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 __designer:mapid="244">TRANSACTION HISTORY</h1>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br __designer:mapid="246" />
    <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" Width="220px" />
    <br __designer:mapid="248" />
</asp:Content>
