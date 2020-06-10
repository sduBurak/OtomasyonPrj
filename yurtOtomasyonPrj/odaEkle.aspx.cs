using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yurtOtomasyonPrj
{
    public partial class odaEkle : System.Web.UI.Page
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


                string odaNo = nvclc["odaNo"];
                string oda_bul_kat = nvclc["oda_bul_kat"];                             
                string odaBilgisi = nvclc["bilgi"];
                string yatak_sayisi = nvclc["yatak_sayisi"];


                VeriTabaniIslemleri vti = new VeriTabaniIslemleri();
                vti.odaEkle(kaynak, odaNo, Convert.ToInt32(oda_bul_kat), odaBilgisi, Convert.ToInt32(yatak_sayisi));

                Response.Redirect("odalarListele");
            }



        }
    }
}