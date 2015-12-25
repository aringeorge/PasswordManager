using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
   [Serializable]
   class PasswordList
   {
      public string FilePassword { get; set; }
      public string FileInitializationVector { get; set; }
      public List<PasswordInfo> ListOfPasswords { get; set; } = new List<PasswordInfo>();

      public override bool Equals(object obj)
      {
         if ((obj == null) || ((obj is PasswordList) == false))
         {
            return false;
         }
         PasswordList list = obj as PasswordList;
         if (list == null)
         {
            return false;
         }
         bool passMatch = FilePassword.Equals(list.FilePassword);
         bool ivMatch = FileInitializationVector.Equals(list.FileInitializationVector);
         return ((passMatch == true) && (ivMatch == true));
      }

      public override int GetHashCode()
      {
         return base.GetHashCode();
      }

      public override string ToString()
      {
         StringBuilder bldr = new StringBuilder();
         bldr.AppendLine($"FilePassword: {FilePassword} FileInitializationVector: {FileInitializationVector} PasswordListCount: {ListOfPasswords.Count} ");
         foreach (PasswordInfo info in ListOfPasswords)
         {
            bldr.AppendLine(info.ToString());
         }
         return bldr.ToString();
      }
   }
}
