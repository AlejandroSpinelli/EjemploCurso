<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="TpFinal.Error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .color {
            color: red;
        }
    </style>


    <hr />

    <div class="row">
        <div class="col-2"></div>
        <div class="col-4">
            <div class="mb-3">
                <h2>
                    <asp:Label ID="lblError" CssClass="color" runat="server" Text="Error"></asp:Label>

                </h2>

            </div>
        </div>
        <div class="row">
            <div class="col-2"></div>
            <div class="col-4">
                <div class="mb-3">
                    <%if (reintentar)
                        { %>
                    <asp:Button ID="btnReintentar" CssClass="btn btn-primary" OnClick="btnReintentar_Click" runat="server" Text="Ingresar" />
                    <a href="Default.aspx">Cancelar</a>
                    <%} %>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
