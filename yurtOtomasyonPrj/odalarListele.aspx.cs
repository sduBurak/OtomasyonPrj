using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yurtOtomasyonPrj
{
    public partial class odalarListele : System.Web.UI.Page
    {
        VeriTabaniIslemleri vti;
        string kaynak = @"Data Source=DESKTOP-PDN2MT9\SQLEXPRESS;Initial Catalog=yurtotomasyon;Integrated Security=True";
        
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    this.odalarListeleDoldur();
                }

                vti = new VeriTabaniIslemleri();

            }
            public void odalarListeleDoldur()
            {

                vti = new VeriTabaniIslemleri();
                odalarGridView.DataSource = vti.tumOdalarıGetir(kaynak);
                odalarGridView.DataBind();
            }
            protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
            {
                GridViewRow row = (GridViewRow)odalarGridView.Rows[e.RowIndex];
                Label lbldeleteid = (Label)row.FindControl("id");

                int odaId = Convert.ToInt32(odalarGridView.DataKeys[e.RowIndex].Value.ToString());

                vti.odaSil(kaynak, odaId);
                this.odalarListeleDoldur();


            }

            public void ButtonAdd_Click(object sender, EventArgs e)
            {
                // Some code
                GridViewRow clickedRow = ((LinkButton)sender).NamingContainer as GridViewRow;
                Label lblID = (Label)clickedRow.FindControl("lblID");
                int index = clickedRow.RowIndex;
                int odaId = Convert.ToInt32(odalarGridView.DataKeys[index].Value.ToString());
                Response.Redirect("personelProfile.aspx?odaId=" + odaId);
            }

            protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
            {
                odalarGridView.EditIndex = e.NewEditIndex;
                this.odalarListeleDoldur();
            }
            protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
            {
                vti = new VeriTabaniIslemleri();

                int odaId = Convert.ToInt32(odalarGridView.DataKeys[e.RowIndex].Value.ToString());
                GridViewRow row = (GridViewRow)odalarGridView.Rows[e.RowIndex];
                Label lblID = (Label)row.FindControl("id");



                string oda_no = ((TextBox)row.Cells[1].Controls[0]).Text.ToString();
                string oda_bul_kat = ((TextBox)row.Cells[2].Controls[0]).Text.ToString();
                string bilgi = ((TextBox)row.Cells[3].Controls[0]).Text.ToString();
                string yatak_sayisi = ((TextBox)row.Cells[4].Controls[0]).Text.ToString();


            odalarGridView.EditIndex = -1;

                //(pkod,psoyad,ptcno,padres,pevtel,pceptel,pgtarih,pmaas,pbilgi,psskno,kul_adi,psifre
                string query = "update ODALAR set oda_numarasi=@oda_numarasi,oda_bul_kat=@oda_bul_kat,bilgi=@bilgi,yatak_sayisi=@yatak_sayisi WHERE id=@id";
            
                vti.odaguncelle(kaynak, query, odaId, oda_no, Convert.ToInt32(oda_bul_kat), bilgi, Convert.ToInt32(yatak_sayisi));
                this.odalarListeleDoldur();
                /* conn.Open();
                 //SqlCommand cmd = new SqlCommand("SELECT * FROM detail", conn);  
                 SqlCommand cmd = new SqlCommand("update detail set name='" + textName.Text + "',address='" + textadd.Text + "',country='" + textc.Text + "'where id='" + userid + "'", conn);
                 cmd.ExecuteNonQuery();
                 conn.Close();
                 gvbind();*/
                //GridView1.DataBind();  





                odalarGridView.EditIndex = -1;
            }
            protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
            {
                odalarGridView.PageIndex = e.NewPageIndex;
                this.odalarListeleDoldur();
            }
            protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
            {
                odalarGridView.EditIndex = -1;
                this.odalarListeleDoldur();

            }

        
    }
}