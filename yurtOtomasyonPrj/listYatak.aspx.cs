using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace yurtOtomasyonPrj
{
    public partial class listYatak : System.Web.UI.Page
    {
        VeriTabaniIslemleri vti;
        string kaynak = @"Data Source=DESKTOP-PDN2MT9\SQLEXPRESS;Initial Catalog=yurtotomasyon;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.yataklarListeleDoldur();
            }

            vti = new VeriTabaniIslemleri();
        }
        public void yataklarListeleDoldur()
        {

            vti = new VeriTabaniIslemleri();
            yataklarGridView1.DataSource = vti.tumYataklarıGetir(kaynak);
            yataklarGridView1.DataBind();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)yataklarGridView1.Rows[e.RowIndex];
            Label lbldeleteid = (Label)row.FindControl("id");

            int yatakId = Convert.ToInt32(yataklarGridView1.DataKeys[e.RowIndex].Value.ToString());

            vti.yatakSil(kaynak, yatakId);
            this.yataklarListeleDoldur();


        }

        

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            yataklarGridView1.EditIndex = e.NewEditIndex;
            this.yataklarListeleDoldur();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            vti = new VeriTabaniIslemleri();

            int odaId = Convert.ToInt32(yataklarGridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)yataklarGridView1.Rows[e.RowIndex];
            Label lblID = (Label)row.FindControl("id");



            string yatak_numarasi = ((TextBox)row.Cells[1].Controls[0]).Text.ToString();
            string yatak_durumu = ((TextBox)row.Cells[2].Controls[0]).Text.ToString();
            string oda_id = ((TextBox)row.Cells[3].Controls[0]).Text.ToString();
            

            yataklarGridView1.EditIndex = -1;

            //(pkod,psoyad,ptcno,padres,pevtel,pceptel,pgtarih,pmaas,pbilgi,psskno,kul_adi,psifre
            string query = "update YATAKLAR set yatak_numarasi=@yatak_numarasi,yatak_durumu=@yatak_durumu,oda_id=@oda_id WHERE id=@id";

            vti.yatakguncelle(kaynak, query, odaId, yatak_numarasi, Convert.ToInt32(yatak_durumu),oda_id);
            this.yataklarListeleDoldur();
            /* conn.Open();
             //SqlCommand cmd = new SqlCommand("SELECT * FROM detail", conn);  
             SqlCommand cmd = new SqlCommand("update detail set name='" + textName.Text + "',address='" + textadd.Text + "',country='" + textc.Text + "'where id='" + userid + "'", conn);
             cmd.ExecuteNonQuery();
             conn.Close();
             gvbind();*/
            //GridView1.DataBind();  





            yataklarGridView1.EditIndex = -1;
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            yataklarGridView1.PageIndex = e.NewPageIndex;
            this.yataklarListeleDoldur();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            yataklarGridView1.EditIndex = -1;
            this.yataklarListeleDoldur();

        }
    }
}