using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
   class PasswordFileHelper
   {
      public PasswordFileHelper()
      {
         //int size = 852;
         //byte[] datain = new byte[size];
         //for (int i = 0; i < size; i++)
         //{
         //   datain[i] = (byte)i;
         //}
         //MemoryStream msin = new MemoryStream();
         //CryptoStream csin = GetEncryptorStream("a", "b", msin);
         //csin.Write(datain, 0, datain.Length);
         //csin.FlushFinalBlock();
         //byte[] cipher = msin.ToArray();
         //MemoryStream msout = new MemoryStream();
         //CryptoStream csout = GetDecryptorStream("a", "b", msout);
         //csout.Write(cipher, 0, cipher.Length);
         //csout.FlushFinalBlock();
         //byte[] dataout = msout.ToArray();
         //for (int i = 0; i < size; i++)
         //{
         //   if (datain[i] != dataout[i])
         //   {
         //      System.Windows.Forms.MessageBox.Show("Error");
         //   }
         //}
         //PasswordList listin = new PasswordList();
         //listin.FileInitializationVector = "a";
         //listin.FilePassword = "a";
         //listin.ListOfPasswords.Add(new PasswordInfo { Password = "a", Tag = "a", Username = "a" });
         //byte[] serial = GetBinaryFormattedDataFromObject(listin);
         //MemoryStream msserial = new MemoryStream();
         //msserial.Write(serial, 0, serial.Length);
         //msserial.Seek(0, SeekOrigin.Begin);
         //PasswordList listout = GetObjectFromBinaryFormattedData(msserial);
         //if (listout == null)
         //{
         //   System.Windows.Forms.MessageBox.Show("Error");
         //}
      }

      public void WriteToFileNew(string filename, PasswordList list)
      {
         FileStream outFile = new FileStream(filename, FileMode.CreateNew, FileAccess.Write);
         MemoryStream memStream = new MemoryStream();
         CryptoStream cryptoStream = GetEncryptorStream(list.FilePassword, list.FileInitializationVector, memStream);
         byte[] binaryData = GetBinaryFormattedDataFromObject(list);
         cryptoStream.Write(binaryData, 0, binaryData.Length);
         cryptoStream.Flush();
         if (cryptoStream.HasFlushedFinalBlock == false)
         {
            cryptoStream.FlushFinalBlock();
         }
         outFile.Write(memStream.ToArray(), 0, (int)memStream.Length);
         cryptoStream.Close();
         outFile.Close();
      }

      public void WriteToFileOverwrite(string filename, PasswordList list)
      {
         FileStream outFile = new FileStream(filename, FileMode.Create, FileAccess.Write);
         MemoryStream memStream = new MemoryStream();
         CryptoStream cryptoStream = GetEncryptorStream(list.FilePassword, list.FileInitializationVector, memStream);
         byte[] binaryData = GetBinaryFormattedDataFromObject(list);
         cryptoStream.Write(binaryData, 0, binaryData.Length);
         cryptoStream.Flush();
         if (cryptoStream.HasFlushedFinalBlock == false)
         {
            cryptoStream.FlushFinalBlock();
         }
         outFile.Write(memStream.ToArray(), 0, (int)memStream.Length);
         cryptoStream.Close();
         outFile.Close();
      }
      
      public PasswordList ReadFromFile(string filename, string password, string initVector)
      {
         FileStream inFile = new FileStream(filename, FileMode.Open, FileAccess.Read);
         MemoryStream memStream = new MemoryStream();
         CryptoStream cryptoStream = GetDecryptorStream(password, initVector, memStream);
         byte[] data = new byte[inFile.Length];
         inFile.Read(data, 0, data.Length);
         cryptoStream.Write(data, 0, data.Length);
         cryptoStream.Flush();
         if (cryptoStream.HasFlushedFinalBlock == false)
         {
            cryptoStream.FlushFinalBlock();
         }
         memStream.Seek(0, SeekOrigin.Begin);
         PasswordList list = GetObjectFromBinaryFormattedData(memStream);
         cryptoStream.Close();
         inFile.Close();
         return list;
      }

      private byte[] GetBytesFromString(string value)
      {
         byte[] data = new byte[32];
         System.Buffer.BlockCopy(value.ToCharArray(), 0, data, 0, value.Length * sizeof(char));
         return data;
      }

      private byte[] GetBinaryFormattedDataFromObject(PasswordList list)
      {
         BinaryFormatter formatter = new BinaryFormatter();
         MemoryStream stream = new MemoryStream();
         formatter.Serialize(stream, list);
         return stream.ToArray();
      }

      private PasswordList GetObjectFromBinaryFormattedData(MemoryStream data)
      {
         BinaryFormatter formatter = new BinaryFormatter();
         return (PasswordList)formatter.Deserialize(data);
      }

      private CryptoStream GetDecryptorStream(string password, string initVector, MemoryStream memoryStream)
      {
         SymmetricAlgorithm crypto = SymmetricAlgorithm.Create();
         crypto.BlockSize = 256;
         crypto.FeedbackSize = 256;
         crypto.IV = GetBytesFromString(initVector);
         crypto.Key = GetBytesFromString(password);
         //crypto.KeySize = 256;
         crypto.Mode = CipherMode.CBC;
         crypto.Padding = PaddingMode.PKCS7;
         CryptoStream cryptoStream = new CryptoStream(memoryStream, crypto.CreateDecryptor(), CryptoStreamMode.Write);
         return cryptoStream;
      }

      private CryptoStream GetEncryptorStream(string password, string initVector, MemoryStream memoryStream)
      {
         SymmetricAlgorithm crypto = SymmetricAlgorithm.Create();
         crypto.BlockSize = 256;
         crypto.FeedbackSize = 256;
         crypto.IV = GetBytesFromString(initVector);
         crypto.Key = GetBytesFromString(password);
         //crypto.KeySize = 256;
         crypto.Mode = CipherMode.CBC;
         crypto.Padding = PaddingMode.PKCS7;
         CryptoStream cryptoStream = new CryptoStream(memoryStream, crypto.CreateEncryptor(), CryptoStreamMode.Write);
         return cryptoStream;
      }
   }
}
