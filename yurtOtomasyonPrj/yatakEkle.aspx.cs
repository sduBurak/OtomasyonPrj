using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yurtOtomasyonPrj
{
    public partial class yatakEkle : System.Web.UI.Page
    {
        VeriTabaniBaglanti vbn;
        VeriTabaniIslemleri vti;
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


                string yatak_numarasi = nvclc["yatak_numarasi"];
                //string yatak_durumu = nvclc["yatak_durumu"];
                bool secili_mi = yatak_durumu.Checked;
                int durum = 1;
                if (!secili_mi) durum = 0;

                string oda_id = odaCombobox.SelectedValue; ;
               



                vti = new VeriTabaniIslemleri();
                vti.yatakEkle(kaynak, yatak_numarasi, durum, oda_id);

                Response.Redirect("listYatak");
            }
            if (!IsPostBack)
            {
                vti = new VeriTabaniIslemleri();
                odaCombobox.DataSource = vti.tumOdalarıGetir(kaynak);
                odaCombobox.DataBind();

            }


        }
    }
}