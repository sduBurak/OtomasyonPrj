using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yurtOtomasyonPrj
{
    public partial class personelProfile : System.Web.UI.Page
    {
        VeriTabaniIslemleri vbn;
        protected void Page_Load(object sender, EventArgs e)
        {
            Uri myUri = new Uri(Request.Url.AbsoluteUri);
            string param1 = HttpUtility.ParseQueryString(myUri.Query).Get("personelId");

            string kaynak = @"Data Source=DESKTOP-PDN2MT9\SQLEXPRESS;Initial Catalog=yurtotomasyon;Integrated Security=True";
          

            vbn = new VeriTabaniIslemleri();
            DataTable dt = vbn.seciliPersonelGetir(kaynak,Convert.ToInt32(param1));

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                personelADI.Text = row["pkod"].ToString();
                personelSoyad.Text = row["psoyad"].ToString();
                personelTel.Text = row["pevtel"].ToString();
                personelKımlık.Text = row["ptcno"].ToString();
                personelGırıstarıhı.Text = row["pgtarih"].ToString();
                personelMaası.Text = row["pmaas"].ToString();
                personelAdres.Text = row["padres"].ToString();
                personelSskno.Text = row["psskno"].ToString();
                personelBilgi.Text = row["pbilgi"].ToString();

            }

        }
    }
}