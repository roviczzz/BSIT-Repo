<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="ViewAll.aspx.cs" Inherits="LongQuiz_RodriguezBIT21.WebForm4" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Font-Names="Rubik" CssClass="auto-style2">
        <h1 style="font-weight: bold; font-family: Rubik; color: #09814a">RECORDS LIST</h1>
        <p>
            All client records</p>
        <span class="auto-style2">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="centered padded centered-padded" ForeColor="#09814a" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="MiddleInitial" HeaderText="Middle Initial" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="Phone No." />
                <asp:BoundField DataField="userAddress" HeaderText="Address" />
                <asp:BoundField DataField="Birthday" HeaderText="Birthday"
                    DataFormatString="{0:MM/dd/yyyy}" HtmlEncode="false" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" />
                <asp:BoundField HeaderText="Type" DataField="userType" />
                <asp:BoundField DataField="userPassword" HeaderText="Password" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#09814a" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#09814a" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        </span>
    </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
    .auto-style2 {
        margin-left: 275px;
    }
</style>
</asp:Content>

