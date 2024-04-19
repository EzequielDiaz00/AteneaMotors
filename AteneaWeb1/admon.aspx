<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="admon.aspx.cs" Inherits="AteneaWeb1.admon" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="tltA">Pagina de Gestion y Administracion de AteneaMotors</p>
    <br />
    <br />
    <div class="divA1">
        <div class="divA2">
            <asp:Button CssClass="btnA1" Text="Proveedores" runat="server" OnClick="Proveedores_Click"/>
            <asp:Button CssClass="btnA1" Text="Ingresar Autos" runat="server" OnClick="Ingresar_Click"/>
            <br />
            <br />
            <asp:Button CssClass="btnA1" Text="Revisar Cotizaciones" runat="server" OnClick="RevisarCot_Click"/>
            <asp:Button CssClass="btnA1" Text="Revisar Pruebas de Manejo" runat="server" OnClick="RevisarPM_Click"/>
            <br />
            <br />
            <asp:Button CssClass="btnA2" Text="Cerrar Sesion" runat="server" OnClick="cerrarSS_Click"/>
        </div>
    </div>
</asp:Content>
