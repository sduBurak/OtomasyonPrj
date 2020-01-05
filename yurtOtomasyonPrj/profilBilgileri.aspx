<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="profilBilgileri.aspx.cs" Inherits="yurtOtomasyonPrj.profilBilgileri" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div>
       <h2> PROFİL BİLGİSİ</h2>

        <form method="post" action="">

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
                    <td>Personel Adres:</td>
                    <td><input type="text" name="personeladres" value=""></td>
                </tr>
               
            </table>

          </form>

   </div>
</asp:Content>
