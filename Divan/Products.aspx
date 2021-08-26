<%@ Page Title="Products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Divan.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" runat="server" href="/Styles/Products.css" />
    <h1><%: Title %></h1>
    <nav id="productsLists">
        <ul>
            <li id="livingRoom"><a href="#">Living Room</a>
                <ul>
                    <li class="box pages-box" id="sofas"><a href="#">Sofas</a></li>
                    <li class="box pages-box" id="sectionalSofas"><a href="#">Sectional Sofas</a></li>
                    <li class="box pages-box" id="sleeperSofas"><a href="#">Sleeper Sofas</a></li>
                    <li class="box pages-box" id="ottomanChairs"><a href="#">Ottoman Chairs</a></li>
                </ul>
            </li>
            <li id="diningRoom"><a href="#">Dining Room</a>
                <ul>
                    <li class="box pages-box" id="diningTables"><a href="#">Dining tables</a></li>
                    <li class="box pages-box" id="armChairs"><a href="#">Arm Chairs</a></li>
                    <li class="box pages-box" id="consoleTables"><a href="#">Console tables</a></li>
                </ul>
            </li>
            <li id="bedroom"><a href="#">Bedroom</a>
                <ul>
                    <li class="box pages-box" id="beds"><a href="#">Beds</a></li>
                    <li class="box pages-box" id="nightstands"><a href="#">Nightstands</a></li>
                    <li class="box pages-box" id="mirrors"><a href="#">Mirrors</a></li>
                </ul>
            </li>
            <li id="office"><a href="#">Office</a>
                <ul>
                    <li class="box pages-box" id="desks"><a href="#">Desks</a></li>
                    <li class="box pages-box" id="storageCabinets"><a href="#">Storage cabinets</a></li>
                    <li class="box pages-box" id="bookcases"><a href="#">Bookcases</a></li>
                </ul>
            </li>
        </ul>
        <div class="clearfix"></div>
    </nav>

    <main>
        <h2 id="chooseHeader">Choose from our Variety of Products!</h2>
        <div id="leftDiv">
            <h3 class="productName"></h3>
            <img src="#" alt="sofa-1" id="img-1">
            <p class="price">Price: $<span></span></p>
            <button class="addToCart" title="Add to cart" data-price="">Add to cart</button>
            <p class="description"></p>
        </div>
        <div id="centerDiv">
            <h3 class="productName"></h3>
            <img src="#" alt="sofa-2" id="img-2">
            <p class="price">Price: $<span></span></p>
            <button class="addToCart" title="Add to cart" data-price="">Add to cart</button>
            <p class="description"></p>
        </div>
        <div id="rightDiv">
            <h3 class="productName"></h3>
            <img src="#" alt="sofa-3" id="img-3">
            <p class="price">Price: $<span></span></p>
            <button class="addToCart" title="Add to cart" data-price="">Add to cart</button>
            <p class="description"></p>
        </div>
    </main>
</asp:Content>
