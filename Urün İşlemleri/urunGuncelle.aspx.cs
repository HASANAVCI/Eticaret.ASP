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
    public partial class urunGuncelle : System.Web.UI.Page
    {
        sqlbaglanti baglanti = new sqlbaglanti();
        string urunID = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            urunID = Request.QueryString["urunID"];

            if (Page.IsPostBack==false)
            {
                SqlCommand cmdugetir = new SqlCommand("select * from Urun where urunID='"+urunID+"'",baglanti.baglan());
                SqlDataReader drugetir = cmdugetir.ExecuteReader();

                DataTable dtugetir = new DataTable("tablo");
                dtugetir.Load(drugetir);

                DataRow row = dtugetir.Rows[0];
                txt_urunAdi.Text = row["urunAdi"].ToString();
                txt_urunAciklama.Text = row["urunAciklama"].ToString();
                txt_urunFiyat.Text = row["urunFiyat"].ToString();


            }
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (fu_urunResim.HasFile) //fileuploadda bir dosya varsa
            {
                fu_urunResim.SaveAs(Server.MapPath("/UrunResim/"+fu_urunResim.FileName));
                SqlCommand guncelle = new SqlCommand("Update Urun set urunAdi='"+txt_urunAdi.Text+"', urunAciklama='"+txt_urunAciklama.Text+"', urunFiyat='"+txt_urunFiyat.Text+"',urunResim='/UrunResim"+fu_urunResim.FileName+"'",baglanti.baglan());
                guncelle.ExecuteNonQuery();
                Response.Redirect("Urunler.aspx");
            }
            else
            {
                SqlCommand guncelle = new SqlCommand("Update Urun set urunAdi='" + txt_urunAdi.Text + "', urunAciklama='" + txt_urunAciklama.Text + "', urunFiyat='" + txt_urunFiyat.Text + "'", baglanti.baglan());
                guncelle.ExecuteNonQuery();
                Response.Redirect("Urunler.aspx");
            }
        }
    }
}