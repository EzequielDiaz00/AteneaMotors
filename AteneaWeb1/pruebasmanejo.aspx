<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="pruebasmanejo.aspx.cs" Inherits="AteneaWeb1.pruebasmanejo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="tltA">Pruebas de manejo de los usuarios</p>
    <br />
    <br />
    <div class="divA1" style="flex-direction: column; align-items: center;">
        <div class="divA3">
            <br />
            <br />
            <hr />
            <p class="tltB">Ver solicitudes</p>
            <table>
                <tr class="tblA1">
                    <th>Nombre</th>
                    <th>Apellido</th>
                    <th>Correo</th>
                    <th>Telefono</th>
                    <th>Vehiculo</th>
                    <th>Fecha</th>
                </tr>
                <asp:Repeater ID="rptPM" runat="server">
                    <ItemTemplate>
                        <tr class="tblA1">
                            <td><%# Eval("Nombre") %></td>
                            <td><%# Eval("Apellido") %></td>
                            <td><%# Eval("Correo") %></td>
                            <td><%# Eval("Telefono") %></td>
                            <td><%# Eval("Auto") %></td>
                            <td><%# Eval("Fecha") %></td>
                            <td><asp:Button CssClass="btnEliminar" runat="server" Text="Respondido" CommandArgument='<%# Eval("Correo") %>' OnClick="btnEliminar_Click"/></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </div>
</asp:Content>
