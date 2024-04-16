<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="usuario.aspx.cs" Inherits="AteneaWeb1.usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <style>
        .notification-icon {
            position: relative;
            display: inline-block;
            cursor: pointer;
        }

        .notification-icon .badge {
            position: absolute;
            top: -10px;
            right: -10px;
            background-color: red;
            color: white;
            border-radius: 50%;
            padding: 8px;
            font-size: 16px;
        }

        .notification-icon .notification-dropdown {
            display: none;
            position: absolute;
            top: 30px;
            right: 0;
            background-color: #f9f9f9;
            min-width: 160px;
            box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
            z-index: 1;
            padding: 10px;
        }

        .notification-icon .notification-dropdown a {
            display: block;
            padding: 10px 0;
            text-decoration: none;
            color: black;
        }

        .notification-icon .notification-dropdown a:hover {
            background-color: #f1f1f1;
        }

        .notification-label {
            font-size: 24px;
            margin-left: 5px;
            vertical-align: middle;
            color: white;
            font-weight: bold;
            font-family: Arial, sans-serif;
        }
    </style>
    <script>
        $(document).ready(function () {
            $('.notification-icon').click(function () {
                $('.notification-dropdown').toggle();
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="notification-icon">
        <img class="img1" style="width: 50px;" src="img1/OIG1.png" alt="logo" />
        <span class="badge">3</span>
        <span class="notification-label">Notificaciones</span>
        <div class="notification-dropdown">
            <a href="#">Notificación 1</a>
            <a href="#">Notificación 2</a>
            <a href="#">Notificación 3</a>
        </div>
    </div>
    <img class="img1" width="30%" src="img1/OIG1.png" alt="logo" />
    <br />
    <div class="div1">
        <br />
        <p class="txt1">¡Bienvenido a Atenea Motors! </p>
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
