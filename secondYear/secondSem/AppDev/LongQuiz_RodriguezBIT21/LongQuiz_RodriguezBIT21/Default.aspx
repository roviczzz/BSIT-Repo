<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LongQuiz_RodriguezBIT21.WebForm1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel3" runat="server" Font-Names="Rubik" style="margin-left: 275px">
        <h1 style="color: #09814a;">LOGIN</h1>
        <div class="flex flex-grow flex-col max-w-full">
            <div class="min-h-[20px] text-message flex flex-col items-start whitespace-pre-wrap break-words [.text-message+&amp;]:mt-5 juice:w-full juice:items-end overflow-x-auto gap-2" data-message-author-role="assistant" data-message-id="68cae09f-9a35-4900-908a-d2cd110edc9d" dir="auto">
                <div class="flex w-full flex-col gap-1 juice:empty:hidden juice:first:pt-[3px]">
                    <div class="markdown prose w-full break-words dark:prose-invert dark">
                        <p>
                            You can update your Phone Number, Address, and Password on this page.</p>
                    </div>
                </div>
            </div>
        </div>
        <table class="auto-style9">
            <tr>
                <td class="auto-style10" style="width: 400px"><strong style="color: #09814a">E-mail Address:
                    <br />
                    </strong><span style="color: #09814a">
                    <asp:Label ID="lblEmail" runat="server" ForeColor="Black"></asp:Label>
                    </span><strong style="color: #09814a"><span class="auto-style2">
                    <br />
                    <table class="auto-style11">
                        <tr>
                            <td class="auto-style13" style="width: 140px"><span class="auto-style2">
                                <asp:Label ID="Label1" runat="server" Text="Last Name:"></asp:Label>
                                </span></td>
                            <td class="auto-style15" style="width: 140px"><span class="auto-style2">
                                <asp:Label ID="Label2" runat="server" Text="First Name:"></asp:Label>
                                </span></td>
                            <td class="auto-style15" style="width: 122px"><span class="auto-style2">
                                <asp:Label ID="Label3" runat="server" Text="M.I.:"></asp:Label>
                                </span></td>
                        </tr>
                        <tr>
                            <td class="auto-style14" style="width: 140px">
                                <asp:Label ID="lblLastName" runat="server" ForeColor="Black"></asp:Label>
                            </td>
                            <td class="auto-style16" style="width: 140px">
                                <asp:Label ID="lblFirstName" runat="server" ForeColor="Black"></asp:Label>
                            </td>
                            <td class="auto-style16" style="width: 122px">
                                <asp:Label ID="lblMiddleInitial" runat="server" ForeColor="Black"></asp:Label>
                            </td>
                        </tr>
                    </table>
                    Phone No.:<br />
                    <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="mr-0" ForeColor="Black" Width="297px"></asp:TextBox>
                    <br />
                    Address:<br />
                    <asp:TextBox ID="txtAddress" runat="server" CssClass="mr-0" ForeColor="Black" Width="297px"></asp:TextBox>
                    <table class="auto-style11">
                        <tr>
                            <td class="auto-style13" style="width: 140px"><span class="auto-style2">
                                <asp:Label ID="Label4" runat="server" Text="Birthday:"></asp:Label>
                                </span></td>
                            <td class="auto-style15" style="width: 140px"><span class="auto-style2">
                                <asp:Label ID="Label5" runat="server" Text="Gender:"></asp:Label>
                                </span></td>
                        </tr>
                        <tr>
                            <td class="auto-style14" style="width: 140px"><span class="auto-style2">
                                <asp:Label ID="lblBirthday" runat="server" ForeColor="Black"></asp:Label>
                                </span></td>
                            <td class="auto-style16" style="width: 140px"><span class="auto-style2">
                                <asp:Label ID="lblGender" runat="server" ForeColor="Black"></asp:Label>
                                </span></td>
                        </tr>
                    </table>
                    </span></strong></td>
                <td class="auto-style10"><span class="auto-style2" style="color: #09814a"><strong>
                    <br />
                    <br />
                    Current Phone Number:<br />
                    <asp:Label ID="lblPhoneNumber" runat="server" ForeColor="Black"></asp:Label>
                    <br />
                    Current Address:<br /> 
                    <asp:Label ID="lblAddress" runat="server" ForeColor="Black"></asp:Label>
                    </strong>
                    </span></td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td class="auto-style8" style="width: 400px; height: 45px;">
                    <asp:Panel ID="Panel2" runat="server">
                        <span class="auto-style2" style="color: #09814a; font-weight: bolder">Password:<br /> <strong>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ForeColor="Black" Width="297px"></asp:TextBox>
                        </strong></span>
                    </asp:Panel>
                </td>
                <td class="auto-style8" style="height: 45px"><strong style="color: #09814a">Current Password:<br /> <span class="auto-style2"><strong><span class="auto-style2" style="color: #000080">
                    <asp:Label ID="lblPassword" runat="server" ForeColor="Black"></asp:Label>
                    </span></strong></span></strong></td>
                <td class="auto-style6" style="height: 45px"></td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button1" runat="server" BackColor="#09814a" BorderStyle="None" ForeColor="White" Height="41px" OnClick="Button1_Click" Text="Update Information" Width="216px" />
        &nbsp;<br />
    </asp:Panel>
</asp:Content>
