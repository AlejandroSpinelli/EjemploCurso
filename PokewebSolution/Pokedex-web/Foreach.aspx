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
                    <h3 class="card-title"><%:poke.Nombre %></h3>
                    <h5 class=" card-subtitle">Tipo: <%:poke.Tipo.ToString() %></h5>
                    <p class=" card-text"><%:poke.Descripcion %></p>
                    <%--<%Session.Add("pokeid", poke.Id); %>--%>
                    <asp:Button ID="btnEditar" CssClass="btn btn-dark" OnClick="btnEditar_Click" runat="server" Text="Button" />
                </div>
            </div>
        </div>
    




    <%} %>
    </div>

</asp:Content>
