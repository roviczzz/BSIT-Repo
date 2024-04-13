<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="FinalAct1_RodriguezBIT21.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 153px;
        }
        .auto-style3 {
            font-size: medium;
        }
        .auto-style4 {
            width: 1166px;
        }
        .auto-style5 {
            width: 213px;
        }
        .auto-style6 {
            color: #FF0000;
        }
        .auto-style7 {
            width: 153px;
            height: 26px;
        }
        .auto-style8 {
            width: 213px;
            height: 26px;
        }
        .auto-style9 {
            width: 1166px;
            height: 26px;
        }
    </style>
</head>
<body style="font-family:'Segoe UI'">
    <form id="form1" runat="server">
    <p>
        Registration</p>
    <br />
    <div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Student Number</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtStudentNo" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">Name</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style9">
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="btnSave" runat="server" Text="Save" Width="103px" OnClick="btnSave_Click" />
                </td>
                <td class="auto-style4">
                    <asp:Label ID="txtError" runat="server" CssClass="auto-style6" Text="*Record already exists" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
        </div>
        <br />
        <div>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="auto-style3" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
