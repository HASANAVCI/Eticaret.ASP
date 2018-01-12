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
    public partial class kategoriGuncelle : System.Web.UI.Page
    {
        sqlbaglanti baglan = new sqlbaglanti();
        string kategoriID = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            kategoriID = Request.QueryString["kategoriID"];
            if (Page.IsPostBack==false)
            {
                SqlCommand cmdkguncelle = new SqlCommand("Select * from Kategori where kategoriID='"+kategoriID+"'",baglan.baglan());
                SqlDataReader drkguncelle = cmdkguncelle.ExecuteReader();

                DataTable dtkguncelle = new DataTable("tablo");
                dtkguncelle.Load(drkguncelle);

                DataRow row = dtkguncelle.Rows[0];
                txt_kAdi.Text = row["kategoriAdi"].ToString();
                txt_kAciklama.Text = row["kategoriAciklama"].ToString();

            }
        }

        protected void btn_kGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdkguncelle = new SqlCommand("update Kategori set kategoriAdi='"+txt_kAdi.Text+"',kategoriAciklama='"+txt_kAciklama.Text+"' where kategoriID='"+kategoriID+"'",baglan.baglan());
            cmdkguncelle.ExecuteNonQuery();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}