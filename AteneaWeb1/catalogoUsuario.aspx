<%@ Page Title="" Language="C#" MasterPageFile="~/Master3.Master" AutoEventWireup="true" CodeBehind="catalogoUsuario.aspx.cs" Inherits="AteneaWeb1.catalogoUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="divc1">
        <div class="divc2">
            <img class="img1" width="100%" src="img1/OIG1.png" alt="logo" />
        </div>
        <h2 class="titcat" style="">Catálogo de Productos</h2>
        <div class="divc3">
            <asp:Label Style="float: right; margin-right: 10%;" Class="filt1" Text="Filtros" runat="server" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button Style="float: right;" Class="btnc1" Text="Filtrar" runat="server" OnClick="btnFiltrar_Click" />
            <asp:Button Style="float: right;" Class="btnc1" ID="btnReset" runat="server" Text="Limpiar" OnClick="btnReset_Click" />
            <div style="float: right; margin-right: 20px;">
                <asp:Label Style="margin-left: 10px;" Class="filt2" Text="Tipo" runat="server" />
                <asp:RadioButtonList ID="rbTipo" runat="server">
                    <asp:ListItem Class="filt3" Id="car1" Value="PickUp" Text="PickUp" runat="server" />
                    <asp:ListItem Class="filt3" Id="car2" Value="Sedan" Text="Sedan" runat="server" />
                    <asp:ListItem Class="filt3" Id="car3" Value="Camioneta" Text="Camioneta" runat="server" />
                    <asp:ListItem Class="filt3" Id="car4" Value="Microbus" Text="Microbus" runat="server" />
                </asp:RadioButtonList>
            </div>
            <div style="float: right; margin-right: 20px;">
                <asp:Label Style="margin-left: 10px;" Class="filt2" Text="Año" runat="server" />
                <asp:RadioButtonList ID="rbAnio" runat="server">
                    <asp:ListItem Class="filt3" Id="an1" Value="2024" Text="2024" runat="server" />
                    <asp:ListItem Class="filt3" Id="an2" Value="2023" Text="2023" runat="server" />
                    <asp:ListItem Class="filt3" Id="an3" Value="2022" Text="2022" runat="server" />
                    <asp:ListItem Class="filt3" Id="an4" Value="2021" Text="2021" runat="server" />
                </asp:RadioButtonList>
            </div>
            <div style="float: right; margin-right: 20px;">
                <asp:Label Style="margin-left: 10px;" Class="filt2" Text="Marca" runat="server" />
                <asp:RadioButtonList ID="rbMarca" runat="server">
                    <asp:ListItem Class="filt3" Id="col1" Value="Toyota" Text="Toyota" runat="server" />
                    <asp:ListItem Class="filt3" Id="col2" Value="Ford" Text="Ford" runat="server" />
                    <asp:ListItem Class="filt3" Id="col3" Value="Mazda" Text="Mazda" runat="server" />
                    <asp:ListItem Class="filt3" Id="col4" Value="Chevrolet" Text="Chevrolet" runat="server" />
                </asp:RadioButtonList>
            </div>

        </div>
    </div>
    <hr />
    <div>
        <asp:Repeater ID="rptProductos" runat="server">
            <ItemTemplate>
                <div class="divcat1">
                    <div class="divcat2">
                        <h3 class="txtcat1"><%# Eval("Nombre") %></h3>
                        <p class="txtcat2"><%# Eval("Descripcion") %></p>
                        <p class="txtcat2">Año: <%# Eval("Anio") %></p>
                        <p class="txtcat2">Color: <%# Eval("Color") %></p>
                        <br />
                        <a class="btnc2" href="pruebaUsuario.aspx">Solicitar prueba de manejo</a>
                        <br />
                        <!-- Botón para redirigir a vistaUsuario -->
                        <asp:Button runat="server" Text="Añadir reseña" CssClass="btnc2" OnClick="btnAgregarReseña_Click" CommandArgument='<%# Eval("ID") %>' />
                        <br />
                        <br />
                    </div>
                    <div class="divcat3">
                        <img class="imgcat1" style="width: 100%;" src='<%# Eval("ImagenUrl") %>' alt='<%# Eval("Nombre") %>' />
                    </div>
                </div>
                <hr />
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
