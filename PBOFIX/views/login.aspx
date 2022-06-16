<%@ Page Title="" Language="C#" MasterPageFile="~/views/Default.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="PBOFIX.login" %>

<%-- head --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<%-- head --%>

<%-- body --%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container mb-5 mt-5">
        <div class="container-fluid h-custom" style="margin-top: 100px">
            <div class="row d-flex justify-content-center align-items-center h-100">
                <div class="col-md-9 col-lg-6 col-xl-5">
                    <img src="../img/undraw_online_article_re_daq5.svg" class="img-fluid" alt="Sample image">
                </div>
                <div class="col-md-8 col-lg-6 col-xl-4 offset-xl-1">
                    <p class="text-center h1 fw-bold mb-5 mx-1 mx-md-4 mt-4">Login</p>
                    <!-- Email input -->
                    <div class="form-outline mb-4">
                        <asp:TextBox CssClass="form-control form-control-lg" ID="txtUsername" runat="server" placeholder="Enter Username" type="text"></asp:TextBox>
                        <label class="form-label" for="form3Example3">Username</label>
                    </div>

                    <!-- Password input -->
                    <div class="form-outline mb-3">
                        <asp:TextBox CssClass="form-control form-control-lg" ID="txtPassword" runat="server" placeholder="Enter password" type="password" Wrap="True" TextMode="Password"></asp:TextBox>
                        <label class="form-label" for="form3Example4">Password</label>
                    </div>

                    <div class="text-center text-lg-start mt-4 pt-2">
                        <asp:Button CssClass="btn btn-primary" type="button" Style="padding-left: 2.5rem; padding-right: 2.5rem;" ID="ButtonUserLogin" runat="server" Text="User Login" OnClick="ButtonUserLogin_Click" />
                        <asp:Button CssClass="btn btn-warning" type="button" Style="padding-left: 2.5rem; padding-right: 2.5rem;" ID="ButtonAdminLogin" runat="server" Text="Admin Login" OnClick="ButtonAdminLogin_Click" />
                        <p class="small fw-bold mt-2 pt-1 mb-0">
                            Don't have an account? <a href="register.aspx" class="link-danger">Register</a>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
<%-- body --%>
