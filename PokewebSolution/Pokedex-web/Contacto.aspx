<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contacto.aspx.cs" Inherits="Pokedex_web.Contacto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="container row col-5">
                <div class="col-6">
                    <asp:Label ID="lblMail" runat="server" Text="Mail"></asp:Label>
                </div>
                <div class="mb-3">
                    <asp:TextBox ID="txbMail" CssClass="form form-control" runat="server" TextMode="Email"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblAsunto" runat="server" Text="Asunto"></asp:Label>
                </div>
                <div class="mb-3">
                    <asp:TextBox ID="txbAsunto" CssClass="form form-control" runat="server"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <asp:Label ID="lblMensaje" runat="server" Text="Mensaje"></asp:Label>
                </div>
                <div class="mb-3">
                    <asp:TextBox ID="txbMensaje" CssClass="from form-control" TextMode="MultiLine"  runat="server"></asp:TextBox>
                </div>
                <br />
                <div class="col-2">
                    <asp:Button ID="btnEnviar" CssClass="btn btn-primary" OnClick="btnEnviar_Click" runat="server" Text="Enviar" />
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
