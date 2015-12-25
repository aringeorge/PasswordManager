using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
   [Serializable]
   class PasswordInfo
   {
      public string Username { get; set; }
      public string Password { get; set; }
      public string Tag { get; set; }

      public override bool Equals(object obj)
      {
         if ((obj == null) || ((obj is PasswordInfo) == false))
         {
            return false;
         }
         PasswordInfo info = obj as PasswordInfo;
         if (info == null)
         {
            return false;
         }
         bool userMatch = Username.Equals(Username);
         bool passMatch = Password.Equals(info.Password);
         bool tagMatch = Tag.Equals(info.Tag);
         return ((userMatch == true) && (passMatch == true) && (tagMatch == true));
      }

      public override int GetHashCode()
      {
         return base.GetHashCode();
      }

      public override string ToString()
      {
         return $"{PasswordManager.TAG_STRING}: {Tag} {PasswordManager.USER_STRING}: {Username} {PasswordManager.PASS_STRING}: {Password}";
      }
   }
}
