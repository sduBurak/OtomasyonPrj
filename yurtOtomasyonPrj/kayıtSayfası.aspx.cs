using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yurtOtomasyonPrj
{
    public partial class kayıtSayfası : System.Web.UI.Page
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


                string kulladi = "burak";//nvclc["kullaniciAdi"];
                string sifree = "1234";//nvclc["kullaniciSifre"];

               

                VeriTabaniIslemleri vti = new VeriTabaniIslemleri();
                vti.yetkiKontrol(kaynak,kulladi,sifree);
               /* vti.personelEkle(kaynak, personelAdi, personelSoyad, personelkimliknumarası, padres, personelTel, personelTel,
                 Convert.ToDateTime(personelgiristarihi), Convert.ToInt32(pmaas), pbilgi, psskno, "pkuladi", "psifre");
                 */
                Response.Redirect("personelListele");
            }
        }
    }
}