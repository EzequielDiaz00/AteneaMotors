<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="usuario.aspx.cs" Inherits="AteneaWeb1.usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <img class="img1" width="30%" src="img1/OIG1.png" alt="logo" />
    <br />
    <div class="div1">
        
        <br />
        <p class="txt1">¡Bienvenid@ <%= Session["NombreUsuario"] %> a Atenea Motors!</p>
        <br />
        <p class="txt2">Descubre una experiencia excepcional en la compra de automóviles. 
            En Atenea Motors, ofrecemos una amplia selección de vehículos nuevos y usados de las mejores marcas. 
            Desde sedanes elegantes hasta SUV espaciosos y emocionantes vehículos deportivos, tenemos la opción perfecta para ti. 
            Nuestro equipo experto está aquí para guiarte a través de nuestro inventario y brindarte un servicio excepcional. 
            Además, nuestro departamento de servicio técnico se encargará de mantener tu automóvil en óptimas condiciones. 
            Explora nuestro sitio web para conocer más sobre nuestros vehículos y servicios. ¡Estamos aquí para ayudarte en cada paso del camino!</p>
        <br />
    </div>
</asp:Content>
