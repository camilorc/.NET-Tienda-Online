<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Filtros.aspx.cs" Inherits="Biblioteca.Presentación.Filtros" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Filtros:
        <asp:DropDownList ID="ddl_filtro" runat="server" AutoPostBack="True" 
            onselectedindexchanged="ddl_filtro_SelectedIndexChanged">
        </asp:DropDownList>
    </p>
    <p>
        <asp:ListView ID="lvproductosfiltro" runat="server">
            <ItemTemplate>
                <table style="width: 100%;">
        <tr>
            <td class="style9" rowspan="3">
                <a href= "Detalle.aspx?indice=<%#Eval("Id")%>">
                   <img alt="" src="<%#Eval("imgUrl") %>" style="height: 91px; width: 116px" />
                </a>
                <br />
            </td>
            <td colspan="2">
                <%#Eval("Nombre") %>&nbsp;
            </td>
        </tr>
        <tr>
            <td style="font-weight: bold">
                Precio:</td>
            <td>
                &nbsp;
                $ <%#Eval("Precio") %></td>
        </tr>
        <tr>
            <td colspan="2" style="font-weight: bold">
                Descripción:<br />
                <br />
                <%#Eval("Descripcion") %>
            </td>
        </tr>
    </table>
        <br />
            </ItemTemplate>
        </asp:ListView>
    </p>
</asp:Content>
