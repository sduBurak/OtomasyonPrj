<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ogrenciListele.aspx.cs" Inherits="yurtOtomasyonPrj.ogrenciListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Ögrenci Listeleme Sayfası</h2>

     <div style="height: 400px;" class="sayfaArkaPlanTemplate">

        <!--<asp:GridView ID="Tournament" runat="server"> </asp:GridView>-->

             <asp:GridView ID="ogrenciGridView" runat="server" AutoGenerateColumns="false"
                 DataKeyNames="id" OnPageIndexChanging="GridView1_PageIndexChanging"
                 OnRowCancelingEdit="GridView1_RowCancelingEdit"
                 OnRowDeleting="GridView1_RowDeleting"
                 OnRowEditing="GridView1_RowEditing"
                 OnRowUpdating="GridView1_RowUpdating">  
                    <Columns>  
                        <asp:BoundField DataField="id" HeaderText="Ögrenci No" InsertVisible="False" ReadOnly="True" />  
                        <asp:BoundField DataField="ogr_ad" HeaderText="Isim" />  
                        <asp:BoundField DataField="ogr_soyad" HeaderText="Soyisim" />  
                        <asp:BoundField DataField="ogr_bolum_ad" HeaderText="Bolüm Adı" />  
                         <asp:BoundField DataField="ogr_sinif" HeaderText="Sınıfı" />  
                          <asp:BoundField DataField="ogr_tel" HeaderText="Telefon Numarası" />  
                          <asp:BoundField DataField="ogr_sehir" HeaderText="Şehir" />  
                          <asp:BoundField DataField="ogr_kayit_tarihi" HeaderText="Kayıt Tarihi" />  
                          <asp:BoundField DataField="ogr_kat" HeaderText="Kat" />  
                          <asp:BoundField DataField="ogr_oda_no" HeaderText="Oda Numarası" />  
                          <asp:BoundField DataField="ogr_yatak_no" HeaderText="Yatak Numarası" />  
                        <asp:CommandField ShowEditButton="true" />  
                        <asp:CommandField ShowDeleteButton="true" />
                     
                    </Columns>  
                </asp:GridView> 


           <a runat="server" href="~/ogrenciEkle"> <input type="button" value="Personel Ekle" class="submit"></a>

     </div>
</asp:Content>
