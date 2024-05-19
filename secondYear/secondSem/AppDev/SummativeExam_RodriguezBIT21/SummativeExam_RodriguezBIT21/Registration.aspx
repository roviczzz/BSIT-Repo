<%@ Page Title="" Language="C#" MasterPageFile="~/Initial.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Alonzo___Final_Exam.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="hero_area">
    <header class="header_section">
      <div class="header_bottom">
        <div class="container-fluid">
          <nav class="navbar navbar-expand-lg custom_nav-container ">
            <a class="navbar-brand" href="Login.aspx">
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
                  <a class="nav-link" href="Login.aspx">Login </a>
                </li>
                <li class="nav-item active">
                  <a class="nav-link" href="Registration.aspx"> Register <span class="sr-only">(current)</span></a>
                </li>
                  <li class="nav-item">&nbsp;</li>
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
                    Registration
                </h1>
                <p>
                    Please fill out the required fields.</p>
                    <table class="auto-style9" style="color: #000000;">
                        <tr>
                            <td class="auto-style10" style="height: 74px">Email:
                                <strong>
                                <br />
                                <asp:TextBox ID="txtUsername" runat="server" Width="240px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                  <span class="auto-style2">
                                <br />
                                </span>
                                </strong>
                  <span class="auto-style2">
                                <asp:Label ID="lblUserError" runat="server" ForeColor="Red" Text="Username already exists!" Visible="False"></asp:Label>
                                </span>
                                </td>
                            <td class="auto-style5" style="height: 74px"></td>
                        </tr>
                        <tr>
                            <td class="auto-style10" style="height: 26px">First Name:<strong><br />
                                <asp:TextBox ID="txtFirstName" runat="server" Width="240px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFirstName" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                <br />
                                </strong>Last Name:<strong><br />
                                <asp:TextBox ID="txtLastName" runat="server" Width="240px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtLastName" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                </strong></td>
                            <td class="auto-style5" style="height: 26px"></td>
                        </tr>
                        <tr>
                            <td class="auto-style10" style="height: 25px">Basic Monthly Salary:<strong><br />
                                <asp:TextBox ID="txtMonthlySalary" runat="server" Width="240px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtMonthlySalary" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                </strong></td>
                            <td class="auto-style5" style="height: 25px"></td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Password:<strong><br />
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="240px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPassword" ErrorMessage="*" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                                </strong></td>
                            <td class="auto-style6"></td>
                        </tr>
                        </table>
                  <span class="auto-style2">
                      <asp:Button ID="btnRegister" runat="server" BackColor="#ff360d" BorderStyle="None" ForeColor="White" Height="40px" OnClick="Button2_Click" Text="Register" Width="115px" />
                                &nbsp;<br />
                  <strong>
                  <asp:Label ID="lblSuccess" runat="server" Text="Successfully Registered!" Visible="False" ForeColor="#B7B7B7"></asp:Label>
                                </strong>
                                </span>
                 </div>
            </div>
            <div class="col-md-6">
              <div class="img-box">
                <img src="images/registration.png" alt="">
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
