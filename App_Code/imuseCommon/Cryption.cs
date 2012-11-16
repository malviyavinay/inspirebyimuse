using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Web.Security;

namespace imuse.Common
{
	/// <summary>
	/// Summary description for Cryption.
	/// </summary>
	public sealed class Cryption
    {
        #region Encription Decription
        /// <summary>
        /// This function is return a encyrpted format of string
        /// </summary>
        /// <param name="strText"></param>
        /// <returns></returns>
        public static string GetEncryptedString(string strText)
        {
            Encryption.Encryption objEncryption = new Encryption.Encryption();
            objEncryption.Key = "IMUSE";
            return objEncryption.StringEncrypt(strText);
        }
        /// <summary>
        /// This function is return a decyrpted long data type format of string
        /// </summary>
        /// <param name="strText"></param>      
        /// <returns></returns>
        public static Int64 GetDecryptedString(string strText)
        {
            Encryption.Encryption objEncryption = new Encryption.Encryption();
            try
            {
                objEncryption.Key = "IMUSE";
                return Convert.ToInt64(objEncryption.StringDecrypt(strText.Replace(" ", "+")));
            }
            catch
            {
                return 0;
            }
        }
        /// <summary>
        /// This function is return a decyrpted string data type format of string
        /// </summary>
        /// <param name="strText"></param>
        /// <returns></returns>
        public static string GetDecryptedStringFormat(string strText)
        {
            Encryption.Encryption objEncryption = new Encryption.Encryption();
            try
            {
                objEncryption.Key = "IMUSE";
                return Convert.ToString(objEncryption.StringDecrypt(strText.Replace(" ", "+")));
            }
            catch
            {
                return "";
            }
        }
        #endregion
		
	}
}