<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentPortal.aspx.cs" Inherits="WebGradesCalculator_FinalAct1_RodriguezBIT21.StudentPortal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 110px;
            text-align: right;
        }
    </style>
</head>
<body style="font-family: 'Segoe UI';">
    <form id="form1" runat="server">
        <div style="font-family: 'Segoe UI'">
            <strong>Student Portal<br />
            </strong>
        </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3"><strong>StudentID</strong></td>
                <td>
                                    <asp:Label ID="lblStudentName" runat="server"></asp:Label>
                                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Student Name</strong></td>
                <td>
                                    <asp:Label ID="lblStudentID" runat="server"></asp:Label>
                                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>GRADES</strong></td>
                <td>
                                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Prelim</td>
                <td>
                                    <asp:Label ID="lblPrelim" runat="server"></asp:Label>
                                </td>
            </tr>
            <tr>
                <td class="auto-style3">Midterm</td>
                <td>
                                    <asp:Label ID="lblMidterm" runat="server"></asp:Label>
                                </td>
            </tr>
            <tr>
                <td class="auto-style3">Finals</td>
                <td>
                                    <asp:Label ID="lblFinals" runat="server"></asp:Label>
                                </td>
            </tr>
            <tr>
                <td class="auto-style3">Overall Grade</td>
                <td>
                                    <strong>
                                    <asp:Label ID="lblOverall" runat="server"></asp:Label>
                                    </strong>
                                </td>
            </tr>
            <tr>
                <td class="auto-style3">Remark</td>
                <td>
                                    <asp:Label ID="lblRemark" runat="server"></asp:Label>
                                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>
                                    <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="Logout" />
                                </td>
            </tr>
        </table>
    </form>
</body>
</html>
