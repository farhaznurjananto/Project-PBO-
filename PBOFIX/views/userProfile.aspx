<%@ Page Title="" Language="C#" MasterPageFile="~/views/Default.Master" AutoEventWireup="true" CodeBehind="userProfile.aspx.cs" Inherits="PBOFIX.views.user.userProfile" %>
<%-- head --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<%-- head --%>

<%-- body --%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container h-100" style="margin-top: 80px; margin-bottom: 30px;">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-5">
                    <div class="card">
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <p class="text-center h1 fw-bold mb-4 mx-1 mx-md-4 mt-4">Profile</p>
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
                                        <asp:TextBox CssClass="form-control" ID="txtFullname" runat="server" placeholder="Full Name"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <label>Date of Birth</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtBoxDate" runat="server" TextMode="Date"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <label>Phone Number</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtBoxPhone" runat="server" placeholder="Phone Number" TextMode="Phone"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <label>Email Address</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtBoxEmail" runat="server" placeholder="Email Address" TextMode="Email"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-6">
                                    <label>State</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="txtBoxState" runat="server" placeholder="State"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <label>City</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="txtBoxCity" runat="server" placeholder="City"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <label>Full Address</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtBoxFulladdress" runat="server" placeholder="Full Address" TextMode="MultiLine" Rows="2"></asp:TextBox>
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
                                <div class="col-md-4">
                                    <label>Username</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="txtBoxUsername" runat="server" placeholder="Username" ReadOnly="True"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <label>Old Password</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="txtBoxOldpassword" runat="server" placeholder="Old Password" ReadOnly="True"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <label>New Password</label>
                                    <div class="form-group">
                                        <asp:TextBox class="form-control" ID="txtBoxNewpassword" runat="server" placeholder="New Password" TextMode="Password"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-8 mx-auto mt-2">
                                    <center>
                                        <div class="form-group">
                                            <asp:Button class="btn btn-primary btn-block" ID="ButtonUserUpadateProfile" runat="server" Text="Update" OnClick="ButtonUserUpadateProfile_Click" />
                                        </div>
                                    </center>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-7">
                    <div class="card">
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <h4>Your Order Rooms</h4>
                                        <asp:Label class="fw-bold fs-6" ID="Label2" runat="server" Text="your order info"></asp:Label>
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <hr>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col overflow-auto">
                                    <asp:GridView class="table table-striped table-bordered" ID="GridViewReservation" runat="server"></asp:GridView>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<%-- body --%>
