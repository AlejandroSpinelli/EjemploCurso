<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edicion.aspx.cs" Inherits="TpFinal.Edicion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />

    <style>
        .fuente {
            font-size: 22px;
            font-family: Arial;
            font: bolder;
        }
    </style>
    <style>
        .imagen {
            max-height: 409px;
        }
    </style>
    <hr />



    <div class="row">
        <div class="col-2"></div>
        <div class="col-4">
            <div class="mb-3">
                <asp:Label ID="lblCodigo" CssClass="fuente" runat="server" Text="Código"></asp:Label>
                <asp:TextBox ID="txbCodigo" CssClass="form form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblNombre" CssClass="fuente" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txbNombre" CssClass="form form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblPrecio" CssClass="fuente" runat="server" Text="Precio"></asp:Label>
                <asp:TextBox ID="txbPrecio" CssClass="form form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblDescripcion" CssClass="fuente" runat="server" Text="Descripción"></asp:Label>
                <asp:TextBox ID="txbDescripcion" CssClass="form form-control" Rows="4" TextMode="MultiLine" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblMarca" CssClass="fuente" runat="server" Text="Marca"></asp:Label>
                <asp:DropDownList ID="ddlMarca" CssClass="form form-control" runat="server"></asp:DropDownList>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblCategoria" CssClass="fuente" runat="server" Text="Categoria"></asp:Label>
                <asp:DropDownList ID="ddlCategoria" CssClass="form form-control" runat="server"></asp:DropDownList>
            </div>

        </div>
        <div class="col-4">
            <div class="mb-3">
                <asp:Label ID="lblImagen" CssClass="fuente" runat="server" Text="Imágen"></asp:Label>
                <input type="file" id="txtImagen" runat="server" class="form-control" />


                <br />
                <asp:Image ID="imgArticulo" CssClass="imagen img-fluid" ImageUrl="https://static.vecteezy.com/system/resources/previews/000/628/941/non_2x/shopping-basket-icon-vector.jpg" runat="server" />
            </div>
        </div>
        <div class="col-2"></div>
    </div>


    <div class="row">
        <div class="col-2"></div>
        <div class="col-8">
            <div class="mb-3">
                <asp:Button ID="btnAgregar" OnClick="btnAgregar_Click" CssClass="btn btn-primary" runat="server" Text="Agregar" />
                <a href="Default.aspx">Cancelar</a>
                <%if (mostrarComandos)
                    {  %>
                <asp:Button ID="btnModificar" CssClass="btn btn-warning" OnClick="btnModificar_Click1" runat="server" Text="Modificar" />
                <%} %>
                <%if (mostrarModificar)
                    { %>
                <asp:CheckBox ID="chbmodificar" Text="Marque el Check si quiere modificar" runat="server" />
                <asp:Button ID="btnModificarValidado" CssClass="btn btn-primary" OnClick="btnModificarValidado_Click" runat="server" Text="Modificar" />
                <%}%>
                <%if (mostrarComandos)
                    {  %>
                <asp:Button ID="btnEliminar" OnClick="btnEliminar_Click" CssClass="btn btn-danger" runat="server" Text="Eliminar" />
                <%} %>
                <%if (mostrarEliminar)
                    {  %>
                <asp:CheckBox ID="chbeliminar" Text="Marque el Check para eliminar" runat="server" />
                <asp:Button ID="btnEliminarValidado" OnClick="btnEliminarValidado_Click" CssClass="btn btn-primary" runat="server" Text="Eliminar" />
                <%}%>
            </div>
        </div>
    </div>


</asp:Content>
