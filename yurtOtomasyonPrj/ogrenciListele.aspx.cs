using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yurtOtomasyonPrj
{
    public partial class ogrenciListele : System.Web.UI.Page
    {
        VeriTabaniIslemleri vti;
        string kaynak = @"Data Source=DESKTOP-PDN2MT9\SQLEXPRESS;Initial Catalog=yurtotomasyon;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ogrenciListeleDoldur();
            }

            vti = new VeriTabaniIslemleri();

        }
        public void ogrenciListeleDoldur()
        {

            vti = new VeriTabaniIslemleri();
            ogrenciGridView.DataSource = vti.tumOgrenciGetir(kaynak);
            ogrenciGridView.DataBind();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)ogrenciGridView.Rows[e.RowIndex];
            Label lbldeleteid = (Label)row.FindControl("id");

            int ogr_id = Convert.ToInt32(ogrenciGridView.DataKeys[e.RowIndex].Value.ToString());

            vti.ogrencıSil(kaynak, ogr_id);
            this.ogrenciListeleDoldur();


        }

       

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            ogrenciGridView.EditIndex = e.NewEditIndex;
            this.ogrenciListeleDoldur();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            vti = new VeriTabaniIslemleri();

            int personelId = Convert.ToInt32(ogrenciGridView.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)ogrenciGridView.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("id");


            string ogr_ad = ((TextBox)row.Cells[1].Controls[0]).Text.ToString();
            string ogr_soyad = ((TextBox)row.Cells[2].Controls[0]).Text.ToString();
            string ogr_bolum_ad = ((TextBox)row.Cells[3].Controls[0]).Text.ToString();
            string ogr_sinif = ((TextBox)row.Cells[4].Controls[0]).Text.ToString();
            string ogr_tel = ((TextBox)row.Cells[5].Controls[0]).Text.ToString();
            string ogr_sehir = ((TextBox)row.Cells[6].Controls[0]).Text.ToString();
            string ogr_kayit_tarihi = ((TextBox)row.Cells[7].Controls[0]).Text.ToString();
            string ogr_kat = ((TextBox)row.Cells[8].Controls[0]).Text.ToString();
            string ogr_oda_no = ((TextBox)row.Cells[9].Controls[0]).Text.ToString();
            string ogr_yatak_no = ((TextBox)row.Cells[10].Controls[0]).Text.ToString();


            ogrenciGridView.EditIndex = -1;

            //(pkod,psoyad,ptcno,padres,pevtel,pceptel,pgtarih,pmaas,pbilgi,psskno,kul_adi,psifre
            string query = "update OGRENCILER set ogr_ad=@ogr_ad,ogr_soyad=@ogr_soyad,ogr_bolum_ad=@ogr_bolum_ad,ogr_sinif=@ogr_sinif,ogr_tel=@ogr_tel," +
                "ogr_sehir=@ogr_sehir,ogr_kayit_tarihi=@ogr_kayit_tarihi,ogr_kat=@ogr_kat,ogr_oda_no=@ogr_oda_no,ogr_yatak_no=@ogr_yatak_no WHERE id=@ID";

            vti.ogrencıguncelle(kaynak, query, personelId, ogr_ad, ogr_soyad, ogr_bolum_ad, ogr_sinif, ogr_tel, ogr_sehir,
                 Convert.ToDateTime(ogr_kayit_tarihi),ogr_kat,ogr_oda_no,
                ogr_yatak_no);
            this.ogrenciListeleDoldur();
            /* conn.Open();
             //SqlCommand cmd = new SqlCommand("SELECT * FROM detail", conn);  
             SqlCommand cmd = new SqlCommand("update detail set name='" + textName.Text + "',address='" + textadd.Text + "',country='" + textc.Text + "'where id='" + userid + "'", conn);
             cmd.ExecuteNonQuery();
             conn.Close();
             gvbind();*/
            //GridView1.DataBind();  





            ogrenciGridView.EditIndex = -1;
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ogrenciGridView.PageIndex = e.NewPageIndex;
            this.ogrenciListeleDoldur();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            ogrenciGridView.EditIndex = -1;
            this.ogrenciListeleDoldur();

        }
    }
}