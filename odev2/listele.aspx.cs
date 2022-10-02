using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace odev2
{
    public partial class listele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            egitimCRUD ogrcrd = new egitimCRUD();
            DataTable dt = new DataTable();
            dt = ogrcrd.listeleme();
            if (Request.QueryString["prm"] == null)
            {
                list.InnerHtml += "<table style='padding-left:450px'>";
                list.InnerHtml += "<tr> <td>Tür</td> <td>Adı</td> <td>Tarih</td> <td>Öğrenci Sayısı</td> <td>İçerik</td> <td>Eğitim Kodu</td> <td>Sil</td> <td>Güncelle</td> </tr>";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    list.InnerHtml += "<tr> <td>" + dt.Rows[i][0] + "</td> <td>" + dt.Rows[i][1] + "</td> <td>" + dt.Rows[i][2] + "</td> <td>" + dt.Rows[i][3] + "</td> <td>" + dt.Rows[i][4] + "</td> <td>" + dt.Rows[i][5] + "</td> <td><a href='liste.aspx?prm=" + dt.Rows[i][5] + "'>Sil</a></td> <td><a href='guncelle.aspx?prm=" + dt.Rows[i][5] + "'>Güncelle</a></td> </tr>";
                }
                list.InnerHtml += "</table>";
            }
            else
            {
                bool cvp = ogrcrd.sil(Request.QueryString["prm"]);
                if (cvp)
                    list.InnerHtml = "Başarılı";
                else
                    list.InnerHtml = "Başarısız";
            }
        }
    }
}