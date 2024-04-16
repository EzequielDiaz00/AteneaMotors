<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="cotizaciones.aspx.cs" Inherits="AteneaWeb1.cotizaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="tltA">Cotizaciones de Vehiculos</p>
    <br />
    <br />
    <div class="divA1" style="flex-direction: column; align-items: center;">
        <div class="divA3">
            <br />
            <br />
            <hr />
            <p class="tltB">Ver cotizaciones</p>
            <table>
                <tr class="tblA1">
                    <th>Nombre</th>
                    <th>Apellido</th>
                    <th>Correo</th>
                    <th>Telefono</th>
                </tr>
                <asp:Repeater ID="rptCot" runat="server">
                    <ItemTemplate>
                        <tr class="tblA1">
                            <td><%# Eval("Nombre") %></td>
                            <td><%# Eval("Apellido") %></td>
                            <td><%# Eval("Correo") %></td>
                            <td><%# Eval("Telefono") %></td>
                            <td><asp:Button CssClass="btnEliminar" runat="server" Text="Respondido" CommandArgument='<%# Eval("Correo") %>' OnClick="btnEliminar_Click"/></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </div>
</asp:Content>
