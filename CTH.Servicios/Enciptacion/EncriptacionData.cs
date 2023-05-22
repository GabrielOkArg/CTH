using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CTH.Servicios.Enciptacion
{
    public class EncriptacionData
    {
       

        private static byte[] Encrypt(string plainText, string password)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            byte[] encryptedBytes = ProtectedData.Protect(plainBytes, passwordBytes, DataProtectionScope.CurrentUser);
            return encryptedBytes;
        }

        private static string Decrypt(byte[] encryptedBytes, string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            byte[] plainBytes = ProtectedData.Unprotect(encryptedBytes, passwordBytes, DataProtectionScope.CurrentUser);
            string plainText = Encoding.UTF8.GetString(plainBytes);
            return plainText;
        }


        public static string Encriptar(string texto)
        {
            byte[] textobase = Encrypt(texto, llave.getPass());
            string resultado = Convert.ToBase64String(textobase);
            return resultado;
        }

        public static string Desencriptar(string texto)
        {
            byte[] bytesdesencuptados = Convert.FromBase64String(texto);
            string otroresultado = Decrypt(bytesdesencuptados, llave.getPass());
            return otroresultado;
        }

       
        
    }
}
