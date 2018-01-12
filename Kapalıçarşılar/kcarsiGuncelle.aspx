<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="kcarsiGuncelle.aspx.cs" Inherits="Eticaret.admin.kcarsiGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 210px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1" style="background-color: #669999">
        <tr>
            <td class="auto-style2" style="text-align: right">&nbsp;&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2" style="text-align: right">Kapalıçarşı Adı:</td>
            <td>
                <asp:TextBox ID="txt_kAdi" runat="server" CssClass="textboxGorsel"></asp:TextBox>
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
                <asp:Button ID="btn_kGuncelle" runat="server" CssClass="butonGorsel" OnClick="btn_kGuncelle_Click" Text="Güncelle" />
            </td>
        </tr>
    </table>
</asp:Content>

