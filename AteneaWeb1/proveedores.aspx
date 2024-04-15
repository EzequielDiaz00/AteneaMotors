<%@ Page Title="" Language="C#" MasterPageFile="~/Master2.Master" AutoEventWireup="true" CodeBehind="proveedores.aspx.cs" Inherits="AteneaWeb1.proveedores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="tltA">Proveedores</p>
    <br />
    <br />
    <div class="divA1" style="flex-direction: column; align-items: center;">
        <div class="divA3">
            <hr />
            <p class="tltB">Agregar Proveedor</p>
            <label class="lblAD1">Nombre:</label>
            <asp:TextBox CssClass="txtAD1" ID="AdProv1" runat="server" Style="margin-left: 90px;"></asp:TextBox>
            <br />
            <label class="lblAD1">Descripción:</label>
            <asp:TextBox CssClass="txtAD1" ID="AdProv2" runat="server" Style="margin-left: 54px;"></asp:TextBox>
            <br />
            <label class="lblAD1">Marca:</label>
            <asp:TextBox CssClass="txtAD1" ID="AdProv3" runat="server" Style="margin-left: 110px;"></asp:TextBox>
            <br />
            <label class="lblAD1">Direccion:</label>
            <asp:TextBox CssClass="txtAD1" ID="AdProv4" runat="server" Style="margin-left: 77px;"></asp:TextBox>
            <br />
            <label class="lblAD1">Telefono:</label>
            <asp:TextBox CssClass="txtAD1" ID="AdProv5" runat="server" Style="margin-left: 86px;"></asp:TextBox>
            <br />
            <label class="lblAD1">Tipo de producto:</label>
            <asp:TextBox CssClass="txtAD1" ID="AdProv6" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button CssClass="btnA3" ID="AdProvB" runat="server" Text="Agregar Proveedor" OnClick="AdProvB_Click" />
        </div>
        <div class="divA3">
            <br />
            <br />
            <hr />
            <p class="tltB">Ver proveedores</p>
            <table>
                <tr class="tblA1">
                    <th>Nombre</th>
                    <th>Descripcion</th>
                    <th>Marca</th>
                    <th>Direccion</th>
                    <th>Telefono</th>
                    <th>Tipo de producto</th>
                </tr>
                <asp:Repeater ID="rptProv" runat="server">
                    <ItemTemplate>
                        <tr class="tblA1">
                            <td><%# Eval("Nombre") %></td>
                            <td><%# Eval("Descripcion") %></td>
                            <td><%# Eval("Marca") %></td>
                            <td><%# Eval("Direccion") %></td>
                            <td><%# Eval("Telefono") %></td>
                            <td><%# Eval("Tipo") %></td>
                            <td><asp:Button CssClass="btnEliminar" runat="server" Text="Eliminar" CommandArgument='<%# Eval("ID") %>' OnClick="EliminarProv_Click" /></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </div>
</asp:Content>
