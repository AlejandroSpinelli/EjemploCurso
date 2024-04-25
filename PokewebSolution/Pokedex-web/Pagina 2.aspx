<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pagina 2.aspx.cs" Inherits="Pokedex_web.Pagina_2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div cssclass="container">

        <div class="mb-3 col-3">
            <label for="exampleFormControlInput1" class="form-label">Id</label>
            <input type="email" class="form-control" id="pokeid" placeholder="">
        </div>
        <div class="mb-3 col-3">
            <label for="exampleFormControlInput1" class="form-label">Nombre</label>
            <input type="email" class="form-control" id="pokenombre" placeholder="">
        </div>
        <div class="mb-3 col-3">
            <label for="exampleFormControlInput1" class="form-label">Numero</label>
            <input type="email" class="form-control" id="pokenumero" placeholder="">
        </div>
        <div class="mb-3 col-3">
            <label for="exampleFormControlTextarea1" class="form-label">Descripcion</label>
            <textarea class="form-control" id="pokedescripcion" rows="3"></textarea>
        </div>
        <div class="mb-3 col-3">
            <label for="exampleFormControlInput1" class="form-label">Url Imagen</label>
            <input type="email" class="form-control" id="pokeurl" placeholder="">
        </div>
        <div class="mb-3 col-3">
            <label for="exampleFormControlInput1" class="form-label">Tipo</label>
            <asp:DropDownList ID="poketipo" runat="server" CssClass=" form-select"></asp:DropDownList>
        </div>
        <asp:Button ID="Button1" runat="server" CssClass="btn btn-dark" Text="Aceptar" />

    </div>

</asp:Content>
