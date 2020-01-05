<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="yatakEkle.aspx.cs" Inherits="yurtOtomasyonPrj.yatakEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2>Yatak Ekleme Sayfası</h2>
    <div style="height: 400px;" class="sayfaArkaPlanTemplate">

        <form method="post" action="personelEkle" class="tabloformları">

            <table>
                <tr>
                    <td>Yatak Numarası:</td>
                    <td><input type="text" name="yatak_numarasi" value=""></td>
                </tr>

                  <tr>
                    <td>Yatak Durumu(Dolu/Bos):</td>
                    <td>
                       
                        <asp:CheckBox ID="yatak_durumu" runat="server"/>
        

                    </td>
                </tr>
                 <tr>
                    <td>Oda Numarası:</td>
                    <td>
                         <asp:DropDownList ID="odaCombobox" runat="server"
    DataTextField="oda_numarasi" DataValueField = "oda_numarasi" AppendDataBoundItems = "true">
    <asp:ListItem Text="Please select" Value="" />
</asp:DropDownList>

                    </td>
                </tr>
               
                 
                <tr>
                    <td colspan="2">

                        <input type="submit" value="Ekle" class="submit">
                    </td>

                </tr>
            </table>

</form> 

    </div>
</asp:Content>
