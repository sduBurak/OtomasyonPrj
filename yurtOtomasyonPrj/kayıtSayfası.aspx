<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="kayıtSayfası.aspx.cs" Inherits="yurtOtomasyonPrj.kayıtSayfası" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div style="height: 400px;" class="sayfaArkaPlanTemplate">
        <table>
            <tr>
                <form method="post" action="" >
                 <tr>
                    <td>Kullanıcı Adi:</td>
                    <td><input type="text" name="kullanıcıAdi" value=""></td>
                 </tr>

                    <tr>
                        <td>Kullanıcı şifre:</td>
                        <td><input type="text" name="kullanıcıSifre" value=""></td>
                    </tr>

                     <tr>
                        <td colspan="2">
                            <a runat="server" href="~/2faSayfası"> <input type="button" value="Giriş" class="button"></a> 
                              <input type="submit" value="Facebook" class="submit">
                              <input type="submit" value="Google" class="submit">
                        </td>

                    </tr>

                </form> 
            </tr>

        </table>

    </div>

</asp:Content>
