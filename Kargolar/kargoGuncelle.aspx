<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="kargoGuncelle.aspx.cs" Inherits="Eticaret.admin.kargoGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 203px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1" style="background-color: #669999">
        <tr>
            <td class="auto-style2" style="text-align: right">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">Firma Adı:</td>
            <td>
                <asp:TextBox ID="txt_firmaAdi" runat="server" CssClass="textboxGorsel"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">Firma Adresi:</td>
            <td>
                <asp:TextBox ID="txt_firmaAdres" runat="server" CssClass="textboxGorsel"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">Telefon:</td>
            <td>
                <asp:TextBox ID="txt_ftel" runat="server" CssClass="textboxGorsel"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">Firma Web:</td>
            <td>
                <asp:TextBox ID="txt_fweb" runat="server" CssClass="textboxGorsel"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">Firma Mail:</td>
            <td>
                
                <asp:TextBox ID="txt_fmail" runat="server" CssClass="textboxGorsel"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">&nbsp;</td>
            <td>
                <asp:Button ID="btn_guncelle" runat="server" CssClass="butonGorsel" OnClick="btn_guncelle_Click" Text="Güncelle" />
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
