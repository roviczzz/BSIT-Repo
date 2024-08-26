<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentTuition-1.aspx.cs" Inherits="AppDev_EA1.StudentTuition" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>schoolname | Tuition Form-1</title>
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
                <p class="label">
                    Student ID:</p>
                <p class="label">
    <asp:TextBox ID="txtBox_StudentID" runat="server" Width="188px" OnTextChanged="txtBox_StudentID_TextChanged" style="margin-bottom: 0px"></asp:TextBox>
            <asp:TextBox ID="errorBox_ID" runat="server" BorderStyle="None" Visible="False" ForeColor="#FF3300" Width="312px">Valid characters are 0-9</asp:TextBox>
</p>
<p class="label">
    Student Name:</p>

    <asp:TextBox ID="txtBox_Name" runat="server" Width="184px" OnTextChanged="txtBox_Name_TextChanged"></asp:TextBox>
            <asp:TextBox ID="errorBox_Name" runat="server" BorderStyle="None" Visible="False" ForeColor="#FF3300" Width="358px">Valid characters are A-Z a-z</asp:TextBox>
    <p class="label">
    Course: </p>
<asp:DropDownList ID="courseList" runat="server" Height="29px" Width="194px">
    <asp:ListItem>Select</asp:ListItem>
    <asp:ListItem>BIT</asp:ListItem>
    <asp:ListItem>BCS</asp:ListItem>
    <asp:ListItem>HUB</asp:ListItem>
    <asp:ListItem>MEB</asp:ListItem>
    <asp:ListItem>APM</asp:ListItem>
</asp:DropDownList>
            <asp:TextBox ID="errorBox_Course" runat="server" BorderStyle="None" Visible="False" ForeColor="#FF3300">Invalid Course</asp:TextBox>
                <p class="label">
                    Units Enrolled (maximum of 24 units):</p>
                <div id="courses">
                    <asp:CheckBoxList ID="CheckBoxList1" class="listbox" RepeatLayout="Table" runat="server" Width="722px" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" Height="114px" RepeatColumns="2" CellPadding="5">
    <asp:ListItem Value="Unit 1">Unit1</asp:ListItem>
    <asp:ListItem Value="Unit 2">Unit2</asp:ListItem>
    <asp:ListItem Value="Unit 3">Unit3</asp:ListItem>
    <asp:ListItem Value="Unit 4">Unit4</asp:ListItem>
    <asp:ListItem Value="Unit 5">Unit5</asp:ListItem>
    <asp:ListItem Value="Unit 6">Unit6</asp:ListItem>
    <asp:ListItem Value="Unit 7">Unit7</asp:ListItem>
    <asp:ListItem Value="Unit 8">Unit8</asp:ListItem>
    <asp:ListItem Value="Unit 9">Unit9</asp:ListItem>
    <asp:ListItem Value="Unit 10">Unit10</asp:ListItem>
    <asp:ListItem Value="Unit 11">Unit11</asp:ListItem>
    <asp:ListItem Value="Unit 12">Unit12</asp:ListItem>
    <asp:ListItem Value="Unit 13">Unit13</asp:ListItem>
    <asp:ListItem Value="Unit 14">Unit14</asp:ListItem>
    <asp:ListItem Value="Unit 15">Unit15</asp:ListItem>
    <asp:ListItem Value="Unit 16">Unit16</asp:ListItem>
    <asp:ListItem Value="Unit 17">Unit17</asp:ListItem>
    <asp:ListItem Value="Unit 18">Unit18</asp:ListItem>
    <asp:ListItem Value="Unit 19">Unit19</asp:ListItem>
    <asp:ListItem Value="Unit 20">Unit20</asp:ListItem>
    <asp:ListItem Value="Unit 21">Unit21</asp:ListItem>
    <asp:ListItem Value="Unit 22">Unit22</asp:ListItem>
    <asp:ListItem Value="Unit 23">Unit23</asp:ListItem>
    <asp:ListItem Value="Unit 24">Unit24</asp:ListItem>
    <asp:ListItem Value="Unit 25">Unit25</asp:ListItem>
    <asp:ListItem Value="Unit 26">Unit26</asp:ListItem>
</asp:CheckBoxList>
                    <br />
            <asp:TextBox ID="errorBox_Units" runat="server" BorderStyle="None" Visible="False" ForeColor="#FF3300" Width="438px">Invalid Number of Selected Units</asp:TextBox>
                    </div>


            </div>
            <p class="label">
                Tuition Down Payment</p>
            <asp:DropDownList ID="downpaymentList" runat="server" Height="29px" Width="194px" OnSelectedIndexChanged="downpaymentList_SelectedIndexChanged">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>40%</asp:ListItem>
                <asp:ListItem>50%</asp:ListItem>
                <asp:ListItem>Full-payment</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:TextBox ID="errorBox_Downpay" runat="server" BorderStyle="None" Visible="False" ForeColor="#FF3300" Width="199px">Invalid Down Payment Method</asp:TextBox>
            <br />
            <p>
                <asp:Button ID="btnConfirm" Cssclass="button-confirm" runat="server" Height="34px" Text="Confirm" Width="91px" BackColor="#79C982" ForeColor="White" OnClick="Button1_Click" />
                <asp:Button ID="btnReset" runat="server" Height="34px" style="margin-left: 14px" Text="Reset" Width="75px" OnClick="Button2_Click" />
            </p>
        </form>

    <header>Passed and submitted by: Rovic M. Rodriguez | BIT21</header>
        
    </body>
</html>
