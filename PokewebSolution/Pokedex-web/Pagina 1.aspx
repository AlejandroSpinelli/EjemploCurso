<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pagina 1.aspx.cs" Inherits="Pokedex_web.Pagina_1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />
    <h1>Bienvenido , te logueaste</h1>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <%if (Session["Usuario"] != null && ((dominio.Usuario)Session["Usuario"]).TipoUsuario == dominio.TipoUsuario.ADMIN)
                {  %>
            <asp:Label ID="lblPagina1" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="btnPagina1" CssClass="btn btn-primary" runat="server" Text="Pagina 1" />
            <%} %>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
