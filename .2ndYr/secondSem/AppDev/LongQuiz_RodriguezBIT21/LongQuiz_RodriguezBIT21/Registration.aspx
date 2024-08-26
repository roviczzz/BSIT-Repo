<%@ Page Title="" Language="C#" MasterPageFile="~/Initial.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="LongQuiz_RodriguezBIT21.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel3" runat="server" Font-Names="Rubik" CssClass="auto-style1">
    <h1 style="font-weight: bolder; color: #09814a; font-family: Rubik">REGISTRATION</h1>
    <p style="font-family: Rubik">
        Kindly complete the necessary fields.</p>
    <table class="auto-style9" style="color: #09814a">
        <tr>
            <td class="auto-style10">E-mail Address:
                <br />
                <span class="auto-style2">
                <asp:TextBox ID="txtUserName" runat="server" CssClass="mr-0" Width="297px"></asp:TextBox>
                </span>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                <span class="auto-style2">
                <asp:Label ID="lblUserError" runat="server" ForeColor="Red" Text="Account already exists!" Visible="False"></asp:Label>
                <br />
                <table class="auto-style11">
                    <tr>
                        <td class="auto-style13">Last Name:</td>
                        <td class="auto-style15"><span class="auto-style2">First Name:</span></td>
                        <td class="auto-style15">M.I:</td>
                    </tr>
                    <tr>
                        <td class="auto-style14"><span class="auto-style2">
                            <asp:TextBox ID="txtLastName" runat="server" CssClass="mr-0" style="margin-left: 0px" Width="145px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            </span></td>
                        <td class="auto-style16"><span class="auto-style2">
                            <asp:TextBox ID="txtFirstName" runat="server" CssClass="no-gutters" Width="133px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            </span></td>
                        <td class="auto-style16"><span class="auto-style2">
                            <asp:TextBox ID="txtMiddleInitial" runat="server" CssClass="mr-0" Width="49px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtMiddleInitial" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            </span></td>
                        <td style="width: 10px"></td>
                    </tr>
                </table>
                <table style="width: 60%">
                    <tr>
                        <td style="width: 238px; height: 27px"><span class="auto-style2">Phone No.:</span></td>
                        <td style="height: 27px; width: 298px"><span class="auto-style2">Address:</span></td>
                        <td style="width: 125px; height: 27px"></td>
                    </tr>
                    <tr>
                        <td style="width: 238px"><span class="auto-style2">
                            <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="mr-0" style="margin-left: 0px" Width="140px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtPhoneNumber" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            </span></td>
                        <td style="width: 298px"><span class="auto-style2">
                            <asp:TextBox ID="txtAddress" runat="server" CssClass="mr-0" Width="158px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtAddress" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            </span></td>
                        <td style="width: 125px">&nbsp;</td>
                    </tr>
                </table>
                <table class="auto-style11">
                    <tr>
                        <td class="auto-style13"><span class="auto-style2">
                            <asp:Label ID="Label4" runat="server" Text="Birthday:"></asp:Label>
                            </span></td>
                        <td class="auto-style15"><span class="auto-style2">
                            <asp:Label ID="Label5" runat="server" Text="Gender:"></asp:Label>
                            </span></td>
                        <td class="auto-style15" style="width: 253px"></td>
                    </tr>
                    <tr>
                        <td class="auto-style14"><span class="auto-style2">
                            <asp:TextBox ID="txtBirthday" runat="server" CssClass="mr-0" TextMode="Date" Width="145px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtLastName" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            </span></td>
                        <td class="auto-style16"><span class="auto-style2">
                            <asp:TextBox ID="txtGender" runat="server" CssClass="no-gutters" Width="133px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtFirstName" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                            </span></td>
                        <td class="auto-style16" style="width: 253px">
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtBirthday" ErrorMessage="less than 18 years old" ForeColor="Red" MaximumValue="01/01/2006" MinimumValue="01/01/1900" Type="Date"></asp:RangeValidator>
                        </td>
                    </tr>
                </table>
                </span></td>
        </tr>
    </table>
        </span></td>
        <td class="auto-style5" style="width: 10px"></td>
        </tr>
        <tr>
            <td class="auto-style3"><span class="auto-style2" style="color: #09814a; font-weight: bold;">Type:<asp:RadioButtonList ID="radioUserType" runat="server" CellPadding="5" CellSpacing="1" Font-Bold="False" Height="36px" RepeatDirection="Horizontal" Width="189px">
                <asp:ListItem>User</asp:ListItem>
                <asp:ListItem>Admin</asp:ListItem>
                </asp:RadioButtonList>
                <asp:Button ID="Button1" runat="server" BackColor="#09814a" BorderStyle="None" CssClass="auto-style7" ForeColor="White" Height="32px" OnClick="Button1_Click" Text="Set Account Type" Width="150px" />
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="radioUserType" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </span></td>
            <td class="auto-style6" style="width: 10px"></td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Panel ID="Panel2" runat="server" Visible="False">
                    <span class="auto-style2" style="color: #09814a">Password:<br />
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="150px"></asp:TextBox>
                    <span class="auto-style2" style="color: #000080; font-weight: bold;">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </span></span>
                </asp:Panel>
            </td>
            <td class="auto-style6" style="width: 10px"></td>
        </tr>
        </table>
    <span class="auto-style2">
        <asp:Label ID="lblSuccess" runat="server" Font-Bold="True" ForeColor="#006600" Text="Registered Successfully!" Visible="False"></asp:Label>
        <br />
        <br />
&nbsp;<asp:Button ID="btnClear" runat="server" BackColor="#CC0000" BorderStyle="None" CausesValidation="False" CssClass="auto-style7" ForeColor="White" Height="46px" OnClick="Button3_Click" Text="Reset" Width="150px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnRegister" runat="server" BackColor="#09814a" BorderStyle="None" CssClass="auto-style7" ForeColor="White" Height="46px" OnClick="Button2_Click" Text="Register" Visible="False" Width="150px" />
        <br />
    </span>
</asp:Panel>
</asp:Content>
