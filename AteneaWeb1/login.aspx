﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="AteneaWeb1.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="tlt1">Iniciar sesion</p>
    <br />
    <br />
    <div class="divL1">
        <div class="divL2">
            <asp:Label CssClass="lbl1" Text="Usuario:" runat="server" Style="margin-right: 38px;"/>
            <asp:TextBox CssClass="txtb1" runat="server" />
            <br />
            <br />
            <br />
            <asp:Label CssClass="lbl1" Text="Contraseña:" runat="server"/>
            <asp:TextBox Type="password" CssClass="txtb1" runat="server" />
            <br />
            <br />
            <br />
            <asp:Button CssClass="btnL1" Text="Ingresar" runat="server" ID="btnL1" OnClick="btnL1_Click"/>
            <br />
            <asp:Button CssClass="btnL2" Text="Registrarme" runat="server" ID="btnR1" OnClick="btnR1_Click"/>
        </div>
    </div>
</asp:Content>