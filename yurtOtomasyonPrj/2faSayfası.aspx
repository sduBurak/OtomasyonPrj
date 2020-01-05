<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="2faSayfası.aspx.cs" Inherits="yurtOtomasyonPrj._2faSayfası" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
           <div style="height: 400px;" class="sayfaArkaPlanTemplate">
        <table>
            <tr>
                <form method="post" action="" >
                 <tr>
                    <td>Kod Giriniz:</td>
                    <td><input type="text" name="kod" value=""></td>
                 </tr>
                   
                     <tr>
                        <td colspan="2">
                            <a runat="server" href="~/duyurularGorunum"> <input type="submit" value="Giriş" class="submit"></a> 
                        </td>

                    </tr>

                </form> 
            </tr>

        </table>

    </div>
</asp:Content>
