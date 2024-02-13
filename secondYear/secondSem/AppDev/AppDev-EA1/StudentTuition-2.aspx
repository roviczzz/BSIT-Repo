<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentTuition-2.aspx.cs" Inherits="AppDev_EA1.StudentTuition_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>schoolname | Tuition Form-2</title>
<meta name="viewport" content="width=device-width, initial-scale=1.0" />
<meta charset="utf-8" />
<link rel="stylesheet" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
            <header>schoolname</header>
        <div class="Section">
        &nbsp;TUITION FORM
            </div>
        <div>
        </div>
        <p class="label">
    Student ID:</p>
            <p class="label">
    <asp:TextBox ID="txtBox1" runat="server" Width="188px" OnTextChanged="txtBox_StudentID_TextChanged" style="margin-bottom: 0px" BorderStyle="None" Enabled="False" Height="27px"></asp:TextBox>
            </p>
        <p class="label">
    Student Name:</p>
            <p class="label">
    <asp:TextBox ID="txtBox2" runat="server" Width="188px" OnTextChanged="txtBox_StudentID_TextChanged" style="margin-bottom: 0px" BorderStyle="None" Enabled="False" Height="27px"></asp:TextBox>
            </p>
        <p class="label">
    Course:</p>
            <p class="label">
    <asp:TextBox ID="txtBox3" runat="server" Width="188px" OnTextChanged="txtBox_StudentID_TextChanged" style="margin-bottom: 0px" BorderStyle="None" Enabled="False" Height="27px"></asp:TextBox>
            </p>
        <p class="label">
    Tuition Fee:</p>
            <p class="label">
    <asp:TextBox ID="txtBox4" runat="server" Width="188px" OnTextChanged="txtBox_StudentID_TextChanged" style="margin-bottom: 0px" BorderStyle="None" Enabled="False" Height="27px"></asp:TextBox>
            </p>
        <p class="label">
    Tuition Down Payment:</p>
            <p class="label">
    <asp:TextBox ID="txtBox5" runat="server" Width="188px" OnTextChanged="txtBox_StudentID_TextChanged" style="margin-bottom: 0px" BorderStyle="None" Enabled="False" Height="27px"></asp:TextBox>
            </p>
        <p class="label">
    Total Balance:</p>
            <p class="label">
    <asp:TextBox ID="txtBox6" runat="server" Width="188px" OnTextChanged="txtBox_StudentID_TextChanged" style="margin-bottom: 0px" BorderStyle="None" Enabled="False" Height="27px"></asp:TextBox>
            </p>
            <p class="label">
                <asp:Button ID="btnConfirm" Cssclass="button-confirm" runat="server" Height="34px" Text="Retry" Width="91px" BackColor="#79C982" ForeColor="White" OnClick="Button1_Click" />
                </p>
    </form>
    <header>Passed and submitted by: Rovic M. Rodriguez | BIT21</header>
        </body>
</html>
