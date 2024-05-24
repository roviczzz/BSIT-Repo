<%@ Page Title="" Language="C#" MasterPageFile="~/Initial.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LongQuiz_RodriguezBIT21.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Panel ID="Panel1" runat="server">
        <br />
        <br />
    <asp:Panel ID="Panel3" runat="server" Font-Names="Rubik" CssClass="auto-style1">
        <h1 style="color: #09814a;">LOGIN</h1>
        <p style="font-weight: bold; color: #09814a;">
            Welcome!
        </p>
        <div class="flex flex-grow flex-col max-w-full">
            <div class="min-h-[20px] text-message flex flex-col items-start whitespace-pre-wrap break-words [.text-message+&amp;]:mt-5 juice:w-full juice:items-end overflow-x-auto gap-2" data-message-author-role="assistant" data-message-id="a63fbd12-3336-4fad-b0ee-5cfcf11173ce" dir="auto">
                <div class="flex w-full flex-col gap-1 juice:empty:hidden juice:first:pt-[3px]">
                    <div class="markdown prose w-full break-words dark:prose-invert dark">
                        <p>
                            Clicking the Log-In button will take you to the log-in page.</p>
                    </div>
                </div>
            </div>
        </div>
        <p>
            &nbsp;<table class="auto-style8">
                <tr>
                    <td class="auto-style4" style="width: 93px; color: #09814a; text-align: right;"><strong>E-mail:
                        </strong></td>
                    <td class="auto-style5" style="width: 319px"><strong>
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                        <span class="auto-style2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtUserName" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </span></strong></td>
                </tr>
                <tr>
                    <td class="auto-style9" style="width: 93px; color: #09814a; height: 15px; text-align: right;"><strong>Password:
                        </strong></td>
                    <td class="auto-style7" style="width: 319px; height: 15px;"><strong>
                        <asp:TextBox ID="txtUserPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <span class="auto-style2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtUserPassword" Display="Dynamic" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                        </span></strong></td>
                </tr>
                <tr>
                    <td class="auto-style9" style="width: 93px">&nbsp;</td>
                    <td class="auto-style7" style="width: 319px"><strong><span class="auto-style2">
                        <asp:Label ID="lblIncorrect0" runat="server" ForeColor="Red" Text="Incorrect Password!" Visible="False"></asp:Label>
                        </span></strong></td>
                </tr>
                <tr>
                    <td class="auto-style9" style="width: 93px">&nbsp;</td>
                    <td class="auto-style7" style="width: 319px">
                        <asp:Button ID="btnLogIn" runat="server" BackColor="#09814a" BorderStyle="None" CssClass="btn" Font-Bold="True" ForeColor="White" Height="41px" OnClick="Button1_Click" Text="Log-In" Width="184px" />
                    </td>
                </tr>
            </table>
        </p>
        <p>
            &nbsp;</p>
    </asp:Panel>
    <br />
</asp:Panel>

</asp:Content>
