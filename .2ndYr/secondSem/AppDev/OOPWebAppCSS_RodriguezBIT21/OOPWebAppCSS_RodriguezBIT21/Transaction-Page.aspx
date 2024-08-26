<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transaction-Page.aspx.cs" Inherits="OOPWebAppCSS_RodriguezBIT21.Transaction_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
<link rel="stylesheet" type="text/css" href="design/style_no.css" />
<title>StoreName</title>
    <style type="text/css">
        .auto-style1 {
            height: 21px;
        }
        .auto-style2 {
            width: 480px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
<div id="Conteneur">
<div id="header"><p id="logo1">Store</p><p id="logo2">&nbsp; Transaction</p></div>
<div id="center">
<div id="menu">
<a href="Registration.aspx">Home</a>
</div>
<div id="contenu" style="font-size: medium">


    <asp:Panel ID="UserInfo" runat="server" CssClass="auto-style6" Height="133px">
        <table class="auto-style2">
            <tr>
                <td class="auto-style3" style="font-family: Rubik">Name:</td>
                <td class="auto-style4" style="font-family: Rubik"><strong>
                    <asp:Label ID="lblName" runat="server"></asp:Label>
                    </strong></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style5" style="font-family: Rubik">Member ID:</td>
                <td style="font-family: Rubik"><strong>
                    <asp:Label ID="lblID" runat="server"></asp:Label>
                    </strong></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5" style="font-family: Rubik">Member Type:</td>
                <td style="font-family: Rubik"><strong>
                    <asp:Label ID="lblMemberType" runat="server"></asp:Label>
                    </strong></td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Transaction" runat="server" CssClass="auto-style54" Height="235px" Width="479px">
        <table class="auto-style1" style="font-family: Arial, Helvetica, sans-serif; table-layout: fixed; border-collapse: collapse; border-spacing: inherit; border-style: solid; border-width: thin">
            <tr>
                <td class="auto-style1" style="font-family: Rubik; background-color: #92847B; color: #FFFFFF;"><strong>Product</strong></td>
                <td class="auto-style1" style="font-family: Rubik; background-color: #92847B; color: #FFFFFF;"><strong>Quantity</strong></td>
                <td class="auto-style1" style="font-family: Rubik; background-color: #92847B; color: #FFFFFF;"><strong>Price</strong></td>
            </tr>
            <tr>
                <td id="row1" class="auto-style63" style="font-family: Rubik;">
                    <asp:Label ID="lblLaptop" runat="server" Text="Laptop"></asp:Label>
                </td>
                <td id="row6" class="auto-style66" style="font-family: Rubik;">
                    <asp:Label ID="lblq1" runat="server" Text="0"></asp:Label>
                </td>
                <td id="row7" class="auto-style58" style="font-family: Rubik;"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">&#8369;</span></span>&nbsp;<asp:Label ID="lblp1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td id="row2" class="auto-style63" style="font-family: Rubik;">
                    <asp:Label ID="lblDesktop" runat="server" Text="Desktop"></asp:Label>
                </td>
                <td id="row8" class="auto-style66" style="font-family: Rubik;">
                    <asp:Label ID="lblq2" runat="server" Text="0"></asp:Label>
                </td>
                <td id="row9" class="auto-style39" style="font-family: Rubik;"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">&#8369;</span></span>&nbsp;<asp:Label ID="lblp2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td id="row3" class="auto-style63" style="font-family: Rubik;">
                    <asp:Label ID="lblPrinter1" runat="server" Text="Dot Matrix Printer"></asp:Label>
                </td>
                <td id="row11" class="auto-style66" style="font-family: Rubik;">
                    <asp:Label ID="lblq3" runat="server" Text="0"></asp:Label>
                </td>
                <td id="row12" class="auto-style58" style="font-family: Rubik;"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">&#8369;</span></span>&nbsp;<asp:Label ID="lblp3" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td id="row4" class="auto-style63" style="border-width: thin; font-family: Rubik; border-bottom-style: solid;">
                    <asp:Label ID="lblPrinter2" runat="server" Text="Ink Jet Printer"></asp:Label>
                </td>
                <td id="row14" class="auto-style66" style="border-width: thin; font-family: Rubik; border-bottom-style: solid;">
                    <asp:Label ID="lblq4" runat="server" Text="0"></asp:Label>
                </td>
                <td id="row15" class="auto-style58" style="border-width: thin; font-family: Rubik; border-bottom-style: solid;"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">&#8369;</span><span class="NA6bn ILfuVd"><b> </b></span></span>
                    <asp:Label ID="lblp4" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style63" style="font-family: Rubik">Total:</td>
                <td class="auto-style18" style="font-family: Rubik"></td>
                <td class="auto-style39" style="font-family: Rubik"><span class="hgKElc"><span class="NA6bn ILfuVd"><span class="NA6bn ILfuVd" lang="en">&#8369;</span>&nbsp;<span class="NA6bn ILfuVd" lang="en"><asp:Label ID="lblp5" runat="server"></asp:Label>
                    </span></span></span></td>
            </tr>
            <tr>
                <td id="row5" class="auto-style64" style="border-width: thin; font-family: Rubik; border-bottom-style: solid;">Discount</td>
                <td id="row17" class="auto-style21" style="border-width: thin; font-family: Rubik; border-bottom-style: solid;">
                    <asp:Label ID="lblDiscount0" runat="server"></asp:Label>
                </td>
                <td id="row18" class="auto-style59" style="border-width: thin; font-family: Rubik; border-bottom-style: solid;"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">&#8369;</span></span> <span class="hgKElc"><span class="NA6bn ILfuVd"><span class="NA6bn ILfuVd" lang="en">
                    <asp:Label ID="lblp6" runat="server"></asp:Label>
                    </span></span></span></td>
            </tr>
            <tr>
                <td class="auto-style64" style="font-family: Rubik">Grand Total:</td>
                <td class="auto-style68" style="font-family: Rubik">&nbsp;</td>
                <td class="auto-style69" style="font-family: Rubik"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">&#8369;</span></span>&nbsp;<span class="hgKElc"><span class="NA6bn ILfuVd"><span class="NA6bn ILfuVd" lang="en"><strong><asp:Label ID="lblp7" runat="server"></asp:Label>
                    </strong>
                    </span></span></span></td>
            </tr>
            <tr>
                <td class="auto-style65">
                    <asp:Button ID="Button1" runat="server" Font-Names="Rubik" OnClick="Button1_Click" Text="New transaction" Width="130px" />
                </td>
                <td class="auto-style67">&nbsp;</td>
                <td class="auto-style61">&nbsp;</td>
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
