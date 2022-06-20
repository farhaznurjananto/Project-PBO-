<%@ Page Title="" Language="C#" MasterPageFile="~/views/Default.Master" AutoEventWireup="true" CodeBehind="adminReservation.aspx.cs" Inherits="PBOFIX.views.admin.adminReservation" %>

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
                                        <p class="text-center h1 fw-bold mb-4 mx-1 mx-md-4 mt-4">Done</p>
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
                                    <label>User Id</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtiduser" runat="server" placeholder="Customer Id" TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col mt-3">
                                    <div class="form-group">
                                        <center>
                                            <asp:Button class="btn btn-primary" ID="ButtonUserUpadateReservation" runat="server" Text="Done" OnClick="ButtonUserUpadateReservation_Click"/>
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
                                        <h4>Reservation Customer</h4>
                                        <asp:Label class="fw-bold fs-6" ID="Label1" runat="server" Text="reservation room"></asp:Label>
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
