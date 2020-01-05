using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yurtOtomasyonPrj
{
    public partial class personelListele : System.Web.UI.Page
    {
        VeriTabaniIslemleri vti;
        string kaynak = @"Data Source=DESKTOP-PDN2MT9\SQLEXPRESS;Initial Catalog=yurtotomasyon;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.personelListeleDoldur();
            }

            vti = new VeriTabaniIslemleri();

        }
        public void personelListeleDoldur() {

            vti = new VeriTabaniIslemleri();
            personelGridView.DataSource = vti.tumPersonelGetir(kaynak);
            personelGridView.DataBind();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)personelGridView.Rows[e.RowIndex];
            Label lbldeleteid = (Label)row.FindControl("id");

            int personelId = Convert.ToInt32(personelGridView.DataKeys[e.RowIndex].Value.ToString());

            vti.personelSil(kaynak, personelId);
            this.personelListeleDoldur();


        }
        
        public void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Some code
            GridViewRow clickedRow = ((LinkButton)sender).NamingContainer as GridViewRow;
            Label lblID = (Label)clickedRow.FindControl("lblID");
            int index = clickedRow.RowIndex;
            int personelId = Convert.ToInt32(personelGridView.DataKeys[index].Value.ToString());
            Response.Redirect("personelProfile.aspx?personelId=" + personelId);
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            personelGridView.EditIndex = e.NewEditIndex;
            this.personelListeleDoldur();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            vti = new VeriTabaniIslemleri();

            int personelId = Convert.ToInt32(personelGridView.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)personelGridView.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("id");


            string personelAd = ((TextBox)row.Cells[1].Controls[0]).Text.ToString();
            string personelSoyad = ((TextBox)row.Cells[2].Controls[0]).Text.ToString();
            string ptc = ((TextBox)row.Cells[3].Controls[0]).Text.ToString();
            string padres = ((TextBox)row.Cells[4].Controls[0]).Text.ToString();


            personelGridView.EditIndex = -1;

            //(pkod,psoyad,ptcno,padres,pevtel,pceptel,pgtarih,pmaas,pbilgi,psskno,kul_adi,psifre
            string query = "update PERSONEL set pkod=@pkod,psoyad=@psoyad,ptcno=@ptcno,padres=@padres WHERE id=@ID";
          
            vti.personelguncelle(kaynak, query, personelId, personelAd, personelSoyad,ptc, padres);
            this.personelListeleDoldur();
            /* conn.Open();
             //SqlCommand cmd = new SqlCommand("SELECT * FROM detail", conn);  
             SqlCommand cmd = new SqlCommand("update detail set name='" + textName.Text + "',address='" + textadd.Text + "',country='" + textc.Text + "'where id='" + userid + "'", conn);
             cmd.ExecuteNonQuery();
             conn.Close();
             gvbind();*/
            //GridView1.DataBind();  





            personelGridView.EditIndex = -1;
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            personelGridView.PageIndex = e.NewPageIndex;
            this.personelListeleDoldur();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            personelGridView.EditIndex = -1;
            this.personelListeleDoldur();

        }
    }
}