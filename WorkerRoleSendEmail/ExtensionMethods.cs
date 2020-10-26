﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WorkerRoleSendEmail
{
    public static class ExtensionMethods
 {
     public static DateTime ToDateTimeNow(this DateTime date)
     {
         if (date != new DateTime())
         {
             string offset = WorkerRoleSendEmail.TimeZoneOffSet;
             DateTime dateObj = new DateTime();
             dateObj = date.AddHours(Convert.ToDouble(offset));
             return dateObj;
         }
         return date;
     }
     public static string Encrypt(this Int32 toEncrypt)
     {
         if (toEncrypt == 0)
             return "0";

         byte[] keyArray;
         byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(WorkerRoleSendEmail.UserId + "-" + toEncrypt.ToString());

         System.Configuration.AppSettingsReader settingsReader =
                                             new AppSettingsReader();
         // Get the key from config file

         string key = "App";
         // (string)settingsReader.GetValue("SecurityKey",
         //                                 typeof(String));
         //System.Windows.Forms.MessageBox.Show(key);
         ////If hashing use get hashcode regards to your key
         MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
         keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
         //Always release the resources and flush data
         // of the Cryptographic service provide. Best Practice

         //hashmd5.Clear();
         //else
         //keyArray = UTF8Encoding.UTF8.GetBytes(key);

         TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
         //set the secret key for the tripleDES algorithm
         tdes.Key = keyArray;
         //mode of operation. there are other 4 modes.
         //We choose ECB(Electronic code Book)
         tdes.Mode = CipherMode.ECB;
         //padding mode(if any extra byte added)

         tdes.Padding = PaddingMode.PKCS7;

         ICryptoTransform cTransform = tdes.CreateEncryptor();
         //transform the specified region of bytes array to resultArray
         byte[] resultArray =
           cTransform.TransformFinalBlock(toEncryptArray, 0,
           toEncryptArray.Length);
         //Release resources held by TripleDes Encryptor
         tdes.Clear();
         //Return the encrypted data into unreadable string format

         return Convert.ToBase64String(resultArray, 0, resultArray.Length).Replace("/", "^").Replace("+", "~").Replace("=", "-");
     }
    }
}