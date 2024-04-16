<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="PanelNotificaciones.aspx.cs" Inherits="AteneaWeb1.PanelNotificaciones" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
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
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</asp:Content>
