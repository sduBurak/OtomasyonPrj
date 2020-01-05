<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="odalarListele.aspx.cs" Inherits="yurtOtomasyonPrj.odalarListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Odaları Listeleme Sayfası</h2>

      <div style="height: 400px;" class="sayfaArkaPlanTemplate">

        <!--<asp:GridView ID="Tournament" runat="server"> </asp:GridView>-->

             <asp:GridView ID="odalarGridView" runat="server" AutoGenerateColumns="false"
                 DataKeyNames="id" OnPageIndexChanging="GridView1_PageIndexChanging"
                 OnRowCancelingEdit="GridView1_RowCancelingEdit"
                 OnRowDeleting="GridView1_RowDeleting"
                 OnRowEditing="GridView1_RowEditing"
                 OnRowUpdating="GridView1_RowUpdating">  
                    <Columns>  
                        <asp:BoundField DataField="id" HeaderText="Oda No" InsertVisible="False" ReadOnly="True" />  
                        <asp:BoundField DataField="oda_numarasi" HeaderText="Oda Numarasi" />  
                        <asp:BoundField DataField="oda_bul_kat" HeaderText="Bulundugu Kat" />  
                        <asp:BoundField DataField="bilgi" HeaderText="Bilgi" /> 
                        <asp:BoundField DataField="yatak_sayisi" HeaderText="Yatak Sayisi" /> 
                        
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


           <a runat="server" href="~/odaEkle"> <input type="button" value="Oda Ekle" class="submit"></a>
           </div>
</asp:Content>
