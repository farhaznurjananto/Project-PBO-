<%@ Page Title="" Language="C#" MasterPageFile="~/views/Default.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="PBOFIX.register" %>
<%-- head --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<%-- head --%>

<%-- body --%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container h-100" style="margin-top: 80px; margin-bottom: 30px;">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-6">
                    <div class="card">
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <p class="text-center h1 fw-bold mb-4 mx-1 mx-md-4 mt-4">Sign Up</p>
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <hr>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <label>Full Name</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtfullname" runat="server" placeholder="Full Name"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <label>Date of Birth</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtbirthdate" runat="server" placeholder="Birth Date" TextMode="Date"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <label>Phone Number</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtphone" runat="server" placeholder="Phone Number" TextMode="Phone"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <label>Email Address</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtemail" runat="server" placeholder="Email Address" TextMode="Email"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <label>State</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="txtstate" runat="server" placeholder="State"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <label>City</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="txtcity" runat="server" placeholder="City"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <label>Full Address</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtaddress" runat="server" placeholder="Full Address" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <span class="fw-bold fs-6">Login Credentials</span>
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <label>Username</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="txtusername" runat="server" placeholder="Username"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <label>Password</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="txtpassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-8 mx-auto mt-2">
                                    <center>
                                        <div class="form-group">
                                            <asp:Button class="btn btn-primary btn-block" ID="ButtonSignUp" runat="server" Text="SIgn Up" OnClick="ButtonSignUp_Click"/>
                                        </div>
                                    </center>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-6">
                    <img src="../img/undraw_online_article_re_daq5.svg" class="img-fluid pt-5" alt="....">
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<%-- body --%>
