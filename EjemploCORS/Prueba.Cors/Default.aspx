<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Prueba.Cors._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET</h1>
            <p class="lead">Prueba cors origen</p>
        </section>

       <div>
           <a href="/prueba.aspx">Ir a página de prueba, llamando desde java script a un servicio</a>
        </div>
    </main>

</asp:Content>
