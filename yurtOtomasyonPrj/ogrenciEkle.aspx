<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ogrenciEkle.aspx.cs" Inherits="yurtOtomasyonPrj.ogrenciEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Ögrenci Ekleme Sayfası</h2>

     <div style="height: 400px;" class="sayfaArkaPlanTemplate">
         <form method="post" action="">

            <table>
                <tr>
                    <td>Ögrenci Adi:</td>
                    <td><input type="text" name="ogr_ad" value=""></td>
                </tr>

                  <tr>
                    <td>Ögrenci Soyad:</td>
                    <td><input type="text" name="ogr_soyad" value=""></td>
                </tr>

                  <tr>
                    <td>Ögrenci Bölümü:</td>
                    <td><input type="text" name="ogr_bolum_ad" value=""></td>
                </tr>

                 <tr>
                    <td>Ögrenci Sınıfı:</td>
                    <td><input type="text" name="ogr_sinif" value=""></td>
                </tr>

                 <tr>
                    <td>Ögrenci Telefon numarası:</td>
                    <td><input type="text" name="ogr_tel" value=""></td>
                </tr>

                <tr>
                    <td>Ögrenci Yaşadığı Şehir:</td>
                    <td><input type="text" name="ogr_sehir" value=""></td>
                </tr>

                <tr>
                    <td>Ögrenci Kayıt Tarihi:</td>
                    <td><input type="text" name="ogr_kayit_tarihi" value=""></td>
                </tr>

                <tr>
                    <td>Ögrenci Kaldığı Kat:</td>
                    <td><input type="text" name="ogr_kat" value=""></td>
                </tr>

                <tr>
                    <td>Ögrenci Oda Numarası:</td>
                    <td><input type="text" name="ogr_oda_no" value=""></td>
                </tr>

                <tr>
                    <td>Ögrenci Yatak numarası:</td>
                    <td><input type="text" name="ogr_yatak_no" value=""></td>
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
