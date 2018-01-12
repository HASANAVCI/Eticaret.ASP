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
    public partial class Kargolar : System.Web.UI.Page
    {
        sqlbaglanti baglan = new sqlbaglanti();
        string kargoID = "";
        string islem = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //ürün sil ikonu için
            kargoID = Request.QueryString["kargoID"];
            islem = Request.QueryString["islem"];

            if (islem == "sil")
            {
                SqlCommand cmdusil = new SqlCommand("delete from Kargo where kargoID='" + kargoID + "'", baglan.baglan());
                cmdusil.ExecuteNonQuery();
            }
            if (Page.IsPostBack == false)
            {
                pnl_urunEkle.Visible = false;
                pnl_Urunduzenle.Visible = false;

              

                //urun getir

                SqlCommand cmdugetir = new SqlCommand("select * from Kargo", baglan.baglan());
                SqlDataReader drurunGetir = cmdugetir.ExecuteReader();
                ddl_urunGetir.DataSource = drurunGetir;
                ddl_urunGetir.DataBind();

            }
        }

        protected void btn_urunEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdekle = new SqlCommand("insert into Kargo(kargoAdi,kargoAdresi,kargoTelefon,kargoWeb,kargoMail) values('" + txt_firmaad.Text + "','" + txt_firmaadres.Text + "','" + txt_ftel.Text + "','" + txt_fweb.Text+ "','"+txt_fmail.Text+"') ", baglan.baglan());
            cmdekle.ExecuteNonQuery();
            Response.Redirect("Kargolar.aspx");
        }

        protected void btn_ueArti_Click(object sender, EventArgs e)
        {
            pnl_urunEkle.Visible = true;
        }

        protected void btn_ueEksi_Click(object sender, EventArgs e)
        {
            pnl_urunEkle.Visible = false;
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