<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="solicitudesEmpleo.aspx.cs" Inherits="AteneaWeb1.solicitudesEmpleo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="tltA">Solicitudes de Empleo</p>
    <br />
    <br />
    <div class="divA1" style="flex-direction: column; align-items: center;">
        <div class="divA3">
            <br />
            <br />
            <hr />
            <p class="tltB">Ver solicitudes de empleo</p>
            <table>
                <tr class="tblA1">
                    <th>Nombre</th>
                    <th>Correo</th>
                    <th>Teléfono</th>
                    <th>Dirección</th>
                    <th>Experiencia</th>
                </tr>
                <asp:Repeater ID="rptSolicitudes" runat="server">
                    <ItemTemplate>
                        <tr class="tblA1">
                            <td><%# Eval("Nombre") %></td>
                            <td><%# Eval("Correo") %></td>
                            <td><%# Eval("Telefono") %></td>
                            <td><%# Eval("Direccion") %></td>
                            <td><%# Eval("Experiencia") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </div>
</asp:Content>
