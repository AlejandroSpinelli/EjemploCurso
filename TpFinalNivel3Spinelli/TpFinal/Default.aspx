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

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
                <div class="row">
        <div class="col-2"></div>
        <div class="col-4">
            <div class="mb-3">
                <asp:Label ID="lblFiltroRapido" CssClass="fuente" runat="server" Text="Filtro rápido"></asp:Label>
                <asp:TextBox ID="txbFiltroRapido" CssClass="form form-control" OnTextChanged="txbFiltroRapido_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>
                <asp:CheckBox ID="chbFiltroAvanzado" CssClass="form" Text="Activar filtro Avanzado" OnCheckedChanged="chbFiltroAvanzado_CheckedChanged" AutoPostBack="true" runat="server" />
            </div>
        </div>
    </div>
    <%if (activarfiltro)
        {  %>

    <div class="row">
        <div class="col-2"></div>
        <div class="col-2">
            <div class="mb-3">
                <asp:Label ID="lblCampo" runat="server" Text="Campo"></asp:Label>
                <asp:DropDownList ID="ddlCampo" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlCampo_SelectedIndexChanged" runat="server">
                    <asp:ListItem Text="Nombre" />
                    <asp:ListItem Text="Marca" />
                    <asp:ListItem Text="Categoria" />
                    <asp:ListItem Text="Precio" />
                    <asp:ListItem Text="Descripcion" />
                    <asp:ListItem Text="Codigo" />
                </asp:DropDownList>
            </div>
        </div>
        <div class="col-2">
            <div class="mb-3">
                <asp:Label runat="server" Text="Criterio"></asp:Label>
                <asp:DropDownList CssClass="form-control" ID="ddlCriterio" AutoPostBack="true" runat="server"></asp:DropDownList>
            </div>

        </div>
        <div class="col-2">
            <div class="mb-3">
                <asp:Label runat="server" Text="Filtro"></asp:Label>
                <asp:TextBox CssClass="form-control" ID="txbFiltro" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="col-2">
            <br />
            <asp:Button ID="btnFiltrar" CssClass="btn btn-primary" OnClick="btnFiltrar_Click" runat="server" Text="Filtrar" />
        </div>
    </div>
    <%} %>

    <asp:Repeater runat="server" ID="repRepeater">
        <ItemTemplate>
            <div class="card" style="width: 18rem;">
                <img src="<%#Eval("UrlImagen") %>" class="card-img-top imagen" id="imagencita" alt="<%#Eval("Nombre")%>" onerror="this.onerror=null;this.src='https://png.pngtree.com/png-vector/20191026/ourmid/pngtree-shopping-basket-icon-png-image_1871519.jpg';" />
                <div class="card-body">
                    <h5 class="card-title"><%#Eval("Nombre") %></h5>
                    <p class="card-text">$<%#Eval("Precio") %></p>
                    <asp:Button ID="btnDetalles" class="btn btn-primary" OnClick="btnDetalles_Click" CommandArgument='<%#Eval("Id")%>' CommandName="ArticuloId" runat="server" Text="Detalles" />
                    <%if (mostrar)
                        {  %>
                    <asp:Button ID="btnFav" OnClick="btnFav_Click" CommandArgument='<%#Eval("Id")%>' runat="server" Text="Agregar &#9733;" CssClass="btn btn-warning" />
                    <%} %>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
        </ContentTemplate>
    </asp:UpdatePanel>


</asp:Content>
