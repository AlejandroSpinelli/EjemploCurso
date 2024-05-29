<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TpFinal.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />
    <hr />
    <style>
        .card {
            display: inline-block;
            margin: 10px;
        }

        .favorito {
            height: 40px;
            width: 35px;
        }

        .imagen {
            max-height: 300px;
        }
    </style>

    <asp:Repeater runat="server" ID="repRepeater">
        <ItemTemplate>
            <div class="card" style="width: 18rem;">
                <img src="<%#Eval("UrlImagen") %>" class="card-img-top imagen" id="imagencita" alt="<%#Eval("Nombre")%>" onerror="this.onerror=null;this.src='https://png.pngtree.com/png-vector/20191026/ourmid/pngtree-shopping-basket-icon-png-image_1871519.jpg';" />
                <div class="card-body">
                    <h5 class="card-title"><%#Eval("Nombre") %></h5>
                    <p class="card-text"><%#Eval("Descripcion") %></p>
                    <asp:Button ID="btnDetalles" class="btn btn-primary" OnClick="btnDetalles_Click" CommandArgument='<%#Eval("Id")%>' CommandName="ArticuloId" runat="server" Text="Detalles" />
                    <%if (mostrar)
                        {  %>
                    <asp:Button ID="btnFav" OnClick="btnFav_Click" CommandArgument='<%#Eval("Id")%>' runat="server" Text="Agregar &#9733;" CssClass="btn btn-warning" />
                    <%} %>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>


</asp:Content>
