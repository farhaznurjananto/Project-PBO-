<%@ Page Title="" Language="C#" MasterPageFile="~/views/Default.Master" AutoEventWireup="true" CodeBehind="userReservation.aspx.cs" Inherits="PBOFIX.views.user.userReservation" %>

<%-- head --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<%-- head --%>

<%-- body --%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container h-100" style="margin-top: 80px; margin-bottom: 30px;">
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-3">
                    <div class="card">
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <p class="text-center h1 fw-bold mb-4 mx-1 mx-md-4 mt-4">Order</p>
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <hr>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <label>Room Number</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtroomnumber" runat="server" placeholder="Room Number" TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <label>Room Price</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtroomprice" runat="server" placeholder="Room Price" TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class ="row">
                                <div class="col">
                                    <label>Check In</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtcheckin" runat="server" placeholder="Check In" TextMode="Date"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class ="row">
                                <div class="col">
                                    <label>Check Out</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtcheckout" runat="server" placeholder="Check Out" TextMode="Date"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <label>Password</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtpassword" runat="server" placeholder="Your Password" TextMode="Password"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col mt-3">
                                    <div class="form-group">
                                        <center>
                                            <asp:Button class="btn btn-primary" ID="ButtonUserOrderReservation" runat="server" Text="Order" OnClick="ButtonUserOrderReservation_Click" />
                                        </center>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-9">
                    <div class="card">
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <center>
                                        <h4>Reservation Room</h4>
                                        <asp:Label class="fw-bold fs-6" ID="Label1" runat="server" Text="order room"></asp:Label>
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <hr>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-5">
                                    <div class="form-group">
                                        <asp:DropDownList class="form-control" ID="dropdowntype" runat="server">
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-7">
                                    <div class="form-group">
                                        <asp:Button class="btn btn-primary" ID="ButtonUserOrderSearch" runat="server" Text="Search" OnClick="ButtonUserSearchTypeRoom_Click" />
                                    </div>
                                </div>
                            </div>
                            <div class="row mt-2">
                                <div class="col overflow-auto">
                                    <asp:GridView class="table table-striped table-bordered" ID="gridviewreservation" runat="server"></asp:GridView>
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
