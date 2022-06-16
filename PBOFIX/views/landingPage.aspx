<%@ Page Title="" Language="C#" MasterPageFile="~/views/Default.Master" AutoEventWireup="true" CodeBehind="landingPage.aspx.cs" Inherits="PBOFIX.landingPage" %>
<%-- head --%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<%-- head --%>

<%-- body --%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- jumbotron --%>
    <div class="container my-5" id="home">
        <div class="bg-image p-5 text-center shadow-1-strong rounded mb-5 text-white"
            style="background-image: url('https://images.unsplash.com/photo-1596436889106-be35e843f974?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80'); height: 400px; margin-top:100px;">
        </div>
    </div>
    <%-- jumbotron --%>

    <%-- content --%>
    <div class="container my-5 text-center mt-5 mb-5">
        <p class="h3">Our Service</p>
        <p class="mt-3">
            Lorem ipsum dolor, sit amet consectetur adipisicing elit. Repellendus praesentium labore accusamus sequi, voluptate debitis tenetur in deleniti possimus modi voluptatum neque maiores dolorem unde? Aut dolorum quod excepturi fugit.
                Lorem ipsum dolor, sit amet consectetur adipisicing elit. Repellendus praesentium labore accusamus sequi, voluptate debitis tenetur in deleniti possimus modi voluptatum neque maiores dolorem unde? Aut dolorum quod excepturi fugit.
        </p>
    </div>
    <%-- content --%>

    <%-- cards --%>
    <div class="container my-5 text-center mt-5 mb-5">
        <p class="h3" id="service">Our Service</p>
        <div class="row row-cols-1 row-cols-md-3 g-4 mt-3">
            <div class="col">
                <div class="card h-100">
                    <img src="../img/undraw_online_article_re_daq5.svg" class="card-img-top" alt="...." style="height:30vh"/>
                    <div class="card-body">
                        <h5 class="card-title">Card title</h5>
                        <p class="card-text">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="card h-100">
                    <img src="../img/undraw_reviews_lp8w.svg" class="card-img-top" alt="...." style="height:30vh"/>
                    <div class="card-body">
                        <h5 class="card-title">Card title</h5>
                        <p class="card-text">This is a short card.</p>
                    </div>
                </div>
            </div>
            <div class="col">
                <div class="card h-100">
                    <img src="../img/undraw_speed_test_wxl0.svg" class="card-img-top" alt="...." style="height:30vh"/>
                    <div class="card-body">
                        <h5 class="card-title">Card title</h5>
                        <p class="card-text">This is a longer card with supporting text below as a natural lead-in to additional content.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <%-- cards --%>

    <%-- galery --%>
    <div class="container my-5 text-center mt-5 mb-5">
        <p class="h3 mb-5" id="galery">Our Service</p>
        <div class="row">
            <div class="col-lg-4 col-md-12 mb-4 mb-lg-0">
                <img
                    src="https://mdbcdn.b-cdn.net/img/Photos/Horizontal/Nature/4-col/img%20(73).webp"
                    class="w-100 shadow-1-strong rounded mb-4"
                    alt="Boat on Calm Water" />

                <img
                    src="https://mdbcdn.b-cdn.net/img/Photos/Vertical/mountain1.webp"
                    class="w-100 shadow-1-strong rounded mb-4"
                    alt="Wintry Mountain Landscape" />
            </div>

            <div class="col-lg-4 mb-4 mb-lg-0">
                <img
                    src="https://mdbcdn.b-cdn.net/img/Photos/Vertical/mountain2.webp"
                    class="w-100 shadow-1-strong rounded mb-4"
                    alt="Mountains in the Clouds" />

                <img
                    src="https://mdbcdn.b-cdn.net/img/Photos/Horizontal/Nature/4-col/img%20(73).webp"
                    class="w-100 shadow-1-strong rounded mb-4"
                    alt="Boat on Calm Water" />
            </div>

            <div class="col-lg-4 mb-4 mb-lg-0">
                <img
                    src="https://mdbcdn.b-cdn.net/img/Photos/Horizontal/Nature/4-col/img%20(18).webp"
                    class="w-100 shadow-1-strong rounded mb-4"
                    alt="Waves at Sea" />

                <img
                    src="https://mdbcdn.b-cdn.net/img/Photos/Vertical/mountain3.webp"
                    class="w-100 shadow-1-strong rounded mb-4"
                    alt="Yosemite National Park" />
            </div>
        </div>
    </div>
    <%-- galery --%>
</asp:Content>
<%-- body --%>
