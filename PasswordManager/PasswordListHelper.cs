using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
   class PasswordListHelper
   {
      public void InitializePasswordList(string password, string initVector, ref PasswordList list)
      {
         list = new PasswordList();
         list.FileInitializationVector = initVector;
         list.FilePassword = password;
         list.ListOfPasswords = new List<PasswordInfo>();
      }

      public void UpdateDataGridViewFromList(DataGridView view, PasswordList list)
      {
         view.Rows.Clear();
         if (list != null)
         {
            foreach (PasswordInfo info in list.ListOfPasswords)
            {
               DataGridViewRow row = new DataGridViewRow();
               string[] objList = new string[] { info.Tag, info.Username, info.Password };
               row.CreateCells(view, objList);
               view.Rows.Add(row);
            }
         }
      }

      public bool GetSelectedRowInfo(DataGridView view, out string tagInfo, out string username, out string password)
      {
         tagInfo = "";
         username = "";
         password = "";
         DataGridViewSelectedRowCollection rows = view.SelectedRows;
         foreach (DataGridViewRow row in rows)
         {
            DataGridViewCellCollection cells = row.Cells;
            return PopulateStringsFromCells(cells, out tagInfo, out username, out password);
         }
         return false;
      }

      public void AddItemToGridDataAndList(DataGridView view, PasswordList list, string tagInfo, string username, string password)
      {
         PasswordInfo info = new PasswordInfo();
         info.Tag = tagInfo;
         info.Username = username;
         info.Password = password;
         list.ListOfPasswords.Add(info);
         DataGridViewRow row = new DataGridViewRow();
         string[] objList = new string[] { tagInfo, username, password };
         row.CreateCells(view, objList);
         view.Rows.Add(row);
      }

      public void ModifyItemInGridDataAndList(DataGridView view, PasswordList list, string newTag, string newUser, string newPass)
      {
         DataGridViewSelectedRowCollection rows = view.SelectedRows;
         foreach (DataGridViewRow row in rows)
         {
            DataGridViewCellCollection cells = row.Cells;
            string oldTag = "";
            string oldUser = "";
            string oldPass = "";
            bool tagFound = PopulateStringsFromCells(cells, out oldTag, out oldUser, out oldPass);
            if (tagFound == true)
            {
               PasswordInfo info = list.ListOfPasswords.Find(x => ((x.Tag == oldTag) && (x.Username == oldUser) && (x.Password == oldPass)));
               info.Password = newPass;
               info.Tag = newTag;
               info.Username = newUser;
               PopulateStringsToCells(cells, newTag, newUser, newPass);
               break;
            }
         }
      }

      private void PopulateStringsToCells(DataGridViewCellCollection cells, string newTag, string newUser, string newPass)
      {
         foreach (DataGridViewCell cell in cells)
         {
            if (cell.OwningColumn.HeaderText == PasswordManager.TAG_STRING)
            {
               cell.Value = newTag;
            }
            else if (cell.OwningColumn.HeaderText == PasswordManager.USER_STRING)
            {
               cell.Value = newUser;
            }
            else if (cell.OwningColumn.HeaderText == PasswordManager.PASS_STRING)
            {
               cell.Value = newPass;
            }
         }
      }

      private bool PopulateStringsFromCells(DataGridViewCellCollection cells, out string tagValue, out string userValue, out string passValue)
      {
         bool tagPop = false;
         bool userPop = false;
         bool passPop = false;
         tagValue = "";
         userValue = "";
         passValue = "";
         foreach (DataGridViewCell cell in cells)
         {
            if ((tagPop == false) && (cell.OwningColumn.HeaderText == PasswordManager.TAG_STRING))
            {
               tagValue = cell.Value.ToString();
               tagPop = true;
            }
            else if ((userPop == false) && (cell.OwningColumn.HeaderText == PasswordManager.USER_STRING))
            {
               userValue = cell.Value.ToString();
               userPop = true;
            }
            else if ((passPop == false) && (cell.OwningColumn.HeaderText == PasswordManager.PASS_STRING))
            {
               passValue = cell.Value.ToString();
               passPop = true;
            }
         }
         return ((tagPop == true) && (passPop == true) && (userPop == true));
      }

      public void RemoveItemFromDataGridAndList(DataGridView view, PasswordList list)
      {
         DataGridViewSelectedRowCollection rows = view.SelectedRows;
         DataGridViewRow rowToRemove = null;
         foreach (DataGridViewRow row in rows)
         {
            DataGridViewCellCollection cells = row.Cells;
            string tagValue = "";
            string userValue = "";
            string passValue = "";
            bool itemFound = PopulateStringsFromCells(cells, out tagValue, out userValue, out passValue);
            if (itemFound == true)
            {
               PasswordInfo info = new PasswordInfo() { Username = userValue, Password = passValue, Tag = tagValue };
               list.ListOfPasswords.Remove(info);
               rowToRemove = row;
               break;
            }
         }
         if (rowToRemove != null)
         {
            view.Rows.Remove(rowToRemove);
         }
      }
   }
}
