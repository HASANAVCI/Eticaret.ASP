using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eticaret.admin
{
    public partial class _default : System.Web.UI.Page
    {
        sqlbaglanti baglan = new sqlbaglanti();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_giris_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("Select * from Yonetici where yoneticiKullanici='"+txt_kullanici.Text +"'and yoneticiSifre='"+txt_sifre.Text+"'",baglan.baglan());
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Response.Redirect("adminpanel.aspx");
            }
            else
            {
                lbl_bilgi.Text = "Hatalı Giriş Yaptınız!";
            }
        }
    }
}