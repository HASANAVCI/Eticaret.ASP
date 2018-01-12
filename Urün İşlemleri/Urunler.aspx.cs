using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Eticaret.admin
{
    public partial class Urunler : System.Web.UI.Page
    {
        sqlbaglanti baglan = new sqlbaglanti();
        string urunID = "";
        string islem = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //ürün sil ikonu için
            urunID = Request.QueryString["urunID"];
            islem = Request.QueryString["islem"];

            if (islem=="sil")
            {
                SqlCommand cmdusil = new SqlCommand("delete from Urun where urunID='"+urunID+"'",baglan.baglan());
                cmdusil.ExecuteNonQuery();
            }
            if (Page.IsPostBack==false)
            {
                pnl_urunEkle.Visible = false;
                pnl_Urunduzenle.Visible = false;

                //kategorileri getirme işlemi:
                SqlCommand cmdurungetir = new SqlCommand("select * from kategori",baglan.baglan());
                SqlDataReader drurungetir = cmdurungetir.ExecuteReader();
                ddl_kategori.DataTextField = "kategoriAdi";
                ddl_kategori.DataValueField = "kategoriID";

                ddl_kategori.DataSource = drurungetir;
                ddl_kategori.DataBind();

                //kapalıçarşıları getirme işlemi
                SqlCommand cmdkgetir = new SqlCommand("select * from Kapalicarsi", baglan.baglan());
                SqlDataReader drkgetir = cmdkgetir.ExecuteReader();
                ddl_kapalicarsi.DataTextField = "kapalicarsiAdi";
                ddl_kapalicarsi.DataValueField = "kapalicarsiID";

                ddl_kapalicarsi.DataSource = drkgetir;
                ddl_kapalicarsi.DataBind();

                //urun getir

                SqlCommand cmdugetir = new SqlCommand("select * from Urun",baglan.baglan());
                SqlDataReader drurunGetir = cmdugetir.ExecuteReader();
                ddl_urunGetir.DataSource = drurunGetir;
                ddl_urunGetir.DataBind();

            }
        }

        protected void btn_ueEksi_Click(object sender, EventArgs e)
        {
            pnl_urunEkle.Visible = false;
        }

        protected void btn_ueArti_Click(object sender, EventArgs e)
        {
            pnl_urunEkle.Visible = true;
        }
       
            protected void btn_urunEkle_Click(object sender, EventArgs e)
        {
            //resim ekleme kontrol 
            if (fu_urunresim.HasFile)
            {
                fu_urunresim.SaveAs(Server.MapPath("/UrunResim/"+fu_urunresim.FileName));
                SqlCommand cmdekle = new SqlCommand("insert into Urun(urunAdi,urunAciklama,urunFiyat,kategoriID,urunResim) values('"+txt_urunad.Text+"','"+txt_urunAciklama.Text+"','"+txt_urunfiyat.Text+"','"+ddl_kategori.SelectedValue+"','/UrunResim/"+fu_urunresim.FileName+"') ", baglan.baglan());
                cmdekle.ExecuteNonQuery();
                Response.Redirect("Urunler.aspx");
            }
            else
            {
                btn_urunEkle.Text = "ResimEkle!!";
            }
                

               
               
               
           
            
        }

        protected void btn_udArti_Click(object sender, EventArgs e)
        {
            pnl_Urunduzenle.Visible = true;
        }

        protected void btn_udEksi_Click(object sender, EventArgs e)
        {
            pnl_Urunduzenle.Visible = false;
        }
    }
}