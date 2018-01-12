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
    public partial class kcarsiGuncelle : System.Web.UI.Page
    {
        sqlbaglanti baglan = new sqlbaglanti();
        string kapalicarsiID = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            kapalicarsiID = Request.QueryString["kapalicarsiID"];
            if (Page.IsPostBack == false)
            {
                SqlCommand cmdkguncelle = new SqlCommand("Select * from Kapalicarsi where kapalicarsiID='" + kapalicarsiID + "'", baglan.baglan());
                SqlDataReader drkguncelle = cmdkguncelle.ExecuteReader();

                DataTable dtkguncelle = new DataTable("tablo");
                dtkguncelle.Load(drkguncelle);

                DataRow row = dtkguncelle.Rows[0];
                txt_kAdi.Text = row["kapalicarsiAdi"].ToString();


            }
        }

        protected void btn_kGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdkguncelle = new SqlCommand("update Kapalicarsi set kapalicarsiAdi='" + txt_kAdi.Text + "' where kapalicarsiID='" + kapalicarsiID + "'", baglan.baglan());
            cmdkguncelle.ExecuteNonQuery();
            Response.Redirect("Kapalicarsilar.aspx");
        }
    }
}