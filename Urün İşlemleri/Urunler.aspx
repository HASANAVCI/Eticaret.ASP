<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="Eticaret.admin.Urunler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 202px;
        }
        .auto-style3 {
            width: 484px;
            height: 21px;
        }
        .auto-style4 {
            height: 21px;
        }
        .auto-style5 {
            height: 21px;
            width: 105px;
        }
        .auto-style6 {
            width: 50px;
            height: 50px;
        }
        .auto-style7 {
            width: 84px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div style="height:25px; background-color:#2a595a; color:#fff; font-weight:bolder; ">&nbsp;
            <asp:Button ID="btn_ueArti" runat="server"  Text="+" Width="18px" OnClick="btn_ueArti_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_ueEksi" runat="server"  Text="-" Width="18px" OnClick="btn_ueEksi_Click" />
&nbsp;&nbsp;&nbsp;&nbsp; Ürün Ekleme Paneli</div>
        <asp:Panel ID="pnl_urunEkle" runat="server" BackColor="#669999" ForeColor="White">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" style="text-align: right">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">Kategori:</td>
                    <td>
                        <asp:DropDownList ID="ddl_kategori" runat="server" CssClass="dropdownGorsel" Width="100px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">Kapalıçarşı:</td>
                    <td>
                        <asp:DropDownList ID="ddl_kapalicarsi" runat="server" CssClass="dropdownGorsel" Width="100px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">Ürün Adı:</td>
                    <td>
                        <asp:TextBox ID="txt_urunad" runat="server" CssClass="textboxGorsel" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">Ürün Fiyat:</td>
                    <td>
                        <asp:TextBox ID="txt_urunfiyat" runat="server" CssClass="textboxGorsel" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">Ürün Açıklama:</td>
                    <td>
                        <asp:TextBox ID="txt_urunAciklama" runat="server" CssClass="textboxGorsel" Width="400px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">Ürün Resim:</td>
                    <td>
                        <asp:FileUpload ID="fu_urunresim" runat="server" CssClass="textboxGorsel" Width="400px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">&nbsp;</td>
                    <td>
                        <asp:Button ID="btn_urunEkle" runat="server" CssClass="butonGorsel" OnClick="btn_urunEkle_Click" Text="Ekle" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" style="text-align: right">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            </asp:Panel>
        <div style="height:30px;"></div>
        <div style="height:25px; background-color:#2a595a; color:#fff; font-weight:bolder; ">&nbsp;
            <asp:Button ID="btn_udArti" runat="server"  Text="+" Width="18px" OnClick="btn_udArti_Click"  />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_udEksi" runat="server"  Text="-" Width="18px" OnClick="btn_udEksi_Click" />
&nbsp;&nbsp;&nbsp;&nbsp; Ürün Düzenleme Paneli</div>
        <asp:Panel ID="pnl_Urunduzenle" runat="server" BackColor="#669999" ForeColor="White">
            <asp:DataList ID="ddl_urunGetir" runat="server" Width="699px">
                <HeaderTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">ÜRÜN ADI</td>
                            <td class="auto-style5">GÜNCELLE</td>
                            <td class="auto-style4">SİL</td>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">
                                <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("urunAdi") %>'></asp:Literal>
                            </td>
                            <td class="auto-style7">
                                <a href="urunGuncelle.aspx?urunID=<%#Eval("urunID") %>"><img alt="" class="auto-style6" src="../tema/düzenle.jpg" /></a>
                            </td>
                            <td>
                                 <a href="Urunler.aspx?urunID=<%#Eval("urunID") %>&islem=sil"><img alt="" class="auto-style6" src="../tema/sil%20ikonu.jpg" /></a>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            </asp:Panel>
    </div>
</asp:Content>
