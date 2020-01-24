<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="duyurularListele.aspx.cs" Inherits="yurtOtomasyonPrj.duyurularListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Duyuruları Listeleme Sayfası</h2>

     <div style="height: 400px;" class="sayfaArkaPlanTemplate">

        <!--<asp:GridView ID="Tournament" runat="server"> </asp:GridView>-->

             <asp:GridView ID="duyuruGridView" runat="server" AutoGenerateColumns="false"
                 DataKeyNames="id" OnPageIndexChanging="GridView1_PageIndexChanging"
                 OnRowCancelingEdit="GridView1_RowCancelingEdit"
                 OnRowDeleting="GridView1_RowDeleting"
                 OnRowEditing="GridView1_RowEditing"
                 OnRowUpdating="GridView1_RowUpdating">  
                    <Columns>  
                        <asp:BoundField DataField="id" HeaderText="Duyuru No" InsertVisible="False" ReadOnly="True" />  
                        <asp:BoundField DataField="d_icerik" HeaderText="içerik" />  
                        <asp:BoundField DataField="d_liste" HeaderText="Konu" />  
                        <asp:BoundField DataField="d_baslık" HeaderText="Başlık" />  
                         <asp:BoundField DataField="d_yayin_tarihi" HeaderText="Yayınlanma Tarihi" />  
                          <asp:BoundField DataField="d_yayın_sure" HeaderText="Yayınlanacak Süre(gün)" />  
                          <asp:BoundField DataField="d_olusturma" HeaderText="Açıklama" />  
                          
                        <asp:CommandField ShowEditButton="true" />  
                        <asp:CommandField ShowDeleteButton="true" />
                     
                    </Columns>  
                </asp:GridView> 


           <a runat="server" href="~/duyurularEkle"> <input type="button" value="Duyuru Ekle" class="submit"></a>

     </div>
</asp:Content>
