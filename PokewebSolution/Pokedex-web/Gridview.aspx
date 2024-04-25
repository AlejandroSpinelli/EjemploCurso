<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Gridview.aspx.cs" Inherits="Pokedex_web.Gridview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:GridView ID="dgvPokemon" DataKeyNames="nombre" runat="server" OnSelectedIndexChanged="dgvPokemon_SelectedIndexChanged" CssClass="table table-dark" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="nombre" DataField="nombre" />
            <asp:BoundField HeaderText="tipo" DataField="tipo.descripcion" />
            <asp:BoundField HeaderText="debilidad" DataField="debilidad.descripcion" />
            <asp:CommandField ShowSelectButton="true" HeaderText="Accion" SelectText="Seleccionar" />
        </Columns>
    </asp:GridView>
</asp:Content>
