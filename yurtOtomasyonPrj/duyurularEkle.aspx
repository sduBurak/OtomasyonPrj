<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="duyurularEkle.aspx.cs" Inherits="yurtOtomasyonPrj.duyurularEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2>Duyuru Ekleme Sayfası</h2>

     <div style="height: 400px;" class="sayfaArkaPlanTemplate">
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
                                            <td colspan="2">

                                                <input type="submit" value="Submit" class="submit">
                                            </td>

                                        </tr>
                                    </table>

                        </form> 

     </div>
</asp:Content>
