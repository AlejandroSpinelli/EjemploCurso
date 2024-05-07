<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Pokedex_web.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <hr />
            <h1>Registrate como Trainee</h1>
            <div class="row col-6">
                <div class="mb-3">
                    <asp:Label ID="lblUser" runat="server" Text="Usuario"></asp:Label>
                    <asp:TextBox ID="txbUser" runat="server" CssClass="form form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblPass" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox ID="txbPass" TextMode="Password" runat="server" CssClass="form form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Button ID="btnregistrarse" runat="server" CssClass="btn btn-primary" Text="Registrarse" />
                    <a href="Default.aspx">Cancelar</a>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
