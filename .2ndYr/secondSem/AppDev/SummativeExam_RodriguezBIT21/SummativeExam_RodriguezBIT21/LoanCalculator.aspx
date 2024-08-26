<%@ Page Title="" Language="C#" MasterPageFile="~/Client.Master" AutoEventWireup="true" CodeBehind="LoanCalculator.aspx.cs" Inherits="Alonzo___Final_Exam.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hero_area">
    <!-- header section strats -->
    <header class="header_section">
      <div class="header_bottom">
        <div class="container-fluid">
          <nav class="navbar navbar-expand-lg custom_nav-container ">
            <a class="navbar-brand" href="LoanCalculator.aspx">
              <span>
               <img src="images/ABC.png" alt="" class="auto-style2">
              </span>
            </a>

            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
              <span class=""> </span>
            </button>

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
              <ul class="navbar-nav ">
                <li class="nav-item active">
                  <a class="nav-link" href="LoanCalculator.aspx">Loan Calculator<span class="sr-only">(current)</span></a>
                </li>
                 <li class="nav-item">
                 <a class="nav-link" href="ProcessApplication.aspx">Process Loan Application</a></li>
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
                                   <div class="col-md-6">
                                       <div class="detail-box">
                                           <h1>Loan Calculator</h1>
                                           <p>
                                               You must calculate your loan before proceeding to process it.</p>
                                           <p>
                                               <strong>Loanable amount:
                                               <asp:Label ID="lblLoanable" runat="server"></asp:Label>
                                               </strong></p>
                                           <p>
                                               <strong>
                                               <asp:RangeValidator ID="rangeLoanable" runat="server" ControlToValidate="txtLoanAmount" ErrorMessage="Invalid Input / Amount to loan has exceeded loanable amount!" ForeColor="Red" MinimumValue="0" Type="Double"></asp:RangeValidator>
                                </strong></p>
                                           <p>
                                               <strong>
                                               <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtNumberOfMonths" ErrorMessage="Allowed number of months is between 1 to 25!" ForeColor="Red" MaximumValue="25" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                                </strong></p>
                                           <p>
                                           <table class="auto-style3" style="color:#000000;">
                                               <tr>
                                                   <td class="auto-style6" style="width: 244px"><strong>Enter amount to loan:</strong></td>
                                                   <td class="auto-style4" style="width: 398px">
                                                       <asp:TextBox ID="txtLoanAmount" runat="server" CssClass="auto-style8" TextMode="Number" Width="200px" style="margin-left: 0"></asp:TextBox>
                                                       <strong>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLoanAmount" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                </strong>
                                                   </td>
                                               </tr>
                                               <tr>
                                                   <td class="auto-style6" style="width: 244px"><strong>Enter number of months:</strong></td>
                                                   <td class="auto-style4" style="width: 398px">
                                                       <asp:TextBox ID="txtNumberOfMonths" runat="server" CssClass="auto-style8" TextMode="Number" Width="200px" style="margin-left: 0"></asp:TextBox>
                                                       <strong>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNumberOfMonths" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                </strong>
                                                   </td>
                                               </tr>
                                               <tr>
                                                   <td class="auto-style6" style="width: 244px">&nbsp;</td>
                                                   <td class="auto-style4" style="width: 398px">
                                                       <strong>
                                                       <br />
                      <asp:Button ID="btnCalculate" runat="server" BackColor="#ff0000" BorderStyle="None" ForeColor="White" Height="40px" OnClick="btnConfirm_Click" Text="Calculate" Width="115px" />
                                                       </strong>
                                                   </td>
                                               </tr>
                                               <tr>
                                                   <td class="auto-style7" style="width: 244px; height: 42px;">
                                                   </td>
                                                   <td class="auto-style5" style="width: 398px; height: 42px;">
                                                       &nbsp;</td>
                                               </tr>
                                               <tr>
                                                   <td class="auto-style7" style="width: 244px"><strong>Loan Amount:</strong></td>
                                                   <td class="auto-style5" style="width: 398px">
                                                       <asp:Label ID="lblLoanAmount" runat="server"></asp:Label>
                                                   </td>
                                               </tr>
                                               <tr>
                                                   <td class="auto-style7" style="width: 244px"><strong>Interest:</strong></td>
                                                   <td class="auto-style5" style="width: 398px">
                                                       <asp:Label ID="lblInterest" runat="server"></asp:Label>
                                                   </td>
                                               </tr>
                                               <tr>
                                                   <td class="auto-style7" style="width: 244px; height: 26px;"><strong>Take Home Loan:</strong></td>
                                                   <td class="auto-style5" style="width: 398px; height: 26px;">
                                                       <asp:Label ID="lblTakeHome" runat="server"></asp:Label>
                                                   </td>
                                               </tr>
                                               <tr>
                                                   <td class="auto-style7" style="width: 244px"><strong>Service Charge:</strong></td>
                                                   <td class="auto-style5" style="width: 398px">
                                                       <asp:Label ID="lblServiceCharge" runat="server"></asp:Label>
                                                   </td>
                                               </tr>
                                               <tr>
                                                   <td class="auto-style7" style="width: 244px"><strong>Monthly Amortization:</strong></td>
                                                   <td class="auto-style5" style="width: 398px">
                                                       <asp:Label ID="lblMonthly" runat="server"></asp:Label>
                                                   </td>
                                               </tr>
                                           </table>
                                           <p>
                                               &nbsp;</div>
                                   </div>
                                   <div class="col-md-6">
                                       <div class="img-box">
                                           <img src="images/loan.png" alt="">
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
