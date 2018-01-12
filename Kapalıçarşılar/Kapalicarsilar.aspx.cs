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
    public partial class Kapalicarsilar : System.Web.UI.Page
    {
        sqlbaglanti baglan = new sqlbaglanti();
        string kapalicarsiID = "";
        string islem = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            kapalicarsiID = Request.QueryString["kapalicarsiID"];
            islem = Request.QueryString["islem"];
            if (islem == "sil")
            {
                SqlCommand cmdsil = new SqlCommand("delete from Kapalicarsi where kapalicarsiID='" + kapalicarsiID + "'", baglan.baglan());
                cmdsil.ExecuteNonQuery();
            }

            if (Page.IsPostBack == false)
            {
                pnl_kategoriEkle.Visible = false;
                pnl_kategoriDuzenle.Visible = false;
            }
            //kategorileri dataliste çekme
            SqlCommand cmdktgrgetir = new SqlCommand("select * from Kapalicarsi", baglan.baglan());
            SqlDataReader drkgetir = cmdktgrgetir.ExecuteReader();
            dl_kategoriGetir.DataSource = drkgetir;
            dl_kategoriGetir.DataBind();
        }

        protected void kaArti_Click(object sender, EventArgs e)
        {
            pnl_kategoriEkle.Visible = true;
        }

        protected void kaEksi_Click(object sender, EventArgs e)
        {
            pnl_kategoriEkle.Visible = false;
        }

        protected void kategoriEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdkekle = new SqlCommand("insert into Kapalicarsi(kapalicarsiAdi) values('" + txt_kategoriAdi.Text + "')", baglan.baglan());
            cmdkekle.ExecuteNonQuery();
            Response.Redirect("Kapalicarsilar.aspx");
        }

        protected void btn_kdArti_Click(object sender, EventArgs e)
        {
            pnl_kategoriDuzenle.Visible = true;
        }

        protected void btn_kdEksi_Click(object sender, EventArgs e)
        {
            pnl_kategoriDuzenle.Visible = false;
        }
    }
}