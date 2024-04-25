<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Repeater.aspx.cs" Inherits="Pokedex_web.Repeater" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="repRepeater" runat="server">
        <ItemTemplate>
            <div class="row row-cols-1 row-cols-md-3 g-4">
                <div class="col">
                    <div class="card">
                        <img src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="<%#Eval("Nombre") %>">
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("Nombre") %></h5>
                            <p class="card-text"><%#Eval("Descripcion") %></p>
                            <asp:Button ID="btnEnviar" CssClass="btn btn-dark" runat="server" Text="enviar" CommandArgument='<%#Eval("Nombre") %>' CommandName="Pokenombre" OnClick="Button1_Click" />
                        </div>
                    </div>
                </div>
                </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
