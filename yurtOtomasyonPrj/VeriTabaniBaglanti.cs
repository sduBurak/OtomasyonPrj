using System;
using System.Data.SqlClient;
using System.Web;

namespace yurtOtomasyonPrj
{
    public class VeriTabaniBaglanti : IHttpModule
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

        private string kaynak;
        private string kullanici;
        private string sifre;
        public string baglantiStringi;

        public VeriTabaniBaglanti(string kaynak, string kullanici, string sifre)
        {
            this.kaynak = kaynak;
            this.kullanici = kullanici;
            this.sifre = sifre;
            this.baglantiStringi = this.kaynak;// + " User id = " + this.kullanici + "; password = " + this.sifre;
        }

        public bool isBaglanti()
        {
            string stmt = "select 1";
            try
            {

                using (SqlConnection connection = new SqlConnection(this.baglantiStringi))
                {
                    using (SqlCommand cmdCount = new SqlCommand(stmt, connection))
                    {
                        connection.Open();
                        int val = (int)cmdCount.ExecuteScalar();

                        if (val == 1)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
    }
}
