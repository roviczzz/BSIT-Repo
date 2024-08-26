<%@ Page Title="" Language="C#" MasterPageFile="~/userMaster.Master" AutoEventWireup="true" CodeBehind="userSetting.aspx.cs" Inherits="WebAppDemo_RodriguezPellosisMagno.userSetting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 34px;
        }
        .auto-style3 {
            height: 430px;
            width: 870px;
        }
        .auto-style5 {
            width: 495px;
            height: 34px;
        }
        .auto-style7 {
            width: 492px;
            height: 24px;
        }
        .auto-style9 {
            width: 488px;
        }
        .auto-style11 {
            width: 374px;
            height: 44px;
        }
        .auto-style12 {
            width: 766px;
        }
        .auto-style15 {
            width: 374px;
            text-align: right;
            height: 34px;
        }
        .auto-style16 {
            height: 35px;
            width: 374px;
            text-align: right;
        }
        .auto-style17 {
            width: 488px;
            height: 24px;
        }
    .auto-style18 {
        height: 59px;
        width: 374px;
    }
    .auto-style19 {
        width: 488px;
        height: 59px;
    }
    .auto-style21 {
        width: 495px;
        height: 35px;
    }
    .auto-style23 {
        width: 488px;
        height: 35px;
    }
        .auto-style25 {
            height: 35px;
            width: 12px;
            text-align: right;
        }
        .auto-style27 {
            width: 12px;
            text-align: right;
            height: 34px;
        }
        .auto-style28 {
            height: 59px;
            width: 12px;
        }
        .auto-style29 {
            width: 12px;
            height: 44px;
        }
        .auto-style30 {
            height: 24px;
            width: 374px;
        }
        .auto-style31 {
            height: 24px;
            width: 12px;
        }
        .auto-style35 {
            width: 374px;
            height: 42px;
        }
        .auto-style36 {
            width: 12px;
            height: 42px;
        }
        .auto-style37 {
            width: 488px;
            height: 42px;
        }
        .auto-style38 {
            height: 24px;
        }
        .auto-style39 {
            height: 44px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style1">
        <h1 class="auto-style12">Welcome!
            <asp:Label ID="lblUserName" runat="server"></asp:Label>
        </h1>
        <table class="auto-style3">
            <tr>
                <td class="auto-style30">
                    <h3>Profile Manager</h3>
                </td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <p>
                        Email:</p>
                </td>
                <td class="auto-style27">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="lblEmail" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">Name:</td>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style21">
                    <asp:Label ID="lblName" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">Membership:</td>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style23">
                    <asp:Label ID="lblMembership" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">Phone No.</td>
                <td class="auto-style25">&nbsp;</td>
                <td class="auto-style23">
                    <asp:Label ID="lblPhoneNo" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">Password:</td>
                <td class="auto-style27">&nbsp;</td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtChangePass" runat="server" placeholder="insert password" Width="146px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*required" ControlToValidate="txtChangePass" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style18"></td>
                <td class="auto-style28"></td>
                <td class="auto-style19">
                    <asp:Button ID="btnChange" runat="server" Text="Change Password" Width="158px" Height="32px" OnClick="btnChange_Click" />
                    &nbsp;<asp:Label ID="lblSuccess" runat="server" Visible="False">*password updated successfully!</asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style30">
                    <h3>Store Manager</h3>
                </td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style17"></td>
            </tr>
            <tr>
                <td class="auto-style35">Order History</td>
                <td class="auto-style36">&nbsp;</td>
                <td class="auto-style37">
                    <asp:Button ID="btnView" runat="server" Text="View" Width="138px" OnClick="btnView_Click" CausesValidation="False" />
                </td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style31">&nbsp;</td>
                <td class="auto-style38">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <asp:Button ID="btnLogout" runat="server" Height="44px" Text="Sign Out" Width="128px" OnClick="btnLogout_Click" CausesValidation="False" />
                </td>
                <td class="auto-style29">&nbsp;</td>
                <td class="auto-style39">&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
