<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="OOPWebApp_Rodriguez.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 153px;
            text-align: right;
        }
        .auto-style2 {
            width: 263px;
        }
        .auto-style3 {
            width: 153px;
            text-align: right;
            height: 30px;
        }
        .auto-style4 {
            width: 263px;
            height: 30px;
        }
        .auto-style5 {
            height: 30px;
        }
        .auto-style6 {
            width: 153px;
            text-align: right;
            height: 26px;
        }
        .auto-style7 {
            width: 263px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
        .auto-style9 {
            width: 100%;
            height: 308px;
        }
        .auto-style18 {
            width: 184px;
            height: 30px;
        }
        .auto-style27 {
            width: 138px;
        }
        .auto-style29 {
            width: 207px;
            height: 30px;
        }
        .auto-style30 {
            width: 138px;
            height: 30px;
        }
        .auto-style31 {
            width: 238px;
            height: 30px;
        }
        .auto-style39 {
            width: 207px;
            height: 31px;
        }
        .auto-style40 {
            width: 138px;
            height: 31px;
        }
        .auto-style41 {
            width: 238px;
            height: 31px;
        }
        .auto-style42 {
            height: 31px;
        }
        .auto-style43 {
            width: 184px;
            height: 31px;
        }
        .auto-style44 {
            width: 100%;
            height: 176px;
        }
        .auto-style50 {
            width: 153px;
            text-align: right;
            height: 29px;
        }
        .auto-style51 {
            width: 263px;
            height: 29px;
        }
        .auto-style52 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="RegistrationPanel" runat="server" BorderStyle="None" GroupingText="Registration" Font-Names="Rubik">
            <table style="font-family: rubik;" class="auto-style44">
                <tr>
                    <td class="auto-style50">First Name:</td>
                    <td class="auto-style51">
                        <asp:TextBox ID="txtFirstname" runat="server" Width="229px" ></asp:TextBox>
                    </td>
                    <td class="auto-style52">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtFirstname" ErrorMessage="Only accepts letters *" Font-Names="Rubik" ForeColor="#CC3300" ValidationExpression="[a-zA-Z\s]+"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFirstname" ErrorMessage="Required Input *" ForeColor="#CC3300"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style50">Last Name:</td>
                    <td class="auto-style51">
                        <asp:TextBox ID="txtLastname" runat="server" Width="229px"></asp:TextBox>
                    </td>
                    <td class="auto-style52">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtLastname" ErrorMessage="Only accepts letters *" Font-Names="Rubik" ForeColor="#CC3300" ValidationExpression="[a-zA-Z\s]+"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtLastname" ErrorMessage="Required Input *" ForeColor="#CC3300"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style50">Birthday:</td>
                    <td class="auto-style51">
                        <asp:TextBox ID="txtBirthday" runat="server" TextMode="Date" Width="229px"></asp:TextBox>
                    </td>
                    <td class="auto-style52">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtBirthday" ErrorMessage="Required Input *" ForeColor="#CC3300"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style50">Member&#39;s ID:</td>
                    <td class="auto-style51"><strong>
                        <asp:Label ID="lblID" runat="server"></asp:Label>
                        </strong></td>
                    <td class="auto-style52">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Membership Type:</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="membershipType" runat="server" Height="30px" Width="218px" AutoPostBack="True" OnSelectedIndexChanged="membershipType_SelectedIndexChanged" Font-Names="Rubik">
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem Value="Silver">Silver</asp:ListItem>
                            <asp:ListItem Value="Gold">Gold</asp:ListItem>
                            <asp:ListItem Value="Platinum">Platinum</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style5">
                        <asp:Label ID="lblDiscount" runat="server"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="membershipType" ErrorMessage="Required Input *" ForeColor="#CC3300"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Register" Width="82px" Font-Names="Rubik" />
                    </td>
                    <td class="auto-style5"></td>
                </tr>
            </table>
        </asp:Panel>
        <p>
            &nbsp;</p>
        <asp:Panel ID="TransactionPanel" runat="server" GroupingText="Transaction" Visible="False" Font-Names="Rubik">
            <table class="auto-style9" style="font-family: Rubik">
                <tr>
                    <td class="auto-style29">
                        <asp:DropDownList ID="DropDownProductList" runat="server" Height="30px" Width="202px" Font-Names="Rubik">
                            <asp:ListItem>Select Product</asp:ListItem>
                            <asp:ListItem>Laptop</asp:ListItem>
                            <asp:ListItem>Desktop</asp:ListItem>
                            <asp:ListItem>Printer (dot matrix)</asp:ListItem>
                            <asp:ListItem>Printer (ink jet)</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style30">&nbsp;</td>
                    <td class="auto-style31">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style29">
                        <asp:Button ID="btnAddCart" runat="server" OnClick="btnAddCart_Click" Text="Add to Cart" Width="97px" Font-Names="Rubik" />
                    </td>
                    <td class="auto-style30"></td>
                    <td class="auto-style31"></td>
                    <td class="auto-style18"></td>
                </tr>
                <tr>
                    <td class="auto-style39"><strong>Product</strong></td>
                    <td class="auto-style40"><strong>Quantity</strong></td>
                    <td class="auto-style41"><strong>Price (SRP)</strong></td>
                    <td class="auto-style42">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style39">Laptop</td>
                    <td class="auto-style27">
                        <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
                    </td>
                    <td class="auto-style41">
                        <span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">₱</span><b><span class="NA6bn ILfuVd"> </span></b></span>35,500.00</td>
                    <td class="auto-style43">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style39">Desktop</td>
                    <td class="auto-style40">
                        <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
                    </td>
                    <td class="auto-style41">
                        <span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">₱</span><span class="NA6bn ILfuVd"><b> </b>27,500.00</span></span></td>
                    <td class="auto-style43"></td>
                </tr>
                <tr>
                    <td class="auto-style39">Dot Matrix Printer</td>
                    <td class="auto-style40">
                        <asp:Label ID="Label3" runat="server" Text="0"></asp:Label>
                    </td>
                    <td class="auto-style41">
                        <span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">₱</span><span class="NA6bn ILfuVd"><b> </b>5,500.00</span></span></td>
                    <td class="auto-style43">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style39">Ink Jet Printer</td>
                    <td class="auto-style40">
                        <asp:Label ID="Label4" runat="server" Text="0"></asp:Label>
                    </td>
                    <td class="auto-style41">
                        <span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">₱</span><span class="NA6bn ILfuVd"><b> </b>4,500.00</span></span></td>
                    <td class="auto-style43"></td>
                </tr>
                <tr>
                    <td class="auto-style39">&nbsp;</td>
                    <td class="auto-style40"></td>
                    <td class="auto-style41"></td>
                    <td class="auto-style42"></td>
                </tr>
                <tr>
                    <td colspan="4" class="auto-style42"><strong>Note</strong>: discount applies for at least 3 items purchase*</td>
                </tr>
                <tr>
                    <td class="auto-style39">
                        <asp:Button ID="btnCheckout" runat="server" OnClick="btnCheckout_Click" Text="Checkout" Font-Names="Rubik" />
                    </td>
                    <td class="auto-style40">&nbsp;</td>
                    <td class="auto-style41">&nbsp;</td>
                    <td class="auto-style42">&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    </form>
</body>
</html>
