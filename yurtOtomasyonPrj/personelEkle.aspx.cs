using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yurtOtomasyonPrj
{
    public partial class personelEkle : System.Web.UI.Page
    {
        VeriTabaniBaglanti vbn;
        protected void Page_Load(object sender, EventArgs e)
        {

            string kaynak = @"Data Source=DESKTOP-PDN2MT9\SQLEXPRESS;Initial Catalog=yurtotomasyon;Integrated Security=True";
            string kullanici = "";
            string sifre = "";

            NameValueCollection nvclc = Request.Form;

            if (nvclc.Count != 0 )
            {
                vbn = new VeriTabaniBaglanti(kaynak, kullanici, sifre);

                bool baglan = vbn.isBaglanti();

               
                string personelAdi = nvclc["personelAdi"];
                string personelSoyad = nvclc["personelSoyad"];

                string personelTel = nvclc["personelTel"];
                string personelgiristarihi = nvclc["personelgiristarihi"];
                DateTime dt = new DateTime();
                if ((DateTime.TryParse(Convert.ToString(personelgiristarihi), out dt)))
                {
                    //read the Date here
                    personelgiristarihi = dt.ToString("dd-MMM-yyyy");
                }

                string personelkimliknumarası = nvclc["personelkimliknumarası"];
                string padres = nvclc["personeladres"];
                string pmaas = nvclc["personelmaas"];
                string pbilgi = nvclc["personelbilgi"];
                string psskno = nvclc["personelsskno"];
                string pkuladi = nvclc["pkuladi"];
                string psifre = nvclc["psifre"];


                DateTime now = DateTime.Now;

                VeriTabaniIslemleri vti = new VeriTabaniIslemleri();
                vti.personelEkle(kaynak, personelAdi, personelSoyad, personelkimliknumarası, padres, personelTel, personelTel,
                 Convert.ToDateTime(personelgiristarihi)  , Convert.ToInt32(pmaas), pbilgi, psskno,"pkuladi","psifre");

                Response.Redirect("personelListele");
            }
           
        }
    }
}