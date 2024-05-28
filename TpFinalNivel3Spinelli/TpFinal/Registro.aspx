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
    </style>
    <style>
        .imagen {
            max-height: 409px;
        }
    </style>
    <hr />



    <div class="row">
        <div class="col-2"></div>
        <div class="col-4">
            <div class="mb-3">
                <asp:Label ID="lblEmail" CssClass="fuente" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="txbEmail" CssClass="form form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblPass" CssClass="fuente" runat="server" Text="Pass"></asp:Label>
                <asp:TextBox ID="txbPass" CssClass="form form-control" runat="server"></asp:TextBox>
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
