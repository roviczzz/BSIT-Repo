<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transaction-Page.aspx.cs" Inherits="OOPWebApp_Rodriguez.Transaction_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 667px;
            height: 203px;
        }
        .auto-style3 {
            width: 113px;
            text-align: right;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 113px;
            text-align: right;
        }
        .auto-style6 {
            margin-bottom: 0px;
        }
        .auto-style7 {
            width: 100%;
            height: 96px;
        }
        .auto-style18 {
            height: 43px;
            width: 386px;
            text-align: center;
        }
        .auto-style21 {
            width: 386px;
            height: 44px;
            text-align: left;
        }
        .auto-style25 {
            height: 39px;
            text-align: center;
            width: 821px;
        }
        .auto-style29 {
            height: 43px;
            text-align: center;
            width: 821px;
        }
        .auto-style31 {
            width: 821px;
            height: 44px;
        }
        .auto-style39 {
            width: 316px;
            height: 43px;
        }
        .auto-style47 {
            width: 386px;
            height: 42px;
            text-align: left;
        }
        .auto-style50 {
            width: 386px;
            height: 46px;
            text-align: center;
        }
        .auto-style51 {
            width: 316px;
            height: 46px;
        }
        .auto-style52 {
            width: 376px;
            height: 46px;
            text-align: left;
        }
        .auto-style53 {
            width: 821px;
            height: 46px;
        }
        .auto-style54 {
            margin-right: 0px;
        }
        .auto-style55 {
            width: 821px;
            height: 43px;
        }
        .auto-style56 {
            width: 821px;
            height: 42px;
        }
        .auto-style57 {
            height: 43px;
            width: 316px;
            text-align: center;
        }
        .auto-style58 {
            width: 316px;
            text-align: left;
            height: 43px;
        }
        .auto-style59 {
            width: 316px;
            height: 44px;
            text-align: left;
        }
        .auto-style60 {
            width: 316px;
            height: 42px;
            text-align: left;
        }
        .auto-style61 {
            width: 316px;
            height: 42px;
        }
        .auto-style62 {
            height: 43px;
            width: 376px;
            text-align: center;
        }
        .auto-style63 {
            width: 376px;
            text-align: left;
            height: 43px;
        }
        .auto-style64 {
            width: 376px;
            height: 44px;
            text-align: left;
        }
        .auto-style65 {
            width: 376px;
            height: 42px;
            text-align: left;
        }
        .auto-style66 {
            width: 386px;
            text-align: left;
            height: 43px;
        }
        .auto-style67 {
            width: 386px;
            height: 42px;
            text-align: center;
        }
        .auto-style68 {
            width: 386px;
            height: 44px;
            text-align: center;
        }
        .auto-style69 {
            width: 316px;
            height: 44px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="UserInfo" runat="server" CssClass="auto-style6" GroupingText="User Information" Height="140px">
                <table class="auto-style7">
                    <tr>
                        <td class="auto-style3" style="font-family: Rubik">Name:</td>
                        <td class="auto-style4" style="font-family: Rubik">
                            <strong>
                            <asp:Label ID="lblName" runat="server"></asp:Label>
                            </strong>
                        </td>
                        <td class="auto-style4"></td>
                    </tr>
                    <tr>
                        <td class="auto-style5" style="font-family: Rubik">Member ID:</td>
                        <td style="font-family: Rubik">
                            <strong>
                            <asp:Label ID="lblID" runat="server"></asp:Label>
                            </strong>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style5" style="font-family: Rubik">Member Type:</td>
                        <td style="font-family: Rubik">
                            <strong>
                            <asp:Label ID="lblMemberType" runat="server"></asp:Label>
                            </strong>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
        <p>
            &nbsp;</p>
        <asp:Panel ID="Transaction" runat="server" GroupingText="CART" Height="425px" CssClass="auto-style54">
            <table class="auto-style1" style="font-family: Arial, Helvetica, sans-serif; table-layout: fixed; border-collapse: collapse; border-spacing: inherit; border-style: solid; border-width: thin">
                <tr>
                    <td class="auto-style62" style="font-family: Rubik; background-color: #000000; color: #FFFFFF;"><strong>Product</strong></td>
                    <td class="auto-style18" style="font-family: Rubik; background-color: #000000; color: #FFFFFF;"><strong>Quantity</strong></td>
                    <td class="auto-style57" style="font-family: Rubik; background-color: #000000; color: #FFFFFF;"><strong>Price</strong></td>
                    <td class="auto-style29" style="font-family: Rubik"></td>
                </tr>
                <tr>
                    <td id="row1" class="auto-style63" style="font-family: Rubik;">
                        <asp:Label ID="lblLaptop" runat="server" Text="Laptop"></asp:Label>
                    </td>
                    <td id="row1" class="auto-style66" style="font-family: Rubik;">
                        <asp:Label ID="lblq1" runat="server" Text="0"></asp:Label>
                    </td>
                    <td id="row1" class="auto-style58" style="font-family: Rubik;"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">₱</span></span>&nbsp;<asp:Label ID="lblp1" runat="server"></asp:Label>
                    </td>
                    <td id="rowLaptop" class="auto-style29" style="font-family: Rubik"></td>
                </tr>
                <tr>
                    <td id="row2" class="auto-style63" style="font-family: Rubik;">
                        <asp:Label ID="lblDesktop" runat="server" Text="Desktop"></asp:Label>
                    </td>
                    <td id="row2" class="auto-style66" style="font-family: Rubik;">
                        <asp:Label ID="lblq2" runat="server" Text="0"></asp:Label>
                    </td>
                    <td id="row2" class="auto-style39" style="font-family: Rubik;"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">₱</span></span>&nbsp;<asp:Label ID="lblp2" runat="server"></asp:Label>
                    </td>
                    <td id="row2" class="auto-style55" style="font-family: Rubik"></td>
                </tr>
                <tr>
                    <td id="row3" class="auto-style63" style="font-family: Rubik;">
                        <asp:Label ID="lblPrinter1" runat="server" Text="Dot Matrix Printer"></asp:Label>
                    </td>
                    <td id="row3" class="auto-style66" style="font-family: Rubik;">
                        <asp:Label ID="lblq3" runat="server" Text="0"></asp:Label>
                    </td>
                    <td id="row3" class="auto-style58" style="font-family: Rubik;"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">₱</span></span>&nbsp;<asp:Label ID="lblp3" runat="server"></asp:Label>
                    </td>
                    <td id="row3" class="auto-style55" style="font-family: Rubik;"></td>
                </tr>
                <tr>
                    <td id="row4" class="auto-style63" style="border-width: thin; font-family: Rubik; border-bottom-style: solid;">
                        <asp:Label ID="lblPrinter2" runat="server" Text="Ink Jet Printer"></asp:Label>
                    </td>
                    <td id="row4" class="auto-style66" style="border-width: thin; font-family: Rubik; border-bottom-style: solid;">
                        <asp:Label ID="lblq4" runat="server" Text="0"></asp:Label>
                    </td>
                    <td id="row4" class="auto-style58" style="border-width: thin; font-family: Rubik; border-bottom-style: solid;"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">₱</span><span class="NA6bn ILfuVd"><b> </b></span></span><asp:Label ID="lblp4" runat="server"></asp:Label>
                    </td>
                    <td id="row4" class="auto-style55" style="font-family: Rubik">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style63" style="font-family: Rubik">Total:</td>
                    <td class="auto-style18" style="font-family: Rubik"></td>
                    <td class="auto-style39" style="font-family: Rubik"><span class="hgKElc"><span class="NA6bn ILfuVd"><span class="NA6bn ILfuVd" lang="en">₱</span>&nbsp;<span class="NA6bn ILfuVd" lang="en"><asp:Label ID="lblp5" runat="server"></asp:Label>
                        </span></span></span></td>
                    <td class="auto-style55" style="font-family: Rubik"></td>
                </tr>
                <tr>
                    <td id="row5" class="auto-style64" style="border-width: thin; font-family: Rubik; border-bottom-style: solid;">Discount</td>
                    <td id="row5" class="auto-style21" style="border-width: thin; font-family: Rubik; border-bottom-style: solid;">
                        <asp:Label ID="lblDiscount0" runat="server"></asp:Label>
                    </td>
                    <td id="row5" class="auto-style59" style="border-width: thin; font-family: Rubik; border-bottom-style: solid;"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">₱</span></span> <span class="hgKElc"><span class="NA6bn ILfuVd">
                        <span class="NA6bn ILfuVd" lang="en">
                        <asp:Label ID="lblp6" runat="server"></asp:Label>
                        </span>
                        </span></span></td>
                    <td class="auto-style31" style="font-family: Rubik"></td>
                </tr>
                <tr>
                    <td class="auto-style64" style="font-family: Rubik">Grand Total:</td>
                    <td class="auto-style68" style="font-family: Rubik">&nbsp;</td>
                    <td class="auto-style69" style="font-family: Rubik"><span class="hgKElc"><span class="NA6bn ILfuVd" lang="en">₱</span></span>&nbsp;<span class="hgKElc"><span class="NA6bn ILfuVd"><span class="NA6bn ILfuVd" lang="en"><asp:Label ID="lblp7" runat="server"></asp:Label>
                        </span></span></span></td>
                    <td class="auto-style31" style="font-family: Rubik">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style65">
                        <asp:Button ID="Button1" runat="server" Text="New transaction" Width="130px" OnClick="Button1_Click" Font-Names="Rubik" />
                    </td>
                    <td class="auto-style67">&nbsp;</td>
                    <td class="auto-style61">&nbsp;</td>
                    <td class="auto-style56">&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    </form>
</body>
</html>
