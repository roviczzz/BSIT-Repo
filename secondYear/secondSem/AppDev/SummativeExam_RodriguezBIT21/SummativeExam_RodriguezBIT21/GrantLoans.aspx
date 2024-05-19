<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="GrantLoans.aspx.cs" Inherits="Alonzo___Final_Exam.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
    .centered {
        text-align: center;
    }

    .padded {
        padding: 10px; 
    }

    .centered-padded {
        text-align: center;
        padding: 10px;
    }
</style>


    <div class="hero_area">
    <!-- header section strats -->
    <header class="header_section">
      <div class="header_bottom">
        <div class="container-fluid">
          <nav class="navbar navbar-expand-lg custom_nav-container ">
            <a class="navbar-brand" href="ViewPending.aspx">
              <span>
               <img src="images/ABC.png" alt="" class="auto-style2">
              </span>
            </a>

            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
              <span class=""> </span>
            </button>

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
              <ul class="navbar-nav ">
                <li class="nav-item">
                  <a class="nav-link" href="ViewPending.aspx">View Pending / Approved Loans</a>
                </li>
                <li class="nav-item  active">
                  <a class="nav-link" href="GrantLoans.aspx">Grant Loans<span class="sr-only">(current)</span>
                    </a>
                </li>
                  <li class="nav-item"><a class="nav-link" href="Login.aspx">Log-out
                </a></li>
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
                    <h1>
                        Grant Loans</h1>
                    <p>
                        Press radio button to select an option, then select confirm.
                    </p>
                                               <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" CssClass="centered padded center-padded" Height="156px" Width="279px" AutoGenerateColumns="False">
                                                   <Columns>
                                                       <asp:TemplateField>
                                                           <ItemTemplate>
                                                               <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                                                   <asp:ListItem>Approved</asp:ListItem>
                                                                   <asp:ListItem>Rejected</asp:ListItem>
                                                               </asp:RadioButtonList>
                                                           </ItemTemplate>
                                                       </asp:TemplateField>
                                                       <asp:BoundField DataField="Email" HeaderText="Email" />
                                                       <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                                                       <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                                                       <asp:BoundField DataField="BasicMonthly" HeaderText="Basic Monthly Salary" />
                                                       <asp:BoundField DataField="LoanAmount" HeaderText="Loan Amount" />
                                                       <asp:BoundField DataField="Interest" HeaderText="Interest" />
                                                       <asp:BoundField DataField="ServiceCharge" HeaderText="Service Charge" />
                                                       <asp:BoundField DataField="TakeHome" HeaderText="Take Home Loan" />
                                                       <asp:BoundField DataField="MonthlyAmortization" HeaderText="Monthly Amortization" />
                                                   </Columns>
                                                   <FooterStyle BackColor="White" ForeColor="#000066" />
                                                   <HeaderStyle BackColor="#ff360d" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                                                   <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                                                   <RowStyle ForeColor="#000000" />
                                                   <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                                                   <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                                   <SortedAscendingHeaderStyle BackColor="#007DBB" />
                                                   <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                                   <SortedDescendingHeaderStyle BackColor="#00547E" />
                                               </asp:GridView>
                                           <br />
                      <asp:Button ID="btnConfirm" runat="server" BackColor="#ff360d" BorderStyle="None" ForeColor="White" Height="40px" OnClick="btnConfirm_Click" Text="Confirm" Width="115px" />
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="img-box">
                    &nbsp;</div>
                </div>
              </div>
            </div>
          </div>
          <div class="carousel-item">
            <div class="container ">
              <div class="row">
                <div class="col-md-6">
                  <div class="detail-box">
                    <h1>
                      Welcome to our shop
                    </h1>
                    <p>
                      Lorem ipsum dolor sit amet, consectetur adipisicing elit. Iste quam velit saepe dolorem deserunt quo quidem ad optio.
                    </p>
                    <a href="">
                      Read More
                    </a>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="img-box">
                    <img src="images/slider-img.png" alt="">
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
                    <h1>
                      Welcome to our shop
                    </h1>
                    <p>
                      Lorem ipsum dolor sit amet, consectetur adipisicing elit. Iste quam velit saepe dolorem deserunt quo quidem ad optio.
                    </p>
                    <a href="">
                      Read More
                    </a>
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="img-box">
                    <img src="images/slider-img.png" alt="">
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>
</div>
</asp:Content>
