using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassesComunesBC
{
    public class Ejemplo_RSA
    {
        public void Main()
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes("Prueba");
            byte[] encryptedData;
            byte[] decryptedData;

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);
                decryptedData = RSADecrypt(dataToEncrypt, RSA.ExportParameters(false), false);

                Console.WriteLine("Text: {0}", ByteConverter.GetString(decryptedData));
            }
        }

        public void UDPEncryptedToSend(byte[] data)
        {
            byte[] dataToEncrypt = data;
            byte[] encryptedData;

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);
            }
        }

        public void UDPRecivedToDecrypt(byte[] data)
        {
            byte[] dataToEncrypt = data;
            byte[] decryptedData;

            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                decryptedData = RSADecrypt(dataToEncrypt, RSA.ExportParameters(false), false);
            }
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
