<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Gridview.aspx.cs" Inherits="Pokedex_web.Gridview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />
    <h1 class="text-bg-dark">Grid View Pokemons</h1>

    <hr />

    <div class="row">
        <div class="col-6">
            <asp:Label ID="lblFiltro" runat="server" Text="Filtro Rapido"></asp:Label>
            <asp:TextBox ID="txbFiltroRapido" CssClass="form-control" runat="server" AutoPostBack="true" OnTextChanged="txbFiltroRapido_TextChanged"></asp:TextBox>
            <asp:CheckBox ID="chbFiltrorapido" AutoPostBack="true" OnCheckedChanged="CheckBox1_CheckedChanged" runat="server" Text="Habilitar filtro avanzado" />
        </div>
    </div>

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="row">

                <%if (habilitarfiltrorapido)
                    {%>

                <div class="col-3">
                    <asp:Label runat="server" Text="Campo"></asp:Label>
                    <asp:DropDownList CssClass="form-control" OnSelectedIndexChanged="ddlCampo_SelectedIndexChanged" AutoPostBack="true" ID="ddlCampo" runat="server">
                        <asp:ListItem Text="Nombre" />
                        <asp:ListItem Text="Número" />
                        <asp:ListItem Text="Tipo" />
                    </asp:DropDownList>


                </div>

                <div class="col-3">
                    <asp:Label runat="server" Text="Criterio"></asp:Label>
                    <asp:DropDownList CssClass="form-control" ID="ddlCriterio" AutoPostBack="true" runat="server"></asp:DropDownList>
                </div>

                <div class="col-3">
                    <asp:Label runat="server" Text="Filtro"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txbFiltro" runat="server"></asp:TextBox>
                </div>

                <div class="col-3">
                    <asp:Label runat="server" Text="Estado"></asp:Label>
                    <asp:DropDownList ID="ddlEstado" CssClass="form-control" runat="server">
                        <asp:ListItem Text="Activo" />
                        <asp:ListItem Text="Inactivo" />
                        <asp:ListItem Text="Todos" />

                    </asp:DropDownList>
                </div>
                <div class="col-2">
                    <asp:Button ID="btnFiltrar" runat="server" CssClass="btn btn-primary" Text="Filtrar" OnClick="btnFiltrar_Click" />
                </div>
                <%} %>
            </div>

        </ContentTemplate>
    </asp:UpdatePanel>

    <hr />

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:GridView ID="dgvPokemon" DataKeyNames="Id" runat="server" OnSelectedIndexChanged="dgvPokemon_SelectedIndexChanged"
                CssClass="table table-dark" AutoGenerateColumns="false"
                AllowPaging="true" PageSize="5" OnPageIndexChanging="dgvPokemon_PageIndexChanging">
                <Columns>
                    <asp:BoundField HeaderText="nombre" DataField="nombre" />
                    <asp:BoundField HeaderText="numero" DataField="numero" />
                    <asp:BoundField HeaderText="tipo" DataField="tipo.descripcion" />
                    <asp:CommandField ShowSelectButton="true" HeaderText="Editar" SelectText="Editar" />
                    <asp:CheckBoxField HeaderText="Activo" DataField="Activo" />
                </Columns>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>

    <asp:Button ID="btnAgregar" CssClass="btn btn-dark" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
</asp:Content>
