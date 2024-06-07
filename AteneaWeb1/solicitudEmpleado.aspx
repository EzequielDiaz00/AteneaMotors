<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="solicitudEmpleado.aspx.cs" Inherits="AteneaWeb1.solicitudEmpleado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="tlt1">Solicitud de Empleo</p>
    <br />
    <div class="divL1">
        <div class="divL2">
            <asp:Label CssClass="lbl1" Text="Nombre:" runat="server" Style="margin-right: 30px;" />
            <asp:TextBox CssClass="txtb1" runat="server" ID="txtNombre" />
            <br />
            <br />
            <br />
            <asp:Label CssClass="lbl1" Text="Correo:" runat="server" Style="margin-right: 46px;" />
            <asp:TextBox CssClass="txtb1" runat="server" ID="txtEmail" />
            <br />
            <br />
            <br />
            <asp:Label CssClass="lbl1" Text="Teléfono:" runat="server" Style="margin-right: 26px;" />
            <asp:TextBox CssClass="txtb1" runat="server" ID="txtTelefono" />
            <br />
            <br />
            <br />
            <asp:Label CssClass="lbl1" Text="Dirección:" runat="server" Style="margin-right: 20px;" />
            <asp:TextBox CssClass="txtb1" runat="server" ID="txtDireccion" />
            <br />
            <br />
            <br />
            <asp:Label CssClass="lbl1" Text="Experiencia:" runat="server" Style="margin-right: 4px;" />
            <asp:TextBox CssClass="txtb1" runat="server" ID="txtExperiencia" TextMode="MultiLine" Rows="4" Columns="30" />
            <br />
            <br />
            <br />
            <asp:Button CssClass="btnL2" Text="Enviar Solicitud" runat="server" ID="btnEnviarSolicitud" OnClick="btnEnviarSolicitud_Click" />
        </div>
    </div>
</asp:Content>
