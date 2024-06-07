<%@ Page Title="" Language="C#" MasterPageFile="~/Master3.Master" AutoEventWireup="true" CodeBehind="vistaAuto.aspx.cs" Inherits="AteneaWeb1.vistaAuto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="divR1">
        <h3 class="tlt1">Dejar una reseña</h3>
        <br />
        <div class="divR2">
            <asp:TextBox ID="txtReseña" runat="server" TextMode="MultiLine" CssClass="txtBoxReview" placeholder="Escribe tu reseña aquí"></asp:TextBox>
            <br />
            <asp:DropDownList ID="ddlCalificación" Style="font-size: 20px;" runat="server">
                <asp:ListItem Text="1 estrella" Value="1"></asp:ListItem>
                <asp:ListItem Text="2 estrellas" Value="2"></asp:ListItem>
                <asp:ListItem Text="3 estrellas" Value="3"></asp:ListItem>
                <asp:ListItem Text="4 estrellas" Value="4"></asp:ListItem>
                <asp:ListItem Text="5 estrellas" Value="5"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnEnviarReseña" runat="server" Text="Enviar reseña" CssClass="btnEnviarReseña" OnClick="btnEnviarReseña_Click" />
        </div>
    </div>
</asp:Content>
