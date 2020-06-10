<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="yurtOtomasyonPrj._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        
                    <div id="myCarousel" class="carousel slide" data-ride="carousel">
              <!-- Indicators -->
              <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
                <li data-target="#myCarousel" data-slide-to="2"></li>
              </ol>

              <!-- Wrapper for slides -->
              <div class="carousel-inner">
                <div class="item active">
                  <img src="/resimler/k8jpg.jpg" alt="Los Angeles">
                </div>

                <div class="item">
                  <img src="/resimler/k2.jpg" alt="New York">
                </div>
                  <div class="item">
                  <img src="/resimler/k3.jpg" alt="tietgen">
                </div>
              </div>

              <!-- Left and right controls -->
              <a class="left carousel-control" href="#myCarousel" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left"></span>
                <span class="sr-only">Previous</span>
              </a>
              <a class="right carousel-control" href="#myCarousel" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right"></span>
                <span class="sr-only">Next</span>
              </a>
            </div>


    </div>

    <div class="row">
        <div class="col-md-4">
             <a runat="server" href="~/duyurularGorunum"> <h2>Duyurular</h2></a>
           <table>
               <tr>
                   <td colspan="2">
                       Ilk Duyuru

                   </td>
               </tr>
                <tr>
                   <td colspan="2">
                       Ikinci Duyuru

                   </td>
               </tr>

           </table>
        </div>
        <div class="col-md-4">           
            <a runat="server" href="~/odalarGorunum"> <h2>Çalışma Alanlarımız</h2></a>
           <table>
               <tr>
                   <td colspan="2">
                       Tek kişilik oda 

                   </td>
               </tr>
                <tr>
                   <td colspan="2">
                       İki kişilk oda

                   </td>
               </tr>

           </table>
        </div>
        <div class="col-md-4">
            <a runat="server" href="~/izinAlma"> <h2>Ögrenci Kitap İzni alma</h2></a>
            <p>
               ögrencilerimizzzzz...
            </p>
           
        </div>
    </div>

</asp:Content>
