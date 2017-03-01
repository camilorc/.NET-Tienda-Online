<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PagoOnline.aspx.cs" Inherits="Biblioteca.Presentación.PagoOnline" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style9
        {
        }
        .style10
        {
            width: 144px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="style9">
                Nombre:</td>
            <td class="style10">
                <asp:LoginName ID="LoginName1" runat="server" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9">
                Tipo Tarjeta:</td>
            <td class="style10">
                <asp:DropDownList ID="ddl_tarjetas" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9">
                Número tarjeta:</td>
            <td class="style10">
                <asp:TextBox ID="txt_num" runat="server" MaxLength="8" TextMode="Number"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ErrorMessage="(*) Dato Obligatorio" ControlToValidate="txt_num"></asp:RequiredFieldValidator>
            &nbsp;</td>
        </tr>
        <tr>
            <td class="style9">
                TOTAL:</td>
            <td class="style10">
                <asp:Label ID="lbl_total" runat="server" Text=""></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9">
                <asp:Button ID="btn_pagar" runat="server" Text="Pagar" 
                    onclick="btn_pagar_Click" />
            </td>
            <td class="style10">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style9" colspan="3">
                <asp:Label ID="lbl_mensaje" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
