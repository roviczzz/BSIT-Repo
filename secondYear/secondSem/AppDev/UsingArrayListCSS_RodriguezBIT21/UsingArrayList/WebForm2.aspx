<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="UsingArrayList.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Blue Freedom by minimalistic-design.net</title>
<meta http-equiv="Content-Language" content="English" />
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<link rel="stylesheet" type="text/css" href="style.css" media="screen" />
    <style type="text/css">
        .auto-style1 {
            float: left;
            width: 30%;
            margin: 0 10px;
            padding: 1% 1%;
            height: 180px;
        }
    </style>
</head>
<body>
<div id="wrap">

<div id="top"></div>

<div id="content">

<div class="header">
<h1><a href="#">Account Log</a></h1>
<h2>&nbsp;</h2>
</div>

<div class="middle">
			
<br /><br />
 		
</div>
		
<div class="auto-style1">
		
<h2 style="">Navigation</h2>

<form id="form1" runat="server">
    <div style="background-color: #FFFFFF">

        <asp:Menu ID="Menu1" runat="server" BackColor="#E3EAEB" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#666666" Orientation="Horizontal" StaticSubMenuIndent="10px" style="font-size: medium; color: #FFFFFF; text-align: right">
            <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="#E3EAEB" />
            <DynamicSelectedStyle BackColor="#1C5E55" />
            <Items>
                <asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home" Value="Home"></asp:MenuItem>
                <asp:MenuItem Text="System" Value="Registration">
                    <asp:MenuItem NavigateUrl="~/Registration.aspx" Text="Registration" Value="Registration"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/SignIn.aspx" Text="Sign In" Value="Sign In"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="View Records" Value="View Records">
                    <asp:MenuItem NavigateUrl="~/ViewAll.aspx" Text="All Records" Value="All Records"></asp:MenuItem>
                    <asp:MenuItem Text="Search Record" Value="Search Record" NavigateUrl="~/SearchRecord.aspx"></asp:MenuItem>
                </asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#666666" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#1C5E55" />
        </asp:Menu>

    </div>
<div>
    <asp:ContentPlaceHolder ID="ContentPlaceHolder1" runat="server">
    
    </asp:ContentPlaceHolder>
</div>
</form>
		
</div>

<div id="clear"></div>

</div>

<div id="bottom"></div>

</div>

</body>
</html>
