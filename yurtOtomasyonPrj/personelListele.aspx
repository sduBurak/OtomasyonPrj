<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="personelListele.aspx.cs" Inherits="yurtOtomasyonPrj.personelListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Personel Listeleme Sayfası</h2>

     <div style="height: 400px;" class="sayfaArkaPlanTemplate">

        <!--<asp:GridView ID="Tournament" runat="server"> </asp:GridView>-->

             <asp:GridView ID="personelGridView" runat="server" AutoGenerateColumns="false"
                 DataKeyNames="id" OnPageIndexChanging="GridView1_PageIndexChanging"
                 OnRowCancelingEdit="GridView1_RowCancelingEdit"
                 OnRowDeleting="GridView1_RowDeleting"
                 OnRowEditing="GridView1_RowEditing"
                 OnRowUpdating="GridView1_RowUpdating">  
                    <Columns>  
                        <asp:BoundField DataField="id" HeaderText="Personel No" InsertVisible="False" ReadOnly="True" />  
                        <asp:BoundField DataField="pkod" HeaderText="Isim" />  
                        <asp:BoundField DataField="psoyad" HeaderText="Soyisim" />  
                        <asp:BoundField DataField="ptcno" HeaderText="Tc No" />  
                         <asp:BoundField DataField="padres" HeaderText="Adres" />  
                        <asp:CommandField ShowEditButton="true" />  
                        <asp:CommandField ShowDeleteButton="true" />
                         <asp:TemplateField HeaderText="">
                <ItemTemplate>
                 <asp:LinkButton ID="ButtonAdd" runat="server" Text="Profile" 
                        onclick="ButtonAdd_Click" CssClass="grvAddButton" OnClientClick="return ValidateEmptyValue();return validate()" />
                </ItemTemplate>
            </asp:TemplateField>
                    </Columns>  
                </asp:GridView> 


           <a runat="server" href="~/personelEkle"> <input type="button" value="Personel Ekle" class="submit"></a>

     </div>



     
</asp:Content>
    