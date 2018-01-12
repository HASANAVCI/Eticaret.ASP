<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="Kategoriler.aspx.cs" Inherits="Eticaret.admin.Kategoriler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 197px;
        }
        .auto-style3 {
            width: 524px;
        }
        .auto-style4 {
            width: 95px;
        }
        .auto-style5 {
            width: 50px;
            height: 30px;
        }
        .auto-style6 {
            width: 50px;
            height: 26px;
        }
    </style>
    </asp:Content>
    <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
        <div style="height:25px; background-color:#2a595a; color:#fff; font-weight:bolder; ">&nbsp;
            <asp:Button ID="kaArti" runat="server" OnClick="kaArti_Click" Text="+" Width="18px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="kaEksi" runat="server" OnClick="kaEksi_Click" Text="-" Width="18px" />
&nbsp;&nbsp;&nbsp;&nbsp; Kategori Ekleme Paneli</div>
        <asp:Panel ID="pnl_kategoriEkle" runat="server" BackColor="#669999" ForeColor="White">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" style="text-align: right">Kategori Adı:<br />
                        <br />
                        <br />
                        Kategori Açıklama:</td>
                    <td>
                        <br />
                        <br />
                        <br />
                        <asp:TextBox ID="txt_kategoriAdi" runat="server" CssClass="textboxGorsel"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <asp:TextBox ID="txt_kategoriAciklama" runat="server" CssClass="textboxGorsel"></asp:TextBox>
                        <br />
                        <br />
                        <br />
                        <asp:Button ID="kategoriEkle" runat="server" CssClass="butonGorsel" OnClick="kategoriEkle_Click" Text="Ekle" />
                    </td>
                </tr>
            </table>


        </asp:Panel>
        <div style="height:30px;"></div>
         <div style="height:25px; background-color:#2a595a; color:#fff; font-weight:bolder; ">&nbsp;
            <asp:Button ID="btn_kdArti" runat="server"  Text="+" Width="18px" OnClick="btn_kdArti_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_kdEksi" runat="server"  Text="-" Width="18px" OnClick="btn_kdEksi_Click" />
&nbsp;&nbsp;&nbsp;&nbsp; Kategori Düzenleme/Silme Paneli</div>
        <asp:Panel ID="pnl_kategoriDuzenle" runat="server" BackColor="#669999" ForeColor="White">
            <asp:DataList ID="dl_kategoriGetir" runat="server" Width="700px" >
                <HeaderTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">KATEGORİ ADI</td>
                            <td class="auto-style4">GÜNCELLE</td>
                            <td>SİL</td>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style3">
                                <asp:Literal ID="Literal1" runat="server" Text='<%# Eval("kategoriAdi") %>'></asp:Literal>
                            </td>
                            <td class="auto-style4">
                               <a href="kategoriGuncelle.aspx?kategoriID=<%#Eval("kategoriID") %>"> <img alt="" class="auto-style5" src="../tema/düzenle.jpg" /></a>
                            </td>
                            <td>
                                <a href="Kategoriler.aspx?kategoriID=<%#Eval("kategoriID") %>&islem=sil"><img alt="" class="auto-style6" src="../tema/sil%20ikonu.jpg" /></a>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            </asp:Panel>
            <div style="height:30px;"></div>
            </div>
</asp:Content>
