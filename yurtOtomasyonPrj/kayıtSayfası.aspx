<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="kayıtSayfası.aspx.cs" Inherits="yurtOtomasyonPrj.kayıtSayfası" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="height: 400px;" class="sayfaArkaPlanTemplate">

         <form method="post" action="kayıtSayfası" >
        <table>
            
               
                 <tr>
                    <td>Kullanıcı Adi:</td>
                    <td><input type="text" name="kullaniciAdi"  runat="server"></td>
                 </tr>

                    <tr>
                        <td>Kullanıcı şifre:</td>
                        <td><input type="text" name="kullaniciSifre" runat="server"></td>
                    </tr>

                     <tr>
                        <td colspan="2">
                         <input type="submit" value="Giris" class="submit">
                              <input type="submit" value="Facebook" class="submit">
                              <input type="submit" value="Google" class="submit">
                        </td>

                    </tr>

               
            

        </table>
              </form> 

    </div>

</asp:Content>
