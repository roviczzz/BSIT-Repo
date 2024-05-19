<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="ProcessApplication.aspx.cs" Inherits="Alonzo___Final_Exam.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="hero_area">
    <!-- header section strats -->
    <header class="header_section">
      <div class="header_bottom">
        <div class="container-fluid">
          <nav class="navbar navbar-expand-lg custom_nav-container ">
            <a class="navbar-brand" href="index.html">
              <span>
               <img src="images/ABC.png" alt="" class="auto-style2">
              </span>
            &nbsp;</a>

            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
              <span class=""> </span>
            </button>

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
              <ul class="navbar-nav ">
                <li class="nav-item">
                  <a class="nav-link" href="LoanCalculator.aspx">Loan Calculator</a>
                </li>
                 <li class="nav-item active">
                 <a class="nav-link" href="ProcessApplication.aspx">Process Loan Application<span class="sr-only">(current)</span></a></li>
                                   <li class="nav-item"><a class="nav-link" href="Login.aspx">Log-out </a></li>
                               </ul>
                           </div>
                       </nav>
                   </div>
               </div>
           </header>
    <!-- end header section -->

                
    <!-- slider section -->
           <section class="slider_section ">
               <div id="customCarousel1" class="carousel slide" data-ride="carousel">
                   <div class="carousel-inner">
                       <div class="carousel-item active">
                           <div class="container ">
                               <div class="row">
                                   <div class="col-md-6" style="left: 0px; top: 0px">
                                       <div class="detail-box">
                                           <h1>Application Status:
                                               <asp:Label ID="lblStatus" runat="server" ForeColor="Black"></asp:Label>
                                           </h1>
                                           <p>
                                               <asp:Label ID="Label1" runat="server" Text="You will no longer be able to apply once your application is Pending or Approved"></asp:Label>
                                           </p>
                                           <p></p>
                                           <asp:Panel ID="Panel1" runat="server" Visible="False">
                                               <h1>Process Loan Application</h1>
                                               <p>
                                                   Confirm these details before proceeding with your application.</p>
                                               <p>
                                                   <table class="auto-style3" style="color: #000000;">
                                                       <tr>
                                                           <td class="text-left" style="width: 214px; height: 26px;"><strong>Number of months:</strong></td>
                                                           <td class="auto-style5" style="width: 225px; height: 26px;">
                                                               <asp:Label ID="lblNumberOfMonths" runat="server"></asp:Label>
                                                           </td>
                                                       </tr>
                                                       <tr>
                                                           <td class="text-left" style="width: 214px"><strong>Loan Amount:</strong></td>
                                                           <td class="auto-style5" style="width: 225px">
                                                               <asp:Label ID="lblLoanAmount" runat="server"></asp:Label>
                                                           </td>
                                                       </tr>
                                                       <tr>
                                                           <td class="text-left" style="width: 214px"><strong>Interest:</strong></td>
                                                           <td class="auto-style5" style="width: 225px">
                                                               <asp:Label ID="lblInterest" runat="server"></asp:Label>
                                                           </td>
                                                       </tr>
                                                       <tr>
                                                           <td class="text-left" style="width: 214px; height: 26px;"><strong>Take Home Loan:</strong></td>
                                                           <td class="auto-style5" style="width: 225px; height: 26px;">
                                                               <asp:Label ID="lblTakeHome" runat="server"></asp:Label>
                                                           </td>
                                                       </tr>
                                                       <tr>
                                                           <td class="text-left" style="width: 214px"><strong>Service Charge:</strong></td>
                                                           <td class="auto-style5" style="width: 225px">
                                                               <asp:Label ID="lblServiceCharge" runat="server"></asp:Label>
                                                           </td>
                                                       </tr>
                                                       <tr>
                                                           <td class="text-left" style="width: 214px"><strong>Monthly Amortization:</strong></td>
                                                           <td class="auto-style5" style="width: 225px">
                                                               <asp:Label ID="lblMonthly" runat="server"></asp:Label>
                                                           </td>
                                                       </tr>
                                                   </table>
                                                   <p>
                                                       <asp:Button ID="btnApply" runat="server" BackColor="#ff360d" BorderStyle="None" ForeColor="White" Height="40px" OnClick="btnConfirm_Click" Text="Apply" Width="115px" />
                                           </asp:Panel>
                                       </div>
                                   </div>
                                   <div class="col-md-6">
                                       <div class="img-box">
                                           <img src="images/Login.png" alt="">
                                       </div>
                                   </div>
                               </div>
                           </div>
                       </div>
                       <div class="carousel-item">
                           <div class="container ">
                               <div class="row">
                                   <div class="col-md-6">
                                       <div class="detail-box">
                                           <h1>Welcome to our shop  </section>
    <!-- end slider section --></div>
</asp:Content>
