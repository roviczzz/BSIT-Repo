<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="myLogin.aspx.cs" Inherits="FinalAct1_RodriguezBIT21.myLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 111px;
        }
        .auto-style3 {
            width: 111px;
            height: 54px;
        }
        .auto-style4 {
            height: 54px;
        }
    </style>
</head>
<body style="font-family: 'Segoe UI'">
    <form id="form1" runat="server">
        <div>
            Login Page</div>
        <br />
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">User name</td>
                    <td>
                        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Password</td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">
                        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="78px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
