<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listYatak.aspx.cs" Inherits="yurtOtomasyonPrj.listYatak" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Yatak Sayfası</h2>
      <div style="height: 400px;" class="sayfaArkaPlanTemplate">

                <asp:GridView ID="yataklarGridView1" runat="server" AutoGenerateColumns="false"
                 DataKeyNames="id" OnPageIndexChanging="GridView1_PageIndexChanging"
                 OnRowCancelingEdit="GridView1_RowCancelingEdit"
                 OnRowDeleting="GridView1_RowDeleting"
                 OnRowEditing="GridView1_RowEditing"
                 OnRowUpdating="GridView1_RowUpdating">  
                    <Columns>  
                        <asp:BoundField DataField="id" HeaderText="Oda ID" InsertVisible="False" ReadOnly="True" />  
                        <asp:BoundField DataField="yatak_numarasi" HeaderText="Yatak Numarasi" />  
                        <asp:BoundField DataField="yatak_durumu" HeaderText="Yatak Durumu" />  
                        <asp:BoundField DataField="oda_id" HeaderText="Oda Numarası" /> 
 
                        <asp:CommandField ShowEditButton="true" />  
                        <asp:CommandField ShowDeleteButton="true" />
                         
                    </Columns>  
                   
                </asp:GridView> 


           <a runat="server" href="~/yatakEkle"> <input type="button" value="Yatak Ekle" class="submit"></a>
           </div>
</asp:Content>
