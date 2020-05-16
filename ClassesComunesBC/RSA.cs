using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Xml;
using System.Windows.Forms;

namespace ClassesComunesBC
{
    public class RSA
    {
        public string ConnectionString = "Server=thegungans.database.windows.net; Database=RepublicSystem; User Id=gungan; Password=12345aA12345aA";
        ConsultesBBDD consultes = new ConsultesBBDD();

        public CspParameters contenidorClau = new CspParameters();


        public string [] GeneradorClausRSA()
        {
            // GENERAR CLAUS PUBLICA/PRIVADA PER RSA
            RSACryptoServiceProvider clauRSA = new RSACryptoServiceProvider();

            // GUARDAR INFORMACIÓ DE LES CLAUS EN UNA ESTRUCTURA RSAPARAMETERS
            RSAParameters infoclauRSA = clauRSA.ExportParameters(false);

            // GUARDAR INFORMACIÓ DE LES CLAUS EN UN FITXER XML
            string clauPublica = clauRSA.ToXmlString(false);
            string clauPrivada = clauRSA.ToXmlString(true);

            string[] claus = new string[2];
            claus[0] = clauPublica;
            claus[1] = clauPrivada;

            return claus;
        }

        public void guardarXMLBBDD(string clauPublica)
        {
            string query;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet v_id = new DataSet();

            using (SqlConnection connexio = new SqlConnection(ConnectionString))
            {
                query = "INSERT INTO PlanetKeys ([XMLKey]) VALUES (@XMLKey)";

                connexio.Open();

                using (SqlCommand command = new SqlCommand(query, connexio))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@XMLKey", clauPublica);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }

        public RSACryptoServiceProvider EmmagatzemarClauPrivada(CspParameters contenidorClau)
        {
            //CREAR EL CONTENIDOR DE CLAUS
            contenidorClau.KeyContainerName = "KeyContainer";
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(contenidorClau);

            //FER QUE LA CLAU SIGUI PERSISTENT
            RSA.PersistKeyInCsp = true;

            return RSA;
        }

        public RSAParameters ExpImpClauPrivada(RSACryptoServiceProvider rsa, string type)
        {
            using (RSACryptoServiceProvider RSA = rsa)
            {
                RSAParameters ParametresRSA;

                if (type == "nau")
                {
                    //EXPORTAR ELS PARÀMETRES DE RSA
                    ParametresRSA = RSA.ExportParameters(false);

                }else
                {
                    ParametresRSA = RSA.ExportParameters(true);
                }
                //CREAR OBJECTE RSA2
                using (RSACryptoServiceProvider RSA2 = new RSACryptoServiceProvider())
                {
                    //IMPORTAR ELS PARÀMETRES DE RSA EN RSA2
                    RSA2.ImportParameters(ParametresRSA);

                    return ParametresRSA;
                }
            }
        }
             
        public byte[] UDPEncryptedToSend(RSAParameters parameters , byte[] data)
        {
            byte[] dataToEncrypt = data;
            byte[] encryptedData;

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(parameters);
                encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);
            }

            return encryptedData;
        }

        public byte[] UDPRecivedToDecrypt(RSAParameters parametres, byte[] data)
        {
            byte[] dataToEncrypt = data;
            byte[] decryptedData;

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.Clear();
                RSA.ImportParameters(parametres);
                decryptedData = RSADecrypt(dataToEncrypt, RSA.ExportParameters(true), false);
            }

            return decryptedData;
        }

        public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            byte[] encryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(RSAKeyInfo);
                encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
            }
            return encryptedData;
        }

        public static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.ImportParameters(RSAKeyInfo);
                decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
            }
            return decryptedData;
        }
    }
}
