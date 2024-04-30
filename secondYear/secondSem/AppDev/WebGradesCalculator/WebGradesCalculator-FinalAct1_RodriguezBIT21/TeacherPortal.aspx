<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherPortal.aspx.cs" Inherits="WebGradesCalculator_FinalAct1_RodriguezBIT21.TeacherPortal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 305px;
            height: 173px;
        }
        .auto-style4 {
            height: 173px;
        }
        .auto-style5 {
            width: 178px;
            height: 35px;
        }
        .auto-style6 {
            width: 178px;
            text-align: right;
        }
        .auto-style7 {
            text-align: left;
        }
        .auto-style8 {
            height: 31px;
        }
        .auto-style9 {
            height: 35px;
        }
        .auto-style14 {
            width: 305px;
            height: 264px;
        }
        .auto-style15 {
            height: 264px;
        }
        .auto-style16 {
            margin-bottom: 128px;
        }
        .auto-style26 {
            width: 178px;
            text-align: right;
            height: 29px;
        }
        .auto-style27 {
            height: 29px;
        }
        .auto-style29 {
            width: 147px;
            text-align: left;
            height: 29px;
        }
        .auto-style33 {
            width: 159px;
        }
        .auto-style34 {
            width: 159px;
            text-align: left;
            height: 29px;
        }
        .auto-style36 {
            width: 186px;
        }
        .auto-style37 {
            width: 186px;
            text-align: left;
            height: 29px;
        }
        .auto-style38 {
            width: 159px;
            height: 29px;
        }
        .auto-style39 {
            width: 147px;
            height: 29px;
        }
        .auto-style40 {
            width: 186px;
            height: 29px;
        }
        .auto-style41 {
            width: 159px;
            height: 30px;
        }
        .auto-style43 {
            width: 186px;
            height: 30px;
        }
        .auto-style44 {
            height: 30px;
        }
        .auto-style45 {
            width: 147px;
        }
        .auto-style46 {
            width: 147px;
            height: 30px;
        }
        .auto-style47 {
            width: 300px;
        }
        .auto-style48 {
            height: 29px;
            width: 300px;
        }
        .auto-style49 {
            height: 30px;
            width: 300px;
        }
        .auto-style50 {
            width: 147px;
            height: 30px;
            margin-left: 40px;
        }
    </style>
</head>
<body style="font-family: 'Segoe UI'; font-size: large;">
    <form id="form1" runat="server">
        <div>
            <strong>Teacher Portal</strong></div>


    <div>
    </div>



        <table class="auto-style1">
            <tr>
                <td class="auto-style8" colspan="2">Student List</td>
                <td class="auto-style8"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#242121" />
                    </asp:GridView>
                </td>
                <td class="auto-style4">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style7" colspan="2">Select<strong> </strong>Student</td>
                        </tr>
                        <tr>
                            <td class="auto-style6">StudentID</td>
                            <td>
                                <asp:TextBox ID="txtStudentID" runat="server" Width="147px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style26"></td>
                            <td class="auto-style27">
                                <asp:Label ID="txtError" runat="server" CssClass="auto-style6" Font-Size="Small" ForeColor="#FF3300" Text="*Student does not exist" Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style5"></td>
                            <td class="auto-style9">
                                <asp:Button ID="btnSel" runat="server" OnClick="btnSel_Click" Text="Select" Width="97px" />
&nbsp;<asp:Button ID="btnLogout" runat="server" OnClick="btnClear_Click" Text="Logout" Width="97px" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style14"></td>
                <td class="auto-style15">
                    <asp:Panel ID="pnlGrade" runat="server" CssClass="auto-style16" Height="355px" Visible="False">
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style33"><strong>Student Name</strong></td>
                                <td class="auto-style45">
                                    <asp:Label ID="lblStudentName" runat="server"></asp:Label>
                                </td>
                                <td class="auto-style36">&nbsp;</td>
                                <td class="auto-style47">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style38"><strong>StudentID</strong></td>
                                <td class="auto-style39">
                                    <asp:Label ID="lblStudentID" runat="server"></asp:Label>
                                </td>
                                <td class="auto-style40"></td>
                                <td class="auto-style48"></td>
                                <td class="auto-style27"></td>
                            </tr>
                            <tr>
                                <td class="auto-style38"></td>
                                <td class="auto-style39"></td>
                                <td class="auto-style40"></td>
                                <td class="auto-style48"></td>
                                <td class="auto-style27"></td>
                            </tr>
                            <tr>
                                <td class="auto-style38">Prelims</td>
                                <td class="auto-style39">
                                    <asp:TextBox ID="txtPrelim" runat="server" Width="125px" required="required"></asp:TextBox>
                                </td>
                                <td class="auto-style40"></td>
                                <td class="auto-style48"></td>
                                <td class="auto-style27"></td>
                            </tr>
                            <tr>
                                <td class="auto-style34">Midterm</td>
                                <td class="auto-style29">
                                    <asp:TextBox ID="txtMidterm" runat="server" Width="125px" required="required" ></asp:TextBox>
                                </td>
                                <td class="auto-style37">
                                    &nbsp;</td>
                                <td class="auto-style48">&nbsp;</td>
                                <td class="auto-style27"></td>
                            </tr>
                            <tr>
                                <td class="auto-style33">Finals</td>
                                <td class="auto-style45">
                                    <asp:TextBox ID="txtFinals" runat="server" Width="125px" required="required" ></asp:TextBox>
                                </td>
                                <td class="auto-style36">
                                    &nbsp;</td>
                                <td class="auto-style47">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style41">Overall Final Grade:</td>
                                <td class="auto-style46">
                                    <asp:TextBox ID="txtOverall" runat="server" Enabled="False" OnTextChanged="txtOverall_TextChanged" Width="125px"></asp:TextBox>
                                </td>
                                <td class="auto-style43"></td>
                                <td class="auto-style49"></td>
                                <td class="auto-style44"></td>
                            </tr>
                            <tr>
                                <td class="auto-style41">&nbsp;</td>
                                <td class="auto-style50">
                                    <asp:Button ID="btnCompute0" runat="server" OnClick="btnCompute0_Click" Text="Compute" Width="66px" />
                                    &nbsp;<asp:Button ID="btnClose" runat="server" OnClick="btnSubmit0_Click" Text="Close" Width="74px" />
                                </td>
                                <td class="auto-style43">&nbsp;
                                    </td>
                                <td class="auto-style49">&nbsp;</td>
                                <td class="auto-style44">&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td class="auto-style15"></td>
            </tr>
        </table>
    </form>


    
</body>
</html>
