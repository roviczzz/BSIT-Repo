<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp.App_Code.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Decimal to Binary</div>
        <p style="color: red;" id="invalid">
            <asp:TextBox ID="invalidBox" runat="server" BorderStyle="None" ForeColor="Red" Visible="False">Invalid input</asp:TextBox>
        </p>
        <asp:TextBox ID="TextBox2" runat="server" Enabled="False" OnTextChanged="TextBox2_TextChanged">Decimal Value</asp:TextBox>
        <asp:TextBox ID="txtDec" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        <asp:Button ID="btnConvert" runat="server" OnClick="Button1_Click" Text="Convert" Height="26px" />
        <p>
            <asp:TextBox ID="TextBox3" runat="server" Enabled="False">Binary Value</asp:TextBox>
            <asp:TextBox ID="txtBin" runat="server" Enabled="False"></asp:TextBox>
            <asp:Button ID="btnClear" runat="server" Text="Clear" Width="62px" OnClick="btnClear_Click" />
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        Passed and submited by:</p>
    <p>
        Rovic M. Rodriguez | BIT21</p>
</body>
</html>
