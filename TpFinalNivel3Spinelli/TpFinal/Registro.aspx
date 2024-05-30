<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TpFinal.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Registrate</h2>

    <style>
        .fuente {
            font-size: 22px;
            font-family: Arial;
            font: bolder;
        }

        .imagen {
            max-height: 409px;
        }

        .color {
            color: red;
        }
    </style>

    <hr />



    <div class="row">
        <div class="col-2"></div>
        <div class="col-4">
            <div class="mb-3">
                <asp:Label ID="lblEmail" CssClass="fuente" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="txbEmail" CssClass="form form-control" runat="server"></asp:TextBox>
                <%if (validoUser)
                    {  %>
                <asp:Label ID="lblEmailValido" runat="server" Text="Ingrese un correo valido." CssClass="color"></asp:Label>

                <%}%>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblPass" CssClass="fuente" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="txbPass" CssClass="form form-control" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblPass2" CssClass="fuente" runat="server" Text="Repita el Password"></asp:Label>
                <asp:TextBox ID="txbPass2" CssClass="form form-control" runat="server" TextMode="Password"></asp:TextBox>
                <%if (validoPass)
                    {  %>
                <asp:Label ID="lblCorreoValido" runat="server" Text="Las contraseñas no son iguales" CssClass="color"></asp:Label>
                <%} %>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-2"></div>
        <div class="col-4">
            <div class="mb-3">
                <asp:Button ID="btnRegistrarse" OnClick="btnRegistrarse_Click" CssClass="btn btn-primary" runat="server" Text="Registrarse" />
                <a href="Default.aspx">Cancelar</a>
            </div>
        </div>
    </div>
</asp:Content>
