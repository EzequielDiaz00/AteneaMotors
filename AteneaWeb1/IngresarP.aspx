<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="IngresarP.aspx.cs" Inherits="AteneaWeb1.IngresarP" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="tltA">Administracion de Vehiculos</p>
    <div class="divA1" style="flex-direction: column; align-items: center;">
        <br />
        <br />
        <div class="divA3" style="font-family: Verdana; font-size: 25px; color: white;">
            <label class="lblAD1">Nombre:</label>
            <asp:TextBox CssClass="txtAD1" ID="txtNombre" runat="server" Style="margin-left: 83px;"></asp:TextBox>
            <br />
            <label class="lblAD1">Descripción:</label>
            <asp:TextBox CssClass="txtAD1" ID="txtDescripcion" runat="server" Style="margin-left: 47px;"></asp:TextBox>
            <br />
            <label class="lblAD1">Año:</label>
            <asp:TextBox CssClass="txtAD1" ID="txtAnio" runat="server" Style="margin-left: 124px;"></asp:TextBox>
            <br />
            <label class="lblAD1">Color:</label>
            <asp:TextBox CssClass="txtAD1" ID="txtColor" runat="server" Style="margin-left: 111px;"></asp:TextBox>
            <br />
            <label class="lblAD1">Imagen:</label>
            <asp:TextBox CssClass="txtAD1" ID="txtImagenUrl" runat="server" Style="margin-left: 86px;"></asp:TextBox>
            <br />
            <label class="lblAD1">Tipo de vehiculo:</label>
            <asp:TextBox CssClass="txtAD1" ID="txtTipo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button CssClass="btnA3" ID="AdProvB" runat="server" Text="Agregar Vehiculo" OnClick="btnAgregarProducto_Click" />
        </div>
        <div class="divA3">
            <br />
            <br />
            <hr />
            <p class="tltB">Ver Autos</p>
            <table>
                <tr class="tblA1">
                    <th>Nombre</th>
                    <th>Descripcion</th>
                    <th>Anio</th>
                    <th>Color</th>
                    <th>Imagen</th>
                    <th>Tipo de producto</th>
                </tr>
                <asp:Repeater ID="rptAuto" runat="server">
                    <ItemTemplate>
                        <tr class="tblA1">
                            <td><%# Eval("Nombre") %></td>
                            <td><%# Eval("Descripcion") %></td>
                            <td><%# Eval("Anio") %></td>
                            <td><%# Eval("Color") %></td>
                            <td><%# Eval("ImagenUrl") %></td>
                            <td><%# Eval("Tipo") %></td>
                            <td><asp:Button CssClass="btnEliminar" runat="server" Text="Eliminar" CommandArgument='<%# Eval("ID") %>' OnClick="EliminarAuto_Click" /></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </div>
</asp:Content>
