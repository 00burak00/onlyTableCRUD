using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace odev2
{
    public class egitimCRUD
    {
        db Db = new db();
        public bool kaydet(egitim egt)
        {
            bool cvp=true;
            int a;
            Db.ac();
            SqlCommand cmd = new SqlCommand("insert into Egitim values (@a,@b,@c,@d,@e,@f) ", Db.baglanti);
            cmd.Parameters.AddWithValue("@a", egt.Tur);
            cmd.Parameters.AddWithValue("@b", egt.Adi);
            cmd.Parameters.AddWithValue("@c", egt.Tarih);
            cmd.Parameters.AddWithValue("@d", egt.Ogrsay);
            cmd.Parameters.AddWithValue("@e", egt.Icerik);
            cmd.Parameters.AddWithValue("@f", egt.Egitimkod);
            a = cmd.ExecuteNonQuery();
            if (a == 0)
                return false;

            Db.kapat();
            return cvp;
        }
        public DataTable listeleme()
        {
            DataTable dt = new DataTable();
            Db.ac();
            SqlCommand cmd = new SqlCommand("select * from egitim",Db.baglanti);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            Db.kapat();
            return dt;
        }
        public bool sil(string prm)
        {

            bool cevap=true;
            int a;
            Db.ac();

            SqlCommand cmd = new SqlCommand("delete from egitim where egitimkod=@egtkod ", Db.baglanti);
            cmd.Parameters.AddWithValue("@egtkod", prm);
            a= cmd.ExecuteNonQuery();
            if(a == 0)
                cevap=false;
            Db.kapat();
            return cevap;
        }
        public DataTable getir(string prm)
        {
           Db.ac();
           DataTable dt = new DataTable();
           SqlCommand cmd = new SqlCommand("select * from egitim where egitimkod=@egtkod", Db.baglanti);
           cmd.Parameters.AddWithValue("@egtkod", prm);
           SqlDataAdapter adp= new SqlDataAdapter(cmd);
            adp.Fill(dt);
            Db.kapat();
            return dt;
        }
        public bool guncelle(egitim egt)
        {
            bool cevap=true;
            int a;
            Db.ac();
            SqlCommand cmd = new SqlCommand("update egitim set tur=@a, adi=@b, tarih=@c," +
                " ogrencisay=@d, icerik=@e, egitimkod=@f where egitimkod=@g", Db.baglanti);
            cmd.Parameters.AddWithValue("@a", egt.Tur);
            cmd.Parameters.AddWithValue("@b", egt.Adi);
            cmd.Parameters.AddWithValue("@c", egt.Tarih);
            cmd.Parameters.AddWithValue("@d", egt.Ogrsay);
            cmd.Parameters.AddWithValue("@e", egt.Icerik);
            cmd.Parameters.AddWithValue("@f", egt.Egitimkod);
            cmd.Parameters.AddWithValue("@g", egt.Egitimkod);
            a = cmd.ExecuteNonQuery();
            if (a == 0)
                cevap = false;
            Db.kapat();

            return cevap;

        } 
    }
}