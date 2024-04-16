﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="usuario.aspx.cs" Inherits="AteneaWeb1.usuario" %>
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
    <br />
    <div class="div1">
        <br />
        <p class="txt1">¡Bienvenid@ <%= Session["NombreUsuario"] %> a Atenea Motors!</p>
        <br />
        <img class="img2" src="img1/a1.jpg" alt="carAtenea" />
        <br />
        <p class="txt2">Somos una concesionaria de autos que se enorgullece de ofrecer una amplia selección de vehículos de alta calidad a precios competitivos.</p>
        <br />
    </div>
    <div>
        <br />
        <img class="img2" src="img1/a2.jpg" alt="carAtenea" />
        <br />
        <p class="txt2">Desde autos deportivos hasta SUVs familiares, tenemos algo para todos.</p>
        <br />
    </div>
    <div class="div1">
        <br />
        <img class="img2" src="img1/a3.png" alt="carAtenea" />
        <br />
        <p class="txt2">Nuestro equipo de expertos en ventas está aquí para ayudarlo a encontrar el automóvil de sus sueños.</p>
        <br />
    </div>
    <br />
    <img class="img3" src="img1/OIG3.png" alt="carAtenea" />
    <p class="txt3">¡Visítenos hoy y experimente la diferencia de Atenea Motors!</p>
    <br />
</asp:Content>
