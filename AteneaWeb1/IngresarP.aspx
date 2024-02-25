<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="IngresarP.aspx.cs" Inherits="AteneaWeb1.IngresarP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <label>Nombre:</label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        <label>Descripción:</label>
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
        <br />
        <label>Año:</label>
        <asp:TextBox ID="txtAnio" runat="server"></asp:TextBox>
        <br />
        <label>Color:</label>
        <asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
        <br />
        <label>URL de Imagen:</label>
        <asp:TextBox ID="txtImagenUrl" runat="server"></asp:TextBox>
        <br />
        <label>Tipo:</label>
        <asp:TextBox ID="txtTipo" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnAgregarProducto" runat="server" Text="Agregar Producto" OnClick="btnAgregarProducto_Click" />
    </div>
</asp:Content>
