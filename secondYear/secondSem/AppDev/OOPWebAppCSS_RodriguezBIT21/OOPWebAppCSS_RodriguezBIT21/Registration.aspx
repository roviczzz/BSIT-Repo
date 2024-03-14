<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="OOPWebAppCSS_RodriguezBIT21.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<link rel="stylesheet" type="text/css" href="design/style_no.css" />
<title>StoreName</title>
    <style type="text/css">
        .auto-style1 {
            width: 480px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
<div id="Conteneur">
<div id="header"><p id="logo1">Store</p><p id="logo2">&nbsp; Registration</p></div>
<div id="center">
<div id="menu">
<a href="Registration.aspx">Home</a>
</div>
<div id="contenu">


    <asp:Panel ID="RegistrationPanel" runat="server" BorderStyle="None" Font-Names="Rubik">
        <table class="auto-style44" style="font-family: rubik;">
            <tr>
                <td class="auto-style50">First Name:</td>
                <td class="auto-style51">
                    <asp:TextBox ID="txtFirstname" runat="server" Width="229px"></asp:TextBox>
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
                    <asp:DropDownList ID="membershipType" runat="server" AutoPostBack="True" Font-Names="Rubik" Height="30px" OnSelectedIndexChanged="membershipType_SelectedIndexChanged" Width="218px">
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
                    <asp:Button ID="Button1" runat="server" Font-Names="Rubik" OnClick="Button1_Click" style="height: 26px" Text="Register" Width="82px" />
                </td>
                <td class="auto-style5"></td>
            </tr>
        </table>
    </asp:Panel>
    <br>
    <asp:Panel ID="TransactionPanel" runat="server" Font-Names="Rubik" Visible="False">
        <table class="auto-style1" style="font-family: Rubik">
            <tr>
                <td class="auto-style29">
                    <asp:DropDownList ID="DropDownProductList" runat="server" Font-Names="Rubik" Height="30px" Width="202px">
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
                    <asp:Button ID="btnAddCart" runat="server" Font-Names="Rubik" OnClick="btnAddCart_Click" Text="Add to Cart" Width="97px" />
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
                <td class="auto-style41"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">&#8369;</span><b><span class="NA6bn ILfuVd"> </span></b></span>35,500.00</td>
                <td class="auto-style43">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style39">Desktop</td>
                <td class="auto-style40">
                    <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style41"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">&#8369;</span><span class="NA6bn ILfuVd"><b> </b>27,500.00</span></span></td>
                <td class="auto-style43"></td>
            </tr>
            <tr>
                <td class="auto-style39">Dot Matrix Printer</td>
                <td class="auto-style40">
                    <asp:Label ID="Label3" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style41"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">&#8369;</span><span class="NA6bn ILfuVd"><b> </b>5,500.00</span></span></td>
                <td class="auto-style43">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style39">Ink Jet Printer</td>
                <td class="auto-style40">
                    <asp:Label ID="Label4" runat="server" Text="0"></asp:Label>
                </td>
                <td class="auto-style41"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">&#8369;</span><span class="NA6bn ILfuVd"><b> </b>4,500.00</span></span></td>
                <td class="auto-style43"></td>
            </tr>
            <tr>
                <td class="auto-style39">&nbsp;</td>
                <td class="auto-style40"></td>
                <td class="auto-style41"></td>
                <td class="auto-style42"></td>
            </tr>
            <tr>
                <td class="auto-style42" colspan="4"><strong>Note</strong>: discount applies for at least 3 items purchase*</td>
            </tr>
            <tr>
                <td class="auto-style39">
                    <asp:Button ID="btnCheckout" runat="server" Font-Names="Rubik" OnClick="btnCheckout_Click" Text="Checkout" />
                </td>
                <td class="auto-style40">&nbsp;</td>
                <td class="auto-style41">&nbsp;</td>
                <td class="auto-style42">&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>


</div>
</div>
<div id="pied"><p>Rodriguez, Rovic M. <span class="hgKElc"><span class="ILfuVd" lang="en">&#8212;</span><span class="ILfuVd"> BIT21</span></span></p></div>
</div>
    </form>
</body>
</html>
