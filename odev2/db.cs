using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace odev2
{
    public class db
    {
        public SqlConnection baglanti = new SqlConnection("workstation id=burakertev.mssql.somee.com;packet size=4096;user id=burak-07_SQLLogin_2;pwd=2bcq12k1jm;data source=burakertev.mssql.somee.com;persist security info=False;initial catalog=burakertev");
        public void ac()
        {
            baglanti.Open();
        }
        public void kapat()
        {
            baglanti.Close();
        }
    }
}