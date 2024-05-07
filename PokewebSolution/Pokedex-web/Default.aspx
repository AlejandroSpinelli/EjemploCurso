<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Pokedex_web.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />    
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <h1>Login</h1>
            <div class="row">
                <div class="col-3">
                    <asp:Label ID="lblUser" runat="server" Text="User"></asp:Label>
                    <asp:TextBox ID="txbbuser" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-3">
                    <asp:Label ID="lblPass" runat="server" Text="Pass"></asp:Label>
                    <asp:TextBox ID="txbPass" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-3">
                    <br />
                    <asp:CheckBox ID="chbpass" CssClass="form-check-input" AutoPostBack="true" OnCheckedChanged="chbpass_CheckedChanged" Text="Mostrar contraseña" runat="server" />
                </div>
            </div>
            <br />
            <div class="row col-2">
                <asp:Button ID="btnIngresar" CssClass="btn btn-primary" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
