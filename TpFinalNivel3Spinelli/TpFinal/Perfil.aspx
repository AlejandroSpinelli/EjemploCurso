<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="TpFinal.Perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
                <asp:Label ID="lblNombre" CssClass="fuente" runat="server" Text="Nombre"></asp:Label>
                <asp:TextBox ID="txbNombre" CssClass="form form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblApellido" CssClass="fuente" runat="server" Text="Apellido"></asp:Label>
                <asp:TextBox ID="txbApellido" CssClass="form form-control" runat="server"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="lblImagen" CssClass="fuente" runat="server" Text="Imágen"></asp:Label>
                <input type="file" id="txtImagen" runat="server" class="form-control" />
            </div>

        </div>
        <div class="col-4">
            <div class="mb-3">
                <asp:Image ID="imgPerfil" CssClass="imagen img-fluid" ImageUrl="https://st3.depositphotos.com/6672868/13701/v/450/depositphotos_137014128-stock-illustration-user-profile-icon.jpg" runat="server" />
            </div>
        </div>
        <div class="col-2"></div>
    </div>


    <div class="row">
        <div class="col-2"></div>
        <div class="col-4">
            <div class="mb-3">
                <asp:Button ID="btnGuardar" CssClass="btn btn-primary" OnClick="btnGuardar_Click" runat="server" Text="Guardar" />
                <a href="Default.aspx">Cancelar</a>
            </div>
        </div>
    </div>
</asp:Content>
