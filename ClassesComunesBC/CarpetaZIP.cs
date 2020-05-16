using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesComunesBC
{
    public class CarpetaZIP
    {
        public string connectionString = "Server=thegungans.database.windows.net; Database=RepublicSystem; User Id=gungan; Password=12345aA12345aA";

        public string[] lletres = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        public int num;
        public string numText;

        public bool descomprimirCarpeta(string zipPath, string extractPath)
        {
            bool error = false;

            try
            {
                if (Directory.Exists(zipPath))
                {
                    Directory.Delete(zipPath, true);
                }

                if (Directory.Exists(extractPath))
                {
                    Directory.Delete(extractPath, true);
                }

                ZipFile.ExtractToDirectory(zipPath, extractPath);

                error = false;
            }
            catch 
            {
                error = true;
            }

            return error;
        }

        public string [] LlegirClau()
        {
            string[] clau_arr = new string[26];

            SqlConnection conectarBD = new SqlConnection();
            conectarBD.ConnectionString = connectionString;
            conectarBD.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            string query = "SELECT a.Numbers FROM InnerEncryptionData a, InnerEncryption b WHERE a.IdInnerEncryption = b.idInnerEncryption and b.Day = '" + Convert.ToDateTime(DateTime.Today).ToString("yyyy-MM-dd") + "'";


            da = new SqlDataAdapter(query, conectarBD);
            da.Fill(ds);

            for (int i = 0; i < clau_arr.Length; i++)
            {
                clau_arr[i] = ds.Tables[0].Rows[i][0].ToString();

            }
            return clau_arr;
        }
    }
}
