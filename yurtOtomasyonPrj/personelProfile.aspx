<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="personelProfile.aspx.cs" Inherits="yurtOtomasyonPrj.personelProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <h2>Kitap Profile Sayfası</h2>

    <div style="height: 400px;" class="sayfaArkaPlanTemplate">

        
            <table>
                <tr>
                    <td>Kitap Adi:</td>
                    <td>
                       <asp:Label ID="personelADI" runat="server"></asp:Label>
                    </td>
                </tr>

                  <tr>
                       <td>Kitap yazarı:</td>
                    <td>
                       <asp:Label ID="personelSoyad" runat="server"></asp:Label>
                    </td>                   
                </tr>

                  <tr>
                    <td>Kitap sayısı:</td>
                      <td> <asp:Label ID="personelTel" runat="server"></asp:Label></td>
                   
                </tr>

                 

                 <tr>
                    <td>Kitap Raf numarası:</td>
                     <td> <asp:Label ID="personelKımlık" runat="server"></asp:Label></td>
                    
                </tr>

                 <tr>
                    <td>Kitap Kayıt Tarihi:</td>
                     <td><asp:Label ID="personelGırıstarıhı" runat="server"></asp:Label></td>
                     
                </tr>

                 <tr>
                    <td>Kitap Sayfası:</td>
                     <td> <asp:Label ID="personelMaası" runat="server"></asp:Label></td>
                  
                </tr>

                <tr>
                    <td>Basım Yılı:</td>
                    <td> <asp:Label ID="personelAdres" runat="server"></asp:Label></td>
                   
                </tr>

                 <tr>
                    <td>Kitap Seri Numarası:</td>
                     <td>  <asp:Label ID="personelSskno" runat="server"></asp:Label></td>
                   
                </tr>

                <tr>
                    <td>Kitap Bilgi:</td>
                    <td> <asp:Label ID="personelBilgi" runat="server"></asp:Label></td>
                    
                </tr>
               
            </table>


    </div>


</asp:Content>
