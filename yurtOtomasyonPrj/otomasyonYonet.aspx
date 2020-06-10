<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="otomasyonYonet.aspx.cs" Inherits="yurtOtomasyonPrj.otomasyonYonet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div>
        <h2>Kütüphane Yönetimi</h2>

        <div style="height: 400px;">
            <table class="otomasyonYonetDiv">

                <tr>
                    <td>
                        <a class="yonetimButton" runat="server" href="~/personelListele">Kitapları Listele</a>
                       
                    </td>
                
                    <td>
                        
                       
                    </td>
                
                    <td>
                       
                       
                    </td>
                    
                </tr>

                <tr>
                     <td>
                        <a class="yonetimButton" runat="server" href="~/ogrenciListele">Ögrenci Listele</a>
                       
                    </td>

                    
              
                    <td>
                        <a class="yonetimButton" runat="server" href="~/duyurularListele">Duyuruları Listele</a>
                       
                    </td>
                   
                   
                </tr>

            </table>

        </div>

    </div>

</asp:Content>
