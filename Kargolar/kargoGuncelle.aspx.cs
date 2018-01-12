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
    public partial class kargoGuncelle : System.Web.UI.Page
    {
        sqlbaglanti baglan = new sqlbaglanti();
        string kargoID = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            kargoID = Request.QueryString["kargoID"];

            if (Page.IsPostBack == false)
            {
                SqlCommand cmdugetir = new SqlCommand("select * from Kargo where kargoID='" + kargoID + "'", baglan.baglan());
                SqlDataReader drugetir = cmdugetir.ExecuteReader();

                DataTable dtugetir = new DataTable("tablo");
                dtugetir.Load(drugetir);

                DataRow row = dtugetir.Rows[0];
                txt_firmaAdi.Text = row["kargoAdi"].ToString();
                txt_firmaAdres.Text = row["kargoAdresi"].ToString();
                txt_ftel.Text= row["kargoTelefon"].ToString();
                txt_fweb.Text = row["kargoWeb"].ToString();
                txt_fmail.Text = row["kargoMail"].ToString();


            }
        }

        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            
            SqlCommand guncelle = new SqlCommand("Update Kargo set kargoAdi='" + txt_firmaAdi.Text+ "', kargoAdresi='" + txt_firmaAdres.Text + "', kargoTelefon='" + txt_ftel.Text + "',kargoWeb='"+txt_fweb.Text+"',kargoMail='"+txt_fmail.Text+"'", baglan.baglan());
            guncelle.ExecuteNonQuery();
            Response.Redirect("Kargolar.aspx");
        }
    }
}