<%@ Page Title="" Language="C#" MasterPageFile="~/adminMaster.Master" AutoEventWireup="true" CodeBehind="adminIndex.aspx.cs" Inherits="WebAppDemo_RodriguezPellosisMagno.adminIndex" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style4 {
            width: 278px;
            height: 25px;
        }
        .auto-style5 {
            height: 25px;
        }
        .auto-style6 {
            width: 278px;
            height: 26px;
        }
        .auto-style7 {
            height: 26px;
        }
        .auto-style13 {
        width: 278px;
        height: 43px;
    }
        .auto-style15 {
            height: 43px;
        }
        .auto-style8 {
            width: 278px;
        }
        .auto-style16 {
            height: 240px;
            width: 1013px;
        }
        .auto-style17 {
            margin-bottom: 0px;
        }
        .auto-style18 {
            height: 547px;
            width: 1146px;
            margin-right: 0px;
        }
        .auto-style25 {
            width: 278px;
            height: 184px;
        }
        .auto-style26 {
            height: 184px;
        }
        .auto-style27 {
            width: 278px;
            height: 44px;
        }
        .auto-style28 {
            height: 44px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><H1>ADMIN DASHBOARD</H1></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Welcome
                <asp:Label ID="lblAdminName" runat="server"></asp:Label>
                !</td>
            <td>&nbsp;</td>
        </tr>
        </table>
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style17" Height="390px">
        <table class="auto-style16">
            <tr>
                <td class="auto-style4"><strong>ADD A PRODUCT</strong></td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:TextBox ID="txtProdID" runat="server" placeholder="Product ID" Width="215px" OnTextChanged="txtProdID_TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtProdID" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:TextBox ID="txtProdName" runat="server" placeholder="Product Name" Width="215px" OnTextChanged="txtProdName_TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtProdName" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:TextBox ID="txtProdPrice" runat="server" placeholder="Product Price" Width="215px" OnTextChanged="txtProdPrice_TextChanged" TextMode="Number"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtProdPrice" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:TextBox ID="txtProdStock" runat="server" OnTextChanged="txtProdPrice_TextChanged" max="100" min="0" placeholder="No. of Stock" Width="215px" TextMode="Number"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtProdStock" ErrorMessage="*required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:DropDownList ID="drpProdType" runat="server" Height="32px" Width="220px">
                        <asp:ListItem>Keyboard</asp:ListItem>
                        <asp:ListItem>Mouse</asp:ListItem>
                        <asp:ListItem>Desktop</asp:ListItem>
                        <asp:ListItem>Laptop</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">
                    <asp:Button ID="btnAddRecord" runat="server" OnClick="btnAddRecord_Click" Text="Add Record" Width="220px" />
                </td>
                <td class="auto-style15">
                    <asp:Label ID="lblSuccess" runat="server" Text="Product Added Successfully!" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    <br />
    <br />
    <asp:Panel ID="Panel2" runat="server" CssClass="auto-style12" Width="1180px">
        <table class="auto-style18">
            <tr>
                <td class="auto-style13"><strong>VIEWING OF RECORDS</strong></td>
                <td class="auto-style15"></td>
                <td class="auto-style15"></td>
                <td class="auto-style15"></td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Button ID="btnViewProd" runat="server" CausesValidation="False" OnClick="btnViewProd_Click" Text="All Products" Width="210px" />
                </td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:Button ID="btnViewMemberRecord" runat="server" CausesValidation="False" OnClick="btnViewMemberRecord_Click" Text="Member's Records" Width="211px" />
                </td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
            </tr>
            <tr>
                <td class="auto-style28">
                    <asp:Button ID="btnTransactions" runat="server" CausesValidation="False" OnClick="btnTransactions_Click" Text="Transactions" Width="210px" />
                </td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
                <td class="auto-style26">&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    <br />
    <br />
    <br />


</asp:Content>
