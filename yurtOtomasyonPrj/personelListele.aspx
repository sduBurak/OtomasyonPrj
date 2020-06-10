<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="personelListele.aspx.cs" Inherits="yurtOtomasyonPrj.personelListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Kitap Listeleme Sayfası</h2>

     <div style="height: 400px;" class="sayfaArkaPlanTemplate">

        <!--<asp:GridView ID="Tournament" runat="server"> </asp:GridView>-->

             <asp:GridView ID="personelGridView" runat="server" AutoGenerateColumns="false"
                 DataKeyNames="id" OnPageIndexChanging="GridView1_PageIndexChanging"
                 OnRowCancelingEdit="GridView1_RowCancelingEdit"
                 OnRowDeleting="GridView1_RowDeleting"
                 OnRowEditing="GridView1_RowEditing"
                 OnRowUpdating="GridView1_RowUpdating">  
                    <Columns>  
                        <asp:BoundField DataField="id" HeaderText="Kitap No" InsertVisible="False" ReadOnly="True" />  
                        <asp:BoundField DataField="pkod" HeaderText="Kitap Adı" />  
                        <asp:BoundField DataField="psoyad" HeaderText="Yazarı" />  
                        <asp:BoundField DataField="ptcno" HeaderText="Raf No" />  
                         <asp:BoundField DataField="padres" HeaderText="Basım Yılı" />  
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


           <a runat="server" href="~/personelEkle"> <input type="button" value="Kitap Ekle" class="submit"></a>

     </div>



     
</asp:Content>
    