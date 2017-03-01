<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CarroDeCompras.aspx.cs" Inherits="TiendaOnline.CarroDeCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style6
        {
            width: 83px;
        }
        .style7
        {
            width: 178px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Carro de Compras"></asp:Label>
    <br />
    <br />
    <table style="width: 100%;">
        <tr>
            <td colspan="3">
                <asp:ListBox ID="lsb_carro" runat="server" Height="205px" Width="463px">
                </asp:ListBox>
                &nbsp;
                &nbsp;
                &nbsp;
                &nbsp;
                &nbsp;
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style8">
                <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" 
                    onclick="btn_eliminar_Click" Height="26px" />
                &nbsp;
            </td>
            <td class="style5">
                <asp:Label ID="Label2" runat="server" Text="Total Compra: $"></asp:Label>
                &nbsp;
                <asp:Label ID="lbl_total" runat="server" Text=""></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style7">
                <asp:Button ID="btn_pagar" runat="server" Height="44px" Text="Pagar" 
                    Width="241px" onclick="btn_pagar_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
