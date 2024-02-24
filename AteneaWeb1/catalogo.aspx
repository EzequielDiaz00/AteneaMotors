<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="catalogo.aspx.cs" Inherits="AteneaWeb1.catalogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="divc1">
        <div class="divc2">
            <img class="img1" width="100%" src="img1/OIG1.png" alt="logo" />
        </div>
        <div class="divc3">
            <asp:Label Style="float: right; margin-right:10%;" Class="filt1" Text="Filtros" runat="server" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button Style="float:right; margin-left:;" Class="btnc1" Text="Filtrar" runat="server" />
            <div Style="float:right; margin-right:;">
                <asp:Label Class="filt2" Text="Tipo" runat="server" />
                <asp:RadioButtonList runat="server">
                    <asp:ListItem Class="filt3" Id="car1" Text="PickUp" runat="server"/>
                    <asp:ListItem Class="filt3" Id="car2" Text="Sedan" runat="server"/>
                    <asp:ListItem Class="filt3" Id="car3" Text="Camioneta" runat="server"/>
                    <asp:ListItem Class="filt3" Id="car4" Text="Microbus" runat="server"/>
                </asp:RadioButtonList>
            </div>
            <div Style="float:right; margin-right:;">
                <asp:Label Class="filt2" Text="Color" runat="server" />
                <asp:RadioButtonList runat="server">
                    <asp:ListItem Class="filt3" Id="col1" Text="Rojo" runat="server"/>
                    <asp:ListItem Class="filt3" Id="col2" Text="Azul" runat="server"/>
                    <asp:ListItem Class="filt3" Id="col3" Text="Blanco" runat="server"/>
                    <asp:ListItem Class="filt3" Id="col4" Text="Negro" runat="server"/>
                </asp:RadioButtonList>
            </div>
            <div Style="float:right;">
                <asp:Label Class="filt2" Text="Año" runat="server" />
                <asp:RadioButtonList runat="server">
                    <asp:ListItem Class="filt3" Id="an1" Text="2024" runat="server"/>
                    <asp:ListItem Class="filt3" Id="an2" Text="2023" runat="server"/>
                    <asp:ListItem Class="filt3" Id="an3" Text="2022" runat="server"/>
                    <asp:ListItem Class="filt3" Id="an4" Text="2021" runat="server"/>
                </asp:RadioButtonList>
            </div>            
            
        </div>
    </div>
</asp:Content>
