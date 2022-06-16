<%@ Page Title="" Language="C#" MasterPageFile="~/views/Default.Master" AutoEventWireup="true" CodeBehind="adminRoom.aspx.cs" Inherits="PBOFIX.views.admin.adminRoom" %>

<%-- head --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<%-- head --%>

<%-- body --%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-top: 110px; margin-bottom: 50px;">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Room Details</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img style="width: 100px;" src="../img/undraw_reviews_lp8w.svg" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-7">
                                <label>No Room</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="txtnoroom" runat="server" placeholder="No Room" TextMode="Number"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" ID="LinkButtonGo" runat="server" Text="Go" OnClick="LinkButtonGo_Click" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-5">
                                <label>Type Room</label>
                                <div class="form-group">
                                    <asp:DropDownList class="form-control" ID="dropdowntype" runat="server">
                                    </asp:DropDownList>
                                    <asp:Label ID="labeltype" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="row mt-3">
                            <div class="col-4 d-flex justify-content-around">
                                <asp:Button ID="LinkButtonAdd" class="btn btn-block btn-success" runat="server" Text="Add" OnClick="LinkButtonAdd_Click" />
                            </div>
                            <div class="col-4 d-flex justify-content-around">
                                <asp:Button ID="LinkButtonUpdate" class="btn btn-block btn-warning" runat="server" Text="Update" OnClick="LinkButtonUpdate_Click" />
                            </div>
                            <div class="col-4 d-flex justify-content-around">
                                <asp:Button ID="LinkButtonDelete" class="btn btn-block btn-danger" runat="server" Text="Delete" OnClick="LinkButtonDelete_Click" />
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
                                    <h4>Room List</h4>
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
                                <asp:GridView class="table table-striped table-bordered" ID="GridViewroom" runat="server"></asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<%-- body --%>
