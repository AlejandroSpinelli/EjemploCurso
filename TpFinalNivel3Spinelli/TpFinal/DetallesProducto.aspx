<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetallesProducto.aspx.cs" Inherits="TpFinal.DetallesProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .imagen {
            max-height: 500px;
        }
    </style>


    <h2>Detalles del producto:</h2>

    <div class="row">
        <div class="col-2"></div>
        <div class="col-4">
            <div class="mb-3">
                <asp:Label ID="lblCodigo" runat="server" Text="Código"></asp:Label>
                <asp:TextBox ID="txbCodigo" CssClass="form form-control" Enabled="false" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txbNombre" CssClass="form form-control" Enabled="false" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblPrecio" runat="server" Text="Precio"></asp:Label>
                <asp:TextBox ID="txbPrecio" CssClass="form form-control" Enabled="false" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblMarca" runat="server" Text="Marca"></asp:Label>
                <asp:TextBox ID="txbMarca" CssClass="form form-control" Enabled="false" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblCategoria" runat="server" Text="Categoria"></asp:Label>
                <asp:TextBox ID="txbCategoria" CssClass="form form-control" Enabled="false" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="Descripcion" runat="server" Text="Descripción"></asp:Label>
                <asp:TextBox ID="txbDescripcion" Rows="3" TextMode="MultiLine" CssClass="form form-control" Enabled="false" runat="server"></asp:TextBox>
            </div>

        </div>
        <div class="col-4">
            <div class="mb-3">
                <asp:Label ID="lblImagen" runat="server" Text="Imagen"></asp:Label>
                <img src="#" runat="server" class="imagen" id="imagencita" alt="Alternate Text" onerror="this.onerror=null;this.src='https://png.pngtree.com/png-vector/20191026/ourmid/pngtree-shopping-basket-icon-png-image_1871519.jpg';" />
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-2"></div>
        <div class="col-4">
            <div class="mb-3">
                <asp:Button ID="btnRegresar" CssClass="btn btn-dark" OnClick="btnRegresar_Click" runat="server" Text="Regresar" />
            </div>
        </div>
    </div>

</asp:Content>
