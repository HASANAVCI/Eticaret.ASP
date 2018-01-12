<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="urunGuncelle.aspx.cs" Inherits="Eticaret.admin.urunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 203px;
        }
        .auto-style3 {
            border: 1px dotted #2a595c;
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
            <td class="auto-style2" style="text-align: right">Ürün Adı:</td>
            <td>
                <asp:TextBox ID="txt_urunAdi" runat="server" CssClass="textboxGorsel"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">Ürün Fiyat:</td>
            <td>
                <asp:TextBox ID="txt_urunFiyat" runat="server" CssClass="textboxGorsel"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">ÜrünAçıklama:</td>
            <td>
                <asp:TextBox ID="txt_urunAciklama" runat="server" CssClass="textboxGorsel"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">Ürün Resim:</td>
            <td>
                <asp:FileUpload ID="fu_urunResim" runat="server" CssClass="textboxGorsel" Width="257px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">&nbsp;</td>
            <td>
                <asp:Button ID="btn_guncelle" runat="server" CssClass="butonGorsel" OnClick="btn_guncelle_Click" Text="Güncelle" />
            </td>
        </tr>
    </table>
</asp:Content>
