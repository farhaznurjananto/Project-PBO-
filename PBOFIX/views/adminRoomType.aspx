<%@ Page Title="" Language="C#" MasterPageFile="~/views/Default.Master" AutoEventWireup="true" CodeBehind="adminRoomType.aspx.cs" Inherits="PBOFIX.views.admin.adminRoomType" %>

<%-- head --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<%-- head --%>

<%-- body --%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-top: 110px; margin-bottom: 50px;">
        <div class="row">
            <div class="col-md-4">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Room Type Detail</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img id="imgview" src="../img/undraw_reviews_lp8w.svg" style="width: 100px;" />
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
                                <label>Upload Image</label>
                                <asp:FileUpload class="form-control" ID="fileuploadimg" runat="server" />
                                <asp:Label ID="pathImg" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="row mt-3">
                            <div class="col">
                                <label>Room Type</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="txttyperoom" runat="server" placeholder="Type"></asp:TextBox>
                                        <asp:Button class="btn btn-primary" ID="ButtonGo" runat="server" Text="Go" OnClick="ButtonGo_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row mt-3">
                            <div class="col">
                                <label>Room Type Price</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtpricetype" runat="server" placeholder="Price" TextMode="Number"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row mt-3">
                            <div class="col">
                                <label>Descriptions</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txttypedescription" runat="server" placeholder="Descriptions" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row mt-3">
                            <div class="col-4 d-flex justify-content-around">
                                <asp:Button ID="ButtonAdd" class="btn btn-block btn-success" runat="server" Text="Add" OnClick="ButtonAdd_Click" />
                            </div>
                            <div class="col-4 d-flex justify-content-around">
                                <asp:Button ID="ButtonUpdate" class="btn btn-block btn-warning" runat="server" Text="Update" OnClick="ButtonUpdate_Click" />
                            </div>
                            <div class="col-4 d-flex justify-content-around">
                                <asp:Button ID="ButtonDelete" class="btn btn-block btn-danger" runat="server" Text="Delete" OnClick="ButtonDelete_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-8">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Room Type List</h4>
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
                                <asp:GridView class="table table-striped table-bordered" ID="Gridviewroomtype" runat="server"></asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<%-- body --%>
