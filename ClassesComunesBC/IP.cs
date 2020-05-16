using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ClassesComunesBC
{
    public class IP
    {
        public string ConnectionString = "Server=thegungans.database.windows.net; Database=RepublicSystem; User Id=gungan; Password=12345aA12345aA";


        public bool returnPing(string ip)
        {
            // Fer ping en cmd
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(ip);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }

        public bool actualitzarIP(string query, string localIP)
        {
            bool error = false;

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet v_id = new DataSet();

            using (SqlConnection connexio = new SqlConnection(ConnectionString))
            {
                connexio.Open();

                using (SqlCommand command = new SqlCommand(query, connexio))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@IPPlanet", localIP);
                        command.ExecuteNonQuery();
                    }
                    catch
                    {
                        error = true;
                    }
                }
            }
            return error;
        }

        #region OBTENIR...
        public int obtenirPort(string query)
        {
            int port;

            SqlConnection conectarBD = new SqlConnection();
            conectarBD.ConnectionString = ConnectionString;
            conectarBD.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            da = new SqlDataAdapter(query, conectarBD);
            da.Fill(ds);


            port = Int32.Parse(ds.Tables[0].Rows[0][0].ToString());

            return port;
        }

        public string obtenirIpEspecifica(string query)
        {
            string ip;

            SqlConnection conectarBD = new SqlConnection();
            conectarBD.ConnectionString = ConnectionString;
            conectarBD.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            da = new SqlDataAdapter(query, conectarBD);
            da.Fill(ds);

            ip = ds.Tables[0].Rows[0][0].ToString();

            return ip;
        }

        public string obtenirIP()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }

            return localIP;
        }

        #endregion

    }
}
