<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="FinalAct1_RodriguezBIT21.UserPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 184px;
        }
    </style>
</head>
<body style="font-family: 'Segoe UI'">
    <form id="form1" runat="server">
        <div>
            User Page
        </div>
        <br />
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Customer Name</td>
                    <td><strong>
                        <asp:Label ID="lblCustomername" runat="server"></asp:Label>
                        </strong></td>
                </tr>
                <tr>
                    <td class="auto-style2">Membership type</td>
                    <td><strong>
                        <asp:Label ID="lblMemtype" runat="server"></asp:Label>
                        </strong></td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
