<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="Biblioteca.Presentación.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style9
        {
            width: 19px;
        }
        .style11
        {
            height: 20px;
        }
        .style12
        {
            height: 23px;
        }
        .style13
        {
            height: 29px;
        }
        .style14
        {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td rowspan="5" class="style9">
                <asp:Image ID="Image1" runat="server" Height="151px" Width="276px" /> 
            </td>
            <td>
                <asp:Label ID="lbl_nombre" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td class="style14">
                $ <asp:Label ID="lbl_precio" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td class="style11">
                <asp:Label ID="lbl_tipo" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td class="style12">
                Stock:  
                <asp:Label ID="lbl_stock" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style13">
                <asp:Button ID="btn_agregar" runat="server" Text="Agregar" 
                    onclick="btn_agregar_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                
                <asp:Label ID="lbl_descripcion" runat="server" Text=""></asp:Label>
                
                &nbsp;
                &nbsp; 
            </td>
        </tr>
    </table>
</asp:Content>
