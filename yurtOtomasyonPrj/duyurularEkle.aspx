<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="duyurularEkle.aspx.cs" Inherits="yurtOtomasyonPrj.duyurularEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2>Duyuru Ekleme Sayfası</h2>

     <div style="height: 400px;" class="sayfaArkaPlanTemplate">
         <form method="post" action="">

            <table>
                <tr>
                    <td>Duyuru İçerik:</td>
                    <td><input type="text" name="d_icerik" value=""></td>
                </tr>

                  <tr>
                    <td>Duyuru Konu:</td>
                    <td><input type="text" name="d_liste" value=""></td>
                </tr>

                  <tr>
                    <td>Duyuru Başlık:</td>
                    <td><input type="text" name="d_baslık" value=""></td>
                </tr>

                 <tr>
                    <td>Duyuru Yayınlanma Tarihi:</td>
                    <td><input type="text" name="d_yayin_tarihi" value=""></td>
                </tr>

                 <tr>
                    <td>Duyuru Yayınlanacak Süre(gün):</td>
                    <td><input type="text" name="d_yayın_sure" value=""></td>
                </tr>

                <tr>
                    <td>Duyuru Açıklama:</td>
                    <td><input type="text" name="d_olusturma" value=""></td>
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
