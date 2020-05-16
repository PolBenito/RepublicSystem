using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassesComunesBC
{
   public class EncriptacioDesencriptacio
   {
       private static RSAParameters publicKey;
       private static RSAParameters privateKey;

       public enum KeySizes
       {
           SIZE_512 = 512,
           SIZE_1024 = 1024,
           SIZE_2048 = 2048,
           SIZE_952 = 952,
           SIZE_1369 = 1369
       };

       private void Main (string[] args)
       {
           string message = "Aquí irá el mensaje de Nave";
           generateKeys();

       }

       private void generateKeys()
       {
           using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
           {
               rsa.PersistKeyInCsp = false;
               publicKey = rsa.ExportParameters(false);
               privateKey = rsa.ExportParameters(true);
           }
       }

       public byte[] Decrypt(byte[] input)
       {
           byte[] decrypted;
           using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
           {
               rsa.PersistKeyInCsp = false;
               rsa.ImportParameters(privateKey);
               decrypted = rsa.Decrypt(input, true);
           }
           return decrypted;
       }
   }
}
