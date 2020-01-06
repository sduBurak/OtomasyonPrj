using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yurtOtomasyonPrj
{
    public partial class ogrenciEkle : System.Web.UI.Page
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


                string ogr_ad = nvclc["ogr_ad"];
                string ogr_soyad = nvclc["ogr_soyad"];

                string ogr_bolum_ad = nvclc["ogr_bolum_ad"];
                string ogr_kayit_tarihi = nvclc["ogr_kayit_tarihi"];
                DateTime dt = new DateTime();
                if ((DateTime.TryParse(Convert.ToString(ogr_kayit_tarihi), out dt)))
                {
                    //read the Date here
                    ogr_kayit_tarihi = dt.ToString("dd-MMM-yyyy");
                }

                string ogr_sinif = nvclc["ogr_sinif"];
                string ogr_tel = nvclc["ogr_tel"];
                string ogr_sehir = nvclc["ogr_sehir"];
                string ogr_kat = nvclc["ogr_kat"];
                string ogr_oda_no = nvclc["ogr_oda_no"];
                string ogr_yatak_no = nvclc["ogr_yatak_no"];
                string pkuladi = nvclc["pkuladi"];
                string psifre = nvclc["psifre"];


                DateTime now = DateTime.Now;

                VeriTabaniIslemleri vti = new VeriTabaniIslemleri();
                vti.ogrenciEkle(kaynak, ogr_ad, ogr_soyad, ogr_bolum_ad, ogr_sehir, ogr_sinif, ogr_tel,
                 Convert.ToDateTime(ogr_kayit_tarihi), Convert.ToInt32(ogr_kat), Convert.ToInt32(ogr_oda_no),
                 Convert.ToInt32(ogr_yatak_no));

                

                Response.Redirect("ogrenciListele");
            }

        }
    }
}