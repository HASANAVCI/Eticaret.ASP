using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Eticaret
{
    public class sqlbaglanti
    {
        public SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=HP-PC; Initial Catalog=Ticaret; Integrated Security=true;");
                baglanti.Open();
            SqlConnection.ClearPool(baglanti);
            SqlConnection.ClearAllPools();
            return (baglanti);
        }
    }
}