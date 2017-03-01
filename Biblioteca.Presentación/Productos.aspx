<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Biblioteca.Presentación.Productos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style9
        {
            width: 39px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    &nbsp;<asp:ListView ID="lvproductos" runat="server" 
        onpagepropertieschanging="lvproductos_PagePropertiesChanging">
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
    <asp:DataPager ID="DataPager1" runat="server" PagedControlID="lvproductos" 
            PageSize="3" >
            <Fields>
                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" 
                    ShowNextPageButton="False" ShowPreviousPageButton="False" />
                <asp:NumericPagerField />
                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" 
                    ShowNextPageButton="False" ShowPreviousPageButton="False" />
            </Fields>
        </asp:DataPager>
    
    
</asp:Content>
