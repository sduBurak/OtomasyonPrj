<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="personelProfile.aspx.cs" Inherits="yurtOtomasyonPrj.personelProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <h2>Personel Profile Sayfası</h2>

    <div style="height: 400px;" class="sayfaArkaPlanTemplate">

        
            <table>
                <tr>
                    <td>Personel Adi:</td>
                    <td>
                       <asp:Label ID="personelADI" runat="server"></asp:Label>
                    </td>
                </tr>

                  <tr>
                       <td>Personel Soyad:</td>
                    <td>
                       <asp:Label ID="personelSoyad" runat="server"></asp:Label>
                    </td>                   
                </tr>

                  <tr>
                    <td>Personel Telefonu:</td>
                      <td> <asp:Label ID="personelTel" runat="server"></asp:Label></td>
                   
                </tr>

                 

                 <tr>
                    <td>Personel kimlik numarası:</td>
                     <td> <asp:Label ID="personelKımlık" runat="server"></asp:Label></td>
                    
                </tr>

                 <tr>
                    <td>Personel Giriş Tarihi:</td>
                     <td><asp:Label ID="personelGırıstarıhı" runat="server"></asp:Label></td>
                     
                </tr>

                 <tr>
                    <td>Personel Maaşı:</td>
                     <td> <asp:Label ID="personelMaası" runat="server"></asp:Label></td>
                  
                </tr>

                <tr>
                    <td>Personel Adres:</td>
                    <td> <asp:Label ID="personelAdres" runat="server"></asp:Label></td>
                   
                </tr>

                 <tr>
                    <td>Personel SSK No:</td>
                     <td>  <asp:Label ID="personelSskno" runat="server"></asp:Label></td>
                   
                </tr>

                <tr>
                    <td>Personel Bilgi:</td>
                    <td> <asp:Label ID="personelBilgi" runat="server"></asp:Label></td>
                    
                </tr>
               
            </table>


    </div>


</asp:Content>
