using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
   public partial class PasswordManager : Form
   {
      public const string TAG_STRING = "Tag";
      public const string USER_STRING = "Username";
      public const string PASS_STRING = "Password";

      private PasswordList mCurrentPasswordList;
      private string mLastOpenedFile;

      public PasswordManager()
      {
         InitializeComponent();
      }

      private void exitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void newToolStripMenuItem_Click(object sender, EventArgs e)
      {
         PasswordAndInitializationVectorCreation createPassAndIVDialog = new PasswordAndInitializationVectorCreation();
         DialogResult result = createPassAndIVDialog.ShowDialog();
         if (result == DialogResult.OK)
         {
            PasswordListHelper helper = new PasswordListHelper();
            helper.InitializePasswordList(createPassAndIVDialog.InitializationVector, createPassAndIVDialog.Password, ref mCurrentPasswordList);
            helper.UpdateDataGridViewFromList(gridViewPasswordListData, mCurrentPasswordList);
         }
      }

      private void gridViewPasswordListData_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
      {
         if (e.Button == MouseButtons.Right)
         {
            int rowSelected = e.RowIndex;
            if (rowSelected != -1)
            {
               gridViewPasswordListData.Rows[rowSelected].Selected = true;
            }
         }
      }

      private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (mCurrentPasswordList == null)
         {
            MessageBox.Show("Open or create a new or existing list before trying to delete an entry.", "Error Deleting Existing Entry");
            return;
         }
         PasswordListHelper helper = new PasswordListHelper();
         helper.RemoveItemFromDataGridAndList(gridViewPasswordListData, mCurrentPasswordList);
      }

      private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (mCurrentPasswordList == null)
         {
            MessageBox.Show("Open or create a new or existing list or open an existing list before trying to add an entry.", "Error Adding New Entry");
            return;
         }
         AddNewEntry entryDialog = new AddNewEntry();
         DialogResult result = entryDialog.ShowDialog();
         if (result == DialogResult.OK)
         {
            PasswordListHelper helper = new PasswordListHelper();
            helper.AddItemToGridDataAndList(gridViewPasswordListData, mCurrentPasswordList, entryDialog.TagInfo, entryDialog.Username, entryDialog.Password);
         }
      }

      private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (mCurrentPasswordList == null)
         {
            MessageBox.Show("Open or create a new or existing list before trying to modifying an entry.", "Error Modifying Existing Entry");
            return;
         }
         PasswordListHelper helper = new PasswordListHelper();
         string user = "";
         string pass = "";
         string tag = "";
         bool success = helper.GetSelectedRowInfo(gridViewPasswordListData, out tag, out user, out pass);
         if (success == false)
         {
            MessageBox.Show("Select an existing row before trying to modifying the entry.", "Error Modifying Existing Entry");
            return;
         }
         ModifyExistingEntry modifyDialog = new ModifyExistingEntry();
         modifyDialog.ExistingPassword = pass;
         modifyDialog.ExistingTag = tag;
         modifyDialog.ExistingUsername = user;
         DialogResult result = modifyDialog.ShowDialog();
         if (result == DialogResult.OK)
         {
            helper = new PasswordListHelper();
            helper.ModifyItemInGridDataAndList(gridViewPasswordListData, mCurrentPasswordList, modifyDialog.NewTag, modifyDialog.NewUsername, modifyDialog.NewPassword);
         }
      }

      private void aboutToolStripMenuItemDialog_Click(object sender, EventArgs e)
      {
         PasswordFileHelper helper = new PasswordFileHelper();
         AboutDialog dlg = new AboutDialog();
         dlg.ShowDialog();
      }

      private void openToolStripMenuItem_Click(object sender, EventArgs e)
      {
         string password = "";
         string initVector = "";
         DialogResult result = dlgOpenPasswordFile.ShowDialog();
         if (result == DialogResult.OK)
         {
            PasswordAndInititalizationVectorRead readPwAndInitVector = new PasswordAndInititalizationVectorRead();
            result = readPwAndInitVector.ShowDialog();
            if (result == DialogResult.OK)
            {
               mLastOpenedFile = dlgOpenPasswordFile.FileName;
               password = readPwAndInitVector.Password;
               initVector = readPwAndInitVector.InitializationVector;
               PasswordFileHelper fileHelper = new PasswordFileHelper();
               mCurrentPasswordList = fileHelper.ReadFromFile(dlgOpenPasswordFile.FileName, password, initVector);
               PasswordListHelper listHelper = new PasswordListHelper();
               listHelper.UpdateDataGridViewFromList(gridViewPasswordListData, mCurrentPasswordList);
            }
         }
      }

      private void closeToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (mCurrentPasswordList == null)
         {
            MessageBox.Show("Open or create a new or existing list before trying to close.", "Error Closing List");
            return;
         }
         mCurrentPasswordList = null;
         PasswordListHelper helper = new PasswordListHelper();
         helper.UpdateDataGridViewFromList(gridViewPasswordListData, mCurrentPasswordList);
         mLastOpenedFile = "";
      }

      private void saveToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (mCurrentPasswordList == null)
         {
            MessageBox.Show("Open or create a new or existing list before trying to save.", "Error Saving List");
            return;
         }
         if (System.IO.File.Exists(mLastOpenedFile) == false)
         {
            DialogResult result = dlgSavePasswordFile.ShowDialog();
            if (result == DialogResult.OK)
            {
               PasswordFileHelper helper = new PasswordFileHelper();
               mLastOpenedFile = dlgSavePasswordFile.FileName;
               helper.WriteToFileNew(dlgSavePasswordFile.FileName, mCurrentPasswordList);
            }
         }
         else
         {
            PasswordFileHelper helper = new PasswordFileHelper();
            helper.WriteToFileOverwrite(mLastOpenedFile, mCurrentPasswordList);
         }
      }

      private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (mCurrentPasswordList == null)
         {
            MessageBox.Show("Open or create a new or existing list before trying to save.", "Error Saving List");
            return;
         }
         DialogResult result = dlgSaveAsPasswordFile.ShowDialog();
         if (result == DialogResult.OK)
         {
            PasswordFileHelper helper = new PasswordFileHelper();
            mLastOpenedFile = dlgSaveAsPasswordFile.FileName;
            helper.WriteToFileNew(dlgSaveAsPasswordFile.FileName, mCurrentPasswordList);
         }
      }

      private void modifyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (mCurrentPasswordList == null)
         {
            MessageBox.Show("Open or create a new or existing list before trying to modifying its password.", "Error Modifying Password");
            return;
         }
         PasswordUpdate update = new PasswordUpdate();
         update.CurrentPassword = mCurrentPasswordList.FilePassword;
         DialogResult result = update.ShowDialog();
         if (result == DialogResult.OK)
         {
            mCurrentPasswordList.FilePassword = update.NewPassword;
         }
      }

      private void editInitializationVectorToolStripMenuItem_Click(object sender, EventArgs e)
      {
         if (mCurrentPasswordList == null)
         {
            MessageBox.Show("Open or create a new or existing list before trying to modifying its initialization vector.", "Error Modifying Initialization Vector");
            return;
         }
         InitializationVectorUpdate update = new InitializationVectorUpdate();
         update.CurrentPassword = mCurrentPasswordList.FilePassword;
         DialogResult result = update.ShowDialog();
         if (result == DialogResult.OK)
         {
            mCurrentPasswordList.FileInitializationVector = update.NewInitializationVector;
         }
      }
   }
}
