<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="odaEkle.aspx.cs" Inherits="yurtOtomasyonPrj.odaEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Oda Ekleme Sayfası</h2>

    
    <div style="height: 400px;" class="sayfaArkaPlanTemplate">

        <form method="post" action="personelEkle" class="tabloformları">

            <table>
                <tr>
                    <td>Oda Numarası:</td>
                    <td><input type="text" name="odaNo" value=""></td>
                </tr>

                  <tr>
                    <td>Odanın Bulunduğu Kat:</td>
                    <td><input type="text" name="oda_bul_kat" value=""></td>
                </tr>

                  <tr>
                    <td>Bilgi:</td>
                    <td><input type="text" name="bilgi" value=""></td>
                </tr>
                  <tr>
                    <td>Yatak Sayisi:</td>
                    <td><input type="text" name="yatak_sayisi" value=""></td>
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
