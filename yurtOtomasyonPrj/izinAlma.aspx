<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="izinAlma.aspx.cs" Inherits="yurtOtomasyonPrj.izinAlma" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>

         <form method="post" action="">

            <table>
                <tr>
                    <td>Adi:</td>
                    <td><input type="text" name="personelAdi" value=""></td>
                </tr>

                  <tr>
                    <td>Soyad:</td>
                    <td><input type="text" name="personelSoyad" value=""></td>
                </tr>

                  <tr>
                    <td>Telefon Numarası:</td>
                    <td><input type="text" name="personelTel" value=""></td>
                </tr>

                 <tr>
                    <td>İzinli sayılacagı tarih:</td>
                    <td><input type="text" name="izintarihi" value=""></td>
                </tr>

                 <tr>
                    <td>Ögrenci numarası:</td>
                    <td><input type="text" name="personelkimliknumarası" value=""></td>
                </tr>

                 <tr>
                    <td>İzin alma sebebi:</td>
                    <td><input type="text"  name="izinsbp" value="" class="yükseklik"></td>
                </tr>

                <tr>
                    <td colspan="2">

                        <input type="submit" value="Gönder" class="submit">
                        
                    </td>

                </tr>
            </table>

          </form> 
    </div>
</asp:Content>
