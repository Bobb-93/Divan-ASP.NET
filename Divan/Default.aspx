<%@ Page Title="divan - we make art you live in" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Divan._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" runat="server" href="/Styles/Main.css" />
    <link rel="stylesheet" runat="server" href="/Styles/Default.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css">
    <nav>
        <ul>
            <li><a href="#">Home</a></li>
            <li><a href="pages/news.html">News</a></li>
            <li><a href="pages/about_us.html">About us</a></li>
            <li id="services"><a href="pages/services.html">Services</a>
                <ul>
                    <li class="box index-box" id="consulting"><a href="pages/consulting.html">Consulting</a></li>
                    <li class="box index-box" id="furnishing"><a href="pages/furnishing.html">Furnishing</a></li>
                    <li class="box index-box" id="procurement"><a href="pages/procurement.html">Procurement</a></li>
                    <li class="box index-box" id="interior-detailing"><a href="pages/interior-detailing.html">Interior Detailing</a></li>
                </ul>
            </li>
            <li><a href="pages/products.html">Products</a></li>
            <li><a href="pages/gallery.html">Gallery</a></li>
            <li><a href="pages/contact.html">Contact</a></li>
        </ul>
    </nav>

</asp:Content>
