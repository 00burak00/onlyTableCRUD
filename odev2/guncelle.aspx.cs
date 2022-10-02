using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace odev2
{
    public partial class guncelle : System.Web.UI.Page
    { 
        egitimCRUD egtCRUD = new egitimCRUD();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if(!IsPostBack)
            {
                dt = egtCRUD.getir(Request.QueryString["prm"]);
                TextBox1.Text = dt.Rows[0][0].ToString();
                TextBox2.Text = dt.Rows[0][1].ToString();
                TextBox3.Text = Convert.ToDateTime( dt.Rows[0][2]).ToShortDateString();
                TextBox4.Text = dt.Rows[0][3].ToString();
                TextBox5.Text = dt.Rows[0][4].ToString();
                TextBox6.Text = dt.Rows[0][5].ToString();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            egitim egt = new egitim();
            bool a;
            egt.Tur = TextBox1.Text;
            egt.Adi = TextBox2.Text;
            egt.Tarih =Convert.ToDateTime(TextBox3.Text);
            egt.Ogrsay = Convert.ToInt16( TextBox4.Text);
            egt.Icerik = TextBox5.Text;
            egt.Egitimkod = TextBox6.Text;
            a = egtCRUD.guncelle(egt);
            if (a)
                Label7.Text = "Başarılı";
            else
                Label7.Text = "Başarısız";


        }
    }
}