<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="personelEkle.aspx.cs" Inherits="yurtOtomasyonPrj.personelEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Personel Ekleme Sayfası</h2>

    <div style="height: 400px;" class="sayfaArkaPlanTemplate">

        <form method="post" action="personelEkle" class="tabloformları">

            <table>
                <tr>
                    <td>Personel Adi:</td>
                    <td><input type="text" name="personelAdi" value=""></td>
                </tr>

                  <tr>
                    <td>Personel Soyad:</td>
                    <td><input type="text" name="personelSoyad" value=""></td>
                </tr>

                  <tr>
                    <td>Personel Teli:</td>
                    <td><input type="text" name="personelTel" value=""></td>
                </tr>

                 <tr>
                    <td>Personel Yaşı:</td>
                    <td><input type="text" name="personelyası" value=""></td>
                </tr>

                 <tr>
                    <td>Personel kimlik numarası:</td>
                    <td><input type="text" name="personelkimliknumarası" value=""></td>
                </tr>

                 <tr>
                    <td>Personel Giriş Tarihi:</td>
                    <td>
                        
                        <input type="text" name="personelgiristarihi" value="">

                    </td>
                </tr>

                 <tr>
                    <td>Personel Maaşı:</td>
                    <td><input type="text" name="personelmaas" value=""></td>
                </tr>

                <tr>
                    <td>Personel Adres:</td>
                    <td><input type="text" name="personeladres" value=""></td>
                </tr>

                 <tr>
                    <td>Personel SSK No:</td>
                    <td><input type="text" name="personelsskno" value=""></td>
                </tr>

                <tr>
                    <td>Personel Bilgi:</td>
                    <td><input type="text" name="personelbilgi" value=""></td>
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
