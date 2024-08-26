<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="SearchRecord.aspx.cs" Inherits="UsingArrayList.SearchRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">


        .auto-style1 {
            width: 100%;
            font-size: small;
        }
        .auto-style5 {
            height: 20px;
        }
        .auto-style4 {
            width: 70px;
            text-align: right;
        }
        .auto-style7 {
            height: 29px;
        }
        .auto-style9 {
            height: 30px;
        }
        .auto-style10 {
            height: 20px;
            width: 387px;
        }
        .auto-style11 {
            height: 29px;
            width: 387px;
        }
        .auto-style13 {
            width: 387px;
        }
        .auto-style15 {
            width: 98%;
            font-size: small;
            float: left;
            height: 364px;
            margin-left: 8px;
            margin-right: 10px;
            margin-top: 0;
            margin-bottom: 0;
            padding: 1%;
        }
        .auto-style16 {
            height: 30px;
            width: 387px;
        }
        .auto-style18 {
            height: 29px;
            width: 101px;
        }
        .auto-style20 {
            width: 101px;
        }
        .auto-style21 {
            height: 20px;
            width: 101px;
        }
        .auto-style22 {
            height: 30px;
            width: 101px;
        }
        .auto-style25 {
            height: 20px;
            width: 70px;
        }
        .auto-style26 {
            height: 29px;
            width: 387px;
            text-align: left;
        }
        .auto-style27 {
            width: 70px;
            text-align: right;
            height: 29px;
        }
        .auto-style28 {
            width: 70px;
            text-align: right;
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Search" runat="server" style="font-size: small" Font-Bold="False" Width="643px" Height="353px">
        <table class="auto-style15" >
            <tr>
                <td class="auto-style5" colspan="2"><strong>SEARCH RECORD</strong></td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">&nbsp;Email</td>
                <td class="auto-style26">
                    <asp:TextBox ID="txtUsername" runat="server" Width="159px"></asp:TextBox>
                </td>
                <td class="auto-style18"></td>
                <td class="auto-style7">
                    &nbsp;</td>
                <td class="auto-style7"></td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style27"></td>
                <td class="auto-style11">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="Required Input *" ForeColor="#CC3300"></asp:RequiredFieldValidator>
                    <asp:Label ID="lblEmail" runat="server" ForeColor="#CC3300" Text="Invalid Email *" Visible="False"></asp:Label>
                </td>
                <td class="auto-style18"></td>
                <td class="auto-style7"></td>
                <td class="auto-style7"></td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style27">&nbsp;</td>
                <td class="auto-style11">
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style16">
                    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" style="font-size: small" Width="349px">
                        <FooterStyle BackColor="White" ForeColor="#333333" />
                        <HeaderStyle BackColor="#FF9900" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#487575" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#275353" />
                    </asp:GridView>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28"></td>
                <td class="auto-style16">
                    <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" Text="Search" Width="88px" />
                </td>
                <td class="auto-style22"></td>
                <td class="auto-style9"></td>
                <td class="auto-style9"></td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style20">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
