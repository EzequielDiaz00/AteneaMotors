<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="verResenas.aspx.cs" Inherits="AteneaWeb1.verResenas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="tltA">Reseñas de Vehículos</p>
    <br />
    <br />
    <div class="divA1" style="flex-direction: column; align-items: center;">
        <div class="divA3">
            <br />
            <br />
            <hr />
            <p class="tltB">Ver reseñas</p>
            <table>
                <tr class="tblA1">
                    <th>Usuario</th>
                    <th>Auto</th>
                    <th>Estrellas</th>
                    <th>Comentario</th>
                    <th>Fecha</th>
                </tr>
                <asp:Repeater ID="rptResenas" runat="server">
                    <ItemTemplate>
                        <tr class="tblA1">
                            <td><%# Eval("UserID") %></td>
                            <td><%# Eval("CarID") %></td>
                            <td><%# Eval("Rating") %></td>
                            <td><%# Eval("ReviewText") %></td>
                            <td><%# Eval("Fecha", "{0:dd/MM/yyyy}") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </div>
</asp:Content>
