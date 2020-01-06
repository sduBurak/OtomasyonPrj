using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using static System.Collections.Specialized.BitVector32;

namespace yurtOtomasyonPrj
{
    public class VeriTabaniIslemleri : IHttpModule
    {
        /// <summary>
        /// You will need to configure this module in the Web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        public void Dispose()
        {
            //clean-up code here.
        }

        public void Init(HttpApplication context)
        {
            // Below is an example of how you can handle LogRequest event and provide 
            // custom logging implementation for it
            context.LogRequest += new EventHandler(OnLogRequest);
        }

        #endregion

        public void OnLogRequest(Object source, EventArgs e)
        {
            //custom logging logic can go here
        }


        public void personelEkle(string connectionString,string pkod, string psoyad,string ptcno,
           string padres, string pevtel, string pceptel,DateTime pgtarih,int pmaas, string pbilgi,
           string psskno, string kul_adi, string psifre)
        {
           
            string query = "insert into PERSONEL(pkod,psoyad,ptcno,padres,pevtel,pceptel,pgtarih,pmaas,pbilgi,psskno,kul_adi,psifre)"+
                " VALUES (@pkod,@psoyad,@ptcno,@padres,@pevtel,@pceptel,@pgtarih,@pmaas,@pbilgi,@psskno,@kul_adi,@psifre)";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@pkod", pkod);
                        cmd.Parameters.AddWithValue("@psoyad", psoyad);
                        cmd.Parameters.AddWithValue("@ptcno", ptcno);

                        cmd.Parameters.AddWithValue("@padres", padres);
                        cmd.Parameters.AddWithValue("@pevtel", pevtel);
                        cmd.Parameters.AddWithValue("@pceptel", pceptel);

                        cmd.Parameters.AddWithValue("@pgtarih", pgtarih);
                        cmd.Parameters.AddWithValue("@pmaas", pmaas);
                        cmd.Parameters.AddWithValue("@pbilgi", pbilgi);

                        cmd.Parameters.AddWithValue("@psskno", psskno);
                        cmd.Parameters.AddWithValue("@kul_adi", kul_adi);
                        cmd.Parameters.AddWithValue("@psifre", psifre);


                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception GetFieldsDictionary: ", ex);
            }
            
        }
        public DataTable tumPersonelGetir(string connectionString) {

            string query = "SELECT * FROM PERSONEL";
            DataTable dt = null;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    dt = new DataTable();
                    dt.Load(dr);
                   
                }
            }
            return dt;
        }
        public DataTable seciliPersonelGetir(string connectionString,int personelId)
        {

            string query = "SELECT * FROM PERSONEL WHERE id=@ID";
            DataTable dt = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {              
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@ID", personelId);



                        cmd.Connection = con;
                        con.Open();
                       SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        dt = new DataTable();
                        dt.Load(dr);
                        con.Close();
                    }           
            }
            return dt;
        }

        public void yetkiKontrol(string connectionString, string kul_adi1, string psifre1)
        {

            string query = "SELECT * FROM PERSONEL WHERE kul_adi=@kul_adi1 and psifre=@psifre1";
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@kul_adi1", kul_adi1);
                    cmd.Parameters.AddWithValue("@psifre1", psifre1);
                   
                    cmd.Connection = con;
                    con.Open();

                    if (cmd.ExecuteScalar().ToString() == "1")
                    {
                        //Yetkili
                       
                    }
                    else
                    {
                        //Yetkisiz
                    }

                    
                    con.Close();
                }
            }
           // return dt;
        }
        public bool personelSil(string connectionString,int personelId)
        {

            string query = "delete FROM PERSONEL WHERE id=@ID";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@ID", personelId);
                        


                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception GetFieldsDictionary: ", ex);
            }
        }

        public bool personelguncelle(string connectionString, string query, int personelId,
            string pername,string persoyad,string tcno,string Adres)
        {
            //pkod=@pkod,psoyad=@psoyad,ptcno=@ptcno

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@ID", personelId);
                        cmd.Parameters.AddWithValue("@pkod", pername);
                        cmd.Parameters.AddWithValue("@psoyad", persoyad);
                        cmd.Parameters.AddWithValue("@ptcno", tcno);
                        cmd.Parameters.AddWithValue("@padres", Adres);

                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception GetFieldsDictionary: ", ex);
            }
        }

        //oda ekleme
        public void odaEkle(string connectionString, string oda_no, int bul_kat,
          string bilgi,int yatak_Sayisi)
        {

            string query = "insert into ODALAR(oda_numarasi,oda_bul_kat,bilgi,yatak_sayisi)" +
                " VALUES (@oda_numarasi,@oda_bul_kat,@bilgi,@yatak_sayisi)";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@oda_numarasi", oda_no);
                        cmd.Parameters.AddWithValue("@oda_bul_kat", bul_kat);
                        cmd.Parameters.AddWithValue("@bilgi", bilgi);
                        cmd.Parameters.AddWithValue("@yatak_sayisi", yatak_Sayisi);
                        

                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception GetFieldsDictionary: ", ex);
            }

        }
        public DataTable tumOdalarıGetir(string connectionString)
        {

            string query = "SELECT * FROM ODALAR";
            DataTable dt = null;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    dt = new DataTable();
                    dt.Load(dr);

                }
            }
            return dt;
        }
        public DataTable seciliOdalarGetir(string connectionString, int odaId)
        {

            string query = "SELECT * FROM ODALAR WHERE oda_no=@oda_no";
            DataTable dt = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@oda_no", odaId);

                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    dt = new DataTable();
                    dt.Load(dr);
                    con.Close();
                }
            }
            return dt;
        }
        public bool odaSil(string connectionString, int Id)
        {

            string query = "delete FROM ODALAR WHERE id=@id";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@id", Id);
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception GetFieldsDictionary: ", ex);
            }
        }

        public bool odaguncelle(string connectionString, string query, int id
            , string oda_no, int bul_kat,string bilgi, int yatak_Sayisi)
        {
            //pkod=@pkod,psoyad=@psoyad,ptcno=@ptcno

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@oda_numarasi", oda_no);
                        cmd.Parameters.AddWithValue("@oda_bul_kat", bul_kat);
                        cmd.Parameters.AddWithValue("@bilgi", bilgi);
                        cmd.Parameters.AddWithValue("@yatak_sayisi", yatak_Sayisi);


                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception GetFieldsDictionary: ", ex);
            }
        }
        // yatak ekleme

        public void yatakEkle(string connectionString, string yatak_numarasi, int yatak_durumu,
          string oda_id)
        {

            string query = "insert into YATAKLAR(yatak_numarasi,yatak_durumu,oda_id)" +
                " VALUES (@yatak_numarasi,@yatak_durumu,@oda_id)";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@yatak_numarasi", yatak_numarasi);
                        cmd.Parameters.AddWithValue("@yatak_durumu", yatak_durumu);
                        cmd.Parameters.AddWithValue("@oda_id", oda_id);
                       

                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception GetFieldsDictionary: ", ex);
            }

        }
        public DataTable tumYataklarıGetir(string connectionString)
        {

            string query = "SELECT * FROM YATAKLAR";
            DataTable dt = null;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    dt = new DataTable();
                    dt.Load(dr);

                }
            }
            return dt;
        }
       
        public bool yatakSil(string connectionString, int Id)
        {

            string query = "delete FROM YATAKLAR WHERE id=@id";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@id", Id);
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception GetFieldsDictionary: ", ex);
            }
        }

        public bool yatakguncelle(string connectionString, string query, int id
            , string yatak_numarasi, int yatak_durumu, string oda_id)
        {
            //pkod=@pkod,psoyad=@psoyad,ptcno=@ptcno

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@yatak_numarasi", yatak_numarasi);
                        cmd.Parameters.AddWithValue("@yatak_durumu", yatak_durumu);
                        cmd.Parameters.AddWithValue("@oda_id", oda_id);
                        

                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception GetFieldsDictionary: ", ex);
            }
        }
        //ögrenci ekle
        public void ogrenciEkle(string connectionString, string ogr_ad, string ogr_soyad, string ogr_bolum_ad,
          string ogr_sinif, string ogr_tel, string ogr_sehir, DateTime ogr_kayit_tarihi, int ogr_kat, int ogr_oda_no,
          int ogr_yatak_no)
        {

            string query = "insert into OGRENCILER(ogr_ad,ogr_soyad,ogr_bolum_ad,ogr_sinif,ogr_tel,ogr_sehir,ogr_kayit_tarihi,ogr_kat,ogr_oda_no,ogr_yatak_no)" +
                " VALUES (@ogr_ad,@ogr_soyad,@ogr_bolum_ad,@ogr_sinif,@ogr_tel,@ogr_sehir,@ogr_kayit_tarihi,@ogr_kat,@ogr_oda_no,@ogr_yatak_no)";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@ogr_ad", ogr_ad);
                        cmd.Parameters.AddWithValue("@ogr_soyad", ogr_soyad);
                        cmd.Parameters.AddWithValue("@ogr_bolum_ad", ogr_bolum_ad);

                        cmd.Parameters.AddWithValue("@ogr_sinif", ogr_sinif);
                        cmd.Parameters.AddWithValue("@ogr_tel", ogr_tel);
                        cmd.Parameters.AddWithValue("@ogr_sehir", ogr_sehir);

                        cmd.Parameters.AddWithValue("@ogr_kayit_tarihi", ogr_kayit_tarihi);
                        cmd.Parameters.AddWithValue("@ogr_kat", ogr_kat);
                        cmd.Parameters.AddWithValue("@ogr_oda_no", ogr_oda_no);

                        cmd.Parameters.AddWithValue("@ogr_yatak_no", ogr_yatak_no);
                        

                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Exception GetFieldsDictionary: ", ex);
            }

        }
        public DataTable tumOgrenciGetir(string connectionString)
        {

            string query = "SELECT * FROM OGRENCILER";
            DataTable dt = null;
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    myConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    dt = new DataTable();
                    dt.Load(dr);

                }
            }
            return dt;
        }
        public DataTable seciliOgrenciGetir(string connectionString, int ogr_id)
        {

            string query = "SELECT * FROM OGRENCILER WHERE id=@ID";
            DataTable dt = null;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@ID", ogr_id);



                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    dt = new DataTable();
                    dt.Load(dr);
                    con.Close();
                }
            }
            return dt;
        }
        public bool ogrencıSil(string connectionString, int ogr_id)
        {

            string query = "delete FROM OGRENCILER WHERE id=@ID";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@ID", ogr_id);



                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception GetFieldsDictionary: ", ex);
            }
        }

        public bool ogrencıguncelle(string connectionString, string query, int ogr_id, string ogr_ad, string ogr_soyad, string ogr_bolum_ad,
          string ogr_sinif, string ogr_tel, string ogr_sehir, DateTime ogr_kayit_tarihi, string ogr_kat, string ogr_oda_no,
          string ogr_yatak_no)
        {
            //pkod=@pkod,psoyad=@psoyad,ptcno=@ptcno

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@ID", ogr_id);
                        cmd.Parameters.AddWithValue("@ogr_ad", ogr_ad);
                        cmd.Parameters.AddWithValue("@ogr_soyad", ogr_soyad);
                        cmd.Parameters.AddWithValue("@ogr_bolum_ad", ogr_bolum_ad);
                        cmd.Parameters.AddWithValue("@ogr_sinif", ogr_sinif);
                        cmd.Parameters.AddWithValue("@ogr_tel", ogr_tel);
                        cmd.Parameters.AddWithValue("@ogr_sehir", ogr_sehir);
                        cmd.Parameters.AddWithValue("@ogr_kayit_tarihi", ogr_kayit_tarihi);
                        cmd.Parameters.AddWithValue("@ogr_kat", ogr_kat);
                        cmd.Parameters.AddWithValue("@ogr_oda_no", ogr_oda_no);
                        cmd.Parameters.AddWithValue("@ogr_yatak_no", ogr_yatak_no);

                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception GetFieldsDictionary: ", ex);
            }
        }
    }
}
