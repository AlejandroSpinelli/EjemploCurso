<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pagina 2.aspx.cs" Inherits="Pokedex_web.Pagina_2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />

    <div class="row">
        <div class="col-6">

            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                        <label for="exampleFormControlInput1" class="form-label">Id</label>
                        <asp:TextBox ID="pokeid" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="exampleFormControlInput1" class="form-label">Nombre</label>
                        <asp:TextBox ID="pokenombre" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="exampleFormControlInput1" class="form-label">Numero</label>
                        <asp:TextBox ID="pokenumero" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="exampleFormControlTextarea1" class="form-label">Descripcion</label>
                        <asp:TextBox ID="pokedescripcion" Rows="2" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <label for="exampleFormControlInput1" class="form-label">Tipo</label>
                        <asp:DropDownList ID="poketipo" runat="server" CssClass=" form-select"></asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label for="exampleFormControlInput1" class="form-label">Debilidad</label>
                        <asp:DropDownList ID="pokedebilidad" runat="server" CssClass=" form-select"></asp:DropDownList>
                    </div>

                </ContentTemplate>
            </asp:UpdatePanel>

        </div>

        <div class="col-6">
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                        <label for="exampleFormControlInput1" class="form-label">Url Imagen</label>
                        <asp:TextBox ID="pokeurl" CssClass="form-control" OnTextChanged="pokeurl_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>

                    </div>
                    <asp:Image ID="imgPoke" ImageUrl="https://img.freepik.com/vector-gratis/ilustracion-icono-galeria_53876-27002.jpg?size=626&ext=jpg&ga=GA1.1.1687694167.1713916800&semt=ais" Width="60%" runat="server" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

    <div class="row">
        <div class="col-8">
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Button ID="btnAceptar" OnClick="btnAceptar_Click" runat="server" CssClass="btn btn-dark" Text="Aceptar" />
                    <asp:Button ID="btnEliminar" OnClick="btnEliminar_Click" runat="server" CssClass="btn btn-danger" Text="Eliminar" />
                    <%if (Confirmaeliminacion)
                        {%>
                    <asp:CheckBox ID="chbEliminar" Text="Para eliminar tilde el checkbox" runat="server" />
                    <asp:Button ID="btnConfirmaEliminar" runat="server" OnClick="btnConfirmaEliminar_Click" CssClass="btn btn-outline-danger" Text="Eliminar" />
                    <%} %>
                    <asp:Button ID="btnDesactivar" OnClick="btnDesactivar_Click" runat="server" CssClass="btn btn-primary" Text="Desactivar" />
                    <%if (ConfirmaDesactivar)
                        {%>
                        <asp:CheckBox ID="chbDesactivar" Text="Para desactivar tilde el CheckBox" runat="server" />
                        <asp:Button ID="btnConfirmarDesactivar" CssClass="btn btn-warning" OnClick="btnConfirmarDesactivar_Click" runat="server" Text="Desactivar" />
                    <%} %>
                    
                </ContentTemplate>
            </asp:UpdatePanel>

        </div>
    </div>

</asp:Content>
