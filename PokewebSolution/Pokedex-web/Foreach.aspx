<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Foreach.aspx.cs" Inherits="Pokedex_web.Foreach" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="row row-cols-1 row-cols-md-3 g-4">
    <%foreach (dominio.Pokemon poke in listapokemon)
        { %>

    
        <div class="col">
            <div class="card">
                <img src="<%:poke.UrlImagen %>" class="card-img-top" alt="<%:poke.Nombre %>">
                <div class="card-body">
                    <h5 class="card-title"><%:poke.Nombre %></h5>
                    <p class="<%:poke.Descripcion %>"</p>
                </div>
            </div>
        </div>
    




    <%} %>
    </div>

</asp:Content>
