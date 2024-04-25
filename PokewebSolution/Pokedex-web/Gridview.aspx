<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Gridview.aspx.cs" Inherits="Pokedex_web.Gridview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="dgvPokemon" DataKeyNames="Id" runat="server" OnSelectedIndexChanged="dgvPokemon_SelectedIndexChanged" 
        CssClass="table table-dark" AutoGenerateColumns="false"  
        AllowPaging="true" PageSize="5" OnPageIndexChanging="dgvPokemon_PageIndexChanging">
        <Columns>
            <asp:BoundField HeaderText="nombre" DataField="nombre" />
            <asp:BoundField HeaderText="numero" DataField="numero" />
            <asp:BoundField HeaderText="tipo" DataField="tipo.descripcion" />
            <asp:CommandField ShowSelectButton="true" HeaderText="Accion" SelectText="Editar" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="btnAgregar" CssClass="btn btn-dark" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
</asp:Content>
