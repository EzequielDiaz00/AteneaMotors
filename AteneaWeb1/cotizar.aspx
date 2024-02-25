<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="cotizar.aspx.cs" Inherits="AteneaWeb1.cotizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <style>
    /* Estilos para los elementos */
    body {
      background-color: #005E54; /* Color de fondo oscuro */
    }

    .container {
      width: 100%;
      max-width: 600px; /* Ancho máximo del formulario */
      margin: 100px auto 0 auto; /* Centrar el formulario verticalmente */
      padding: 20px;
      background-color: #fff; /* Color de fondo del formulario */
      border-radius: 10px; /* Bordes redondeados */
      box-shadow: 0 0 10px rgba(0, 0, 0, 0.5); /* Sombra */
    }

    .form-group {
      margin-bottom: 20px;
      text-align: center; /* Centrar el texto */
    }

    .form-group label {
      font-weight: bold;
      margin-bottom: 5px;
    }

    .form-group input[type="text"],
    .form-group input[type="email"],
    .form-group input[type="password"] {
      padding: 10px;
      border-radius: 5px;
      border: 1px solid #ccc;
      transition: border-color 0.3s ease-in-out;
      width: 100%; /* Ancho completo */
    }

    .form-group input[type="text"]:focus,
    .form-group input[type="email"]:focus,
    .form-group input[type="password"]:focus {
      border-color: #007bff;
      outline: none;
    }

    .btn-container {
      text-align: center; /* Centrar el contenido */
    }

    .btn {
      display: inline-block;
      padding: 10px 90px;
      font-size: 16px;
      text-align: center;
      border-radius: 10px;
      background-color: #b9113f;
      color: #fff;
      border: none;
      cursor: pointer;
      transition: background-color 0.3s ease-in-out;
    }

    .btn:hover {
      background-color: #E1523D;
    }

    /* Estilos para el título */
    #titulo {
      color: #b9113f; /* Color del botón */
      font-size: 36px; /* Tamaño del texto */
      font-weight: bold; /* Negrita */
      text-align: center; /* Centrar el título */
    }
  </style>

  <div class="container">
    <h1 id="titulo">ATENEA</h1>

    <div class="form-group">
      <label for="txtNombre">Nombre</label>
      <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Width="430px"></asp:TextBox>
    </div>

    <div class="form-group">
      <label for="txtApellido">Apellido</label>
      <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" Width="430px"></asp:TextBox>
    </div>

    <div class="form-group">
      <label for="txtEmail">Correo </label>
      &nbsp;<asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Width="430px" type="email"></asp:TextBox>
    </div>

    <div class="form-group">
      <label for="txtTelefono">Teléfono</label>
      <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" Width="430px"></asp:TextBox>
    </div>
</asp:Content>

