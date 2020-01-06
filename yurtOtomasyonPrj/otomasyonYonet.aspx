<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="otomasyonYonet.aspx.cs" Inherits="yurtOtomasyonPrj.otomasyonYonet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div>
        <h2>Yurt Yonetimi</h2>

        <div style="height: 400px;">
            <table class="otomasyonYonetDiv">

                <tr>
                    <td>
                        <a class="yonetimButton" runat="server" href="~/personelListele">Personel Listele</a>
                       
                    </td>
                
                    <td>
                        <a class="yonetimButton" runat="server" href="~/listYatak">Yatak Listele</a>
                       
                    </td>
                
                    <td>
                        <a class="yonetimButton" runat="server" href="~/odalarListele">Odalar Listele</a>
                       
                    </td>
                    
                </tr>

                <tr>
                     <td>
                        <a class="yonetimButton" runat="server" href="~/ogrenciListele">Ögrenci Listele</a>
                       
                    </td>

                    
                </tr>

               

                 <tr>
                    <td>
                        <a class="yonetimButton" runat="server" href="~/duyurularListele">Duyuruları Listele</a>
                       
                    </td>
                    <td>
                        <a class="yonetimButton" runat="server" href="~/duyurularEkle">Duyuru Ekle</a>
                       
                    </td>
                    <td>
                        <a class="yonetimButton" runat="server" href="~/duyurularEkle">Duyuru Güncelle</a>
                       
                    </td>
                </tr>

            </table>

        </div>

    </div>

</asp:Content>
