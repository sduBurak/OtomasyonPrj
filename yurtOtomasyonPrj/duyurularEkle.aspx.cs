using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yurtOtomasyonPrj
{
    public partial class duyurularEkle : System.Web.UI.Page
    {
        VeriTabaniBaglanti vbn;
        protected void Page_Load(object sender, EventArgs e)
        {

            string kaynak = @"Data Source=DESKTOP-PDN2MT9\SQLEXPRESS;Initial Catalog=yurtotomasyon;Integrated Security=True";
            string kullanici = "";
            string sifre = "";

            NameValueCollection nvclc = Request.Form;

            if (nvclc.Count != 0)
            {
                vbn = new VeriTabaniBaglanti(kaynak, kullanici, sifre);

                bool baglan = vbn.isBaglanti();


                string d_icerik = nvclc["d_icerik"];
                string d_liste = nvclc["d_liste"];

                string d_baslık = nvclc["d_baslık"];
                string d_yayin_tarihi = nvclc["d_yayin_tarihi"];
                DateTime dt = new DateTime();
                if ((DateTime.TryParse(Convert.ToString(d_yayin_tarihi), out dt)))
                {
                    //read the Date here
                    d_yayin_tarihi = dt.ToString("dd-MMM-yyyy");
                }

                string d_yayın_sure = nvclc["d_yayın_sure"];
                string d_olusturma = nvclc["d_olusturma"];
               


                DateTime now = DateTime.Now;

                VeriTabaniIslemleri vti = new VeriTabaniIslemleri();
                vti.duyuruEkle(kaynak, d_icerik, d_liste, d_baslık,
                 Convert.ToDateTime(d_yayin_tarihi), Convert.ToInt32(d_yayın_sure), d_olusturma);



                Response.Redirect("duyurularListele");
            }

        }
    }
}