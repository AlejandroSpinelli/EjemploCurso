<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administracion.aspx.cs" Inherits="TpFinal.Administracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <asp:ScriptManager runat="server" />
            <hr />
            <div class="row">
                <div class="col-2"></div>
                <div class="col-8">
                    <div class="mb-3">
                        <h2>Administracion de productos</h2>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-2"></div>
                <div class="col-4">
                    <div class="mb-3">
                        <asp:Label ID="lblFiltroRapido" CssClass="fuente" runat="server" Text="Filtro Rapido"></asp:Label>
                        <asp:TextBox ID="txbFiltroRapido" CssClass="form form-control" OnTextChanged="txbFiltroRapido_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>
                        <asp:CheckBox ID="chbFiltroAvanzado" CssClass="form" Text="Activar filtro Avanzado" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="true" runat="server" />
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
                        <asp:DropDownList ID="ddlCampo" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" runat="server">
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



            <div class="row">
                <div class="col-2"></div>
                <div class="col-8">
                    <div class="mb-3">
                        <asp:GridView ID="dgvAdministracion" DataKeyNames="id" CssClass="table table-dark" runat="server"
                            AutoGenerateColumns="false" OnSelectedIndexChanged="dgvAdministracion_SelectedIndexChanged"
                            AllowPaging="true" PageSize="5" OnPageIndexChanging="dgvAdministracion_PageIndexChanging">
                            <Columns>
                                <asp:BoundField HeaderText="Codigo" DataField="Codigo" />
                                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                                <asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />
                                <asp:BoundField HeaderText="Categoria" DataField="categoria.Descripcion" />
                                <asp:BoundField HeaderText="Precio" DataField="Precio" />
                                <asp:BoundField HeaderText="" DataField="" />
                                <asp:CommandField ShowSelectButton="true" HeaderText="Editar" SelectText="Editar" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>

            <div class="row">
                <div class="col-2"></div>
                <div class="col-4">
                    <div class="mb-2">
                        <asp:Button ID="btnAgregar" CssClass="btn btn-primary" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
                        <a href="Default.aspx">Cancelar</a>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
