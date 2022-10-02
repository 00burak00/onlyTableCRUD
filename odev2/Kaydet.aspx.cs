using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace odev2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            egitimCRUD egtcrd = new egitimCRUD();
            bool cvp;
            egitim egt = new egitim();
            egt.Tur = TextBox1.Text;
            egt.Adi = TextBox2.Text;
            egt.Tarih = Convert.ToDateTime(TextBox3.Text);
            egt.Ogrsay = Convert.ToInt32(TextBox4.Text);
            egt.Icerik = TextBox5.Text;
            egt.Egitimkod = TextBox6.Text;
            cvp = egtcrd.kaydet(egt);
            if (cvp)
                Label7.Text = "Başarılı";
            else
                Label7.Text = "Başarısız";
        }
    }
}