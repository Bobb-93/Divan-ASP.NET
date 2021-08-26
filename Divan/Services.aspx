<%@ Page Title="Services" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Services.aspx.cs" Inherits="Divan.Services" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" runat="server" href="/Styles/Services.css" />
    <h1><%: Title %></h1>
    <p>We are proud to assure our clients that here at Divan we offer the whole package of services related to any Interior Design project.<br> Wether you want us to help you design your own pool, or do the remodelling and designing of your new home or office space<br> we will be there for you to deliver. Our services consist of the following:</p>
        <div id="lists-of-services">
            <div class="type-of-service" id="consulting-div">
                <h2 id="consulting-heading"><a href="consulting.html">Consulting</a></h2>
                <ul>
                    <li><a href="consulting.html#architects">Architects</a></li>
                    <li><a href="consulting.html#builders">Builders</a></li>
                    <li><a href="consulting.html#millwork">Millwork</a></li>
                    <li><a href="consulting.html#lighting-specialists">Lighting Specialists</a></li>
                    <li><a href="consulting.html#landscape-architects">Landscape Architects</a></li>
                </ul>
            </div>
            <div class="type-of-service" id="furnishing-div">
                <h2 id="furnishing-heading"><a href="furnishing.html">Furnishing</a></h2>
                <ul>
                    <li><a href="furnishing.html#case-goods">Case goods</a></li>
                    <li><a href="furnishing.html#lighting">Lighting</a></li>
                    <li><a href="furnishing.html#artwork-and-sculpture">Artwork and Sculpture</a></li>
                    <li><a href="furnishing.html#greenery">Greenery</a></li>
                    <li><a href="furnishing.html#accessories">Accessories</a></li>
                </ul>
            </div>
            <div class="type-of-service" id="procurement-div">
                <h2 id="procurement-heading"><a href="procurement.html">Procurement</a></h2>
                <ul>
                    <li><a href="procurement.html#in-house">All work is done 'in-house'</a></li>
                    <li><a href="procurement.html#quality-controls">Quality Controls</a></li>
                    <li><a href="procurement.html#senior-designers">Oversight by Senior Designers</a></li>
                    <li><a href="procurement.html#competive-pricing">Competitive pricing</a></li>
                    <li><a href="procurement.html#upon-competition">Walk through upon competition</a></li>
                </ul>
            </div>
            <div class="type-of-service" id="interior-detailing-div">
                <h2 id="interior-detailing-heading"><a href="interior-detailing.html">Interior Detailing</a></h2>
                <ul>
                    <li><a href="interior-detailing.html#floor-plan">Floor Plan Space Planning</a></li>
                    <li><a href="interior-detailing.html#floor-plan-review">Floor plan review</a></li>
                    <li><a href="interior-detailing.html#ceiling-details">Reflected Ceiling details</a></li>
                    <li><a href="interior-detailing.html#wall-elevations">Wall elevations</a></li>
                    <li><a href="interior-detailing.html#section-drawings">Section drawings</a></li>
                </ul>
            </div>
        </div>
</asp:Content>
