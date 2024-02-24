<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="IngresarProducto.aspx.cs" Inherits="AteneaWeb1.IngresarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Ingrese los detalles del producto</h2>
        <div>
            <label>Nombre del producto:</label>
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </div>
        <div>
            <label>Descripción:</label>
            <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
        </div>
        <div>
            <label>Año:</label>
            <asp:TextBox ID="txtAnio" runat="server"></asp:TextBox>
        </div>
        <div>
            <label>Color:</label>
            <asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
        </div>
        <div>
            <label>Imagen (URL):</label>
            <asp:TextBox ID="txtImagen" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnAgregar" Text="Agregar Producto" OnClick="btnAgregar_Click" runat="server" />
    </div>
</asp:Content>
