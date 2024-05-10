<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Miperfil.aspx.cs" Inherits="Pokedex_web.Miperfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />
    
    <h1>Mi perfil</h1>
    
            <div class="row">
                <div class="col-4">
                    <div class="mb-3">
                        <asp:Label ID="lblemail" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="txbEmail" CssClass=" form form-control" runat="server" TextMode="Email"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="lblnombre" runat="server" Text="Nombre"></asp:Label>
                        <asp:TextBox ID="txbNombre" CssClass=" form form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="lblapellido" runat="server" Text="Apellido"></asp:Label>
                        <asp:TextBox ID="txbApellido" CssClass=" form form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="lblfechanacimiento" runat="server" Text="Fecha de Nacimiento"></asp:Label>
                        <asp:TextBox ID="txbFechanacimiento" CssClass=" form form-control" runat="server" TextMode="Date"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="mb-3">
                        <asp:Label ID="lblimagen" runat="server" Text="Imagen"></asp:Label>
                        <input type="file" id="txtImg" runat="server" class="form-control"  />
                    </div>
                    <div class="mb-3">
                        <asp:Image ID="imgPerfil" ImageUrl="https://static.vecteezy.com/system/resources/thumbnails/004/511/281/small_2x/default-avatar-photo-placeholder-profile-picture-vector.jpg" CssClass="img-fluid mb-3" runat="server" />
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-3">
                    <asp:Button ID="btnGuardar" OnClick="btnGuardar_Click" CssClass="btn btn-primary" runat="server" Text="Guardar" />
                    <a href="Default.aspx">Salir</a>
                </div>
            </div>
</asp:Content>
