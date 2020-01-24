using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yurtOtomasyonPrj
{
    public partial class duyurularListele : System.Web.UI.Page
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
            duyuruGridView.DataSource = vti.tumDuyuruGetir(kaynak);
            duyuruGridView.DataBind();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)duyuruGridView.Rows[e.RowIndex];
            Label lbldeleteid = (Label)row.FindControl("id");

            int ogr_id = Convert.ToInt32(duyuruGridView.DataKeys[e.RowIndex].Value.ToString());

            vti.duyuruSil(kaynak, ogr_id);
            this.ogrenciListeleDoldur();


        }



        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            duyuruGridView.EditIndex = e.NewEditIndex;
            this.ogrenciListeleDoldur();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            vti = new VeriTabaniIslemleri();

            int personelId = Convert.ToInt32(duyuruGridView.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)duyuruGridView.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("id");


            string d_icerik = ((TextBox)row.Cells[1].Controls[0]).Text.ToString();
            string d_liste = ((TextBox)row.Cells[2].Controls[0]).Text.ToString();
            string d_baslık = ((TextBox)row.Cells[3].Controls[0]).Text.ToString();
            string d_yayin_tarihi = ((TextBox)row.Cells[4].Controls[0]).Text.ToString();
            string d_yayın_sure = ((TextBox)row.Cells[5].Controls[0]).Text.ToString();
            string d_olusturma = ((TextBox)row.Cells[6].Controls[0]).Text.ToString();
           


            duyuruGridView.EditIndex = -1;

            //(pkod,psoyad,ptcno,padres,pevtel,pceptel,pgtarih,pmaas,pbilgi,psskno,kul_adi,psifre
            string query = "update DUYURULAR set d_icerik=@d_icerik,d_liste=@d_liste,d_baslık=@d_baslık,d_yayin_tarihi=@d_yayin_tarihi,d_yayın_sure=@d_yayın_sure," +
                "d_olusturma=@d_olusturma WHERE id=@ID";

            vti.duyuruguncelle(kaynak, query, personelId, d_icerik, d_liste, d_baslık, Convert.ToDateTime(d_yayin_tarihi),
                d_yayın_sure, d_olusturma);
            this.ogrenciListeleDoldur();
            /* conn.Open();
             //SqlCommand cmd = new SqlCommand("SELECT * FROM detail", conn);  
             SqlCommand cmd = new SqlCommand("update detail set name='" + textName.Text + "',address='" + textadd.Text + "',country='" + textc.Text + "'where id='" + userid + "'", conn);
             cmd.ExecuteNonQuery();
             conn.Close();
             gvbind();*/
            //GridView1.DataBind();  





            duyuruGridView.EditIndex = -1;
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            duyuruGridView.PageIndex = e.NewPageIndex;
            this.ogrenciListeleDoldur();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            duyuruGridView.EditIndex = -1;
            this.ogrenciListeleDoldur();

        }
    }
}