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
   public partial class ModifyExistingEntry : Form
   {
      public string NewTag { get; private set; }
      public string NewUsername { get; private set; }
      public string NewPassword { get; private set; }

      public string ExistingTag { private get; set; }
      public string ExistingUsername { private get; set; }
      public string ExistingPassword { private get; set; }

      private bool mTagChanged = false;
      private bool mUsernameChanged = false;
      private bool mPasswordChanged = false;

      public ModifyExistingEntry()
      {
         InitializeComponent();

         mTagChanged = false;
         mUsernameChanged = false;
         mPasswordChanged = false;

         cmdOk.Enabled = false;
      }

      private void ModifyExistingEntry_Shown(object sender, EventArgs e)
      {
         txtUsername.Text = ExistingUsername;
         txtPassword.Text = ExistingPassword;
         txtTagInfo.Text = ExistingTag;
      }

      private void UpdateTagChanged()
      {
         mTagChanged = txtTagInfo.Text.Equals(ExistingTag);
      }

      private void UpdateUsernameChanged()
      {
         mUsernameChanged = txtUsername.Text.Equals(ExistingUsername);
      }

      private void UpdatePasswordChanged()
      {
         mPasswordChanged = txtPassword.Text.Equals(ExistingPassword);
      }

      private void cmdOk_Click(object sender, EventArgs e)
      {
         if ((mTagChanged == true) || (mUsernameChanged == true) || (mPasswordChanged == true))
         {
            DialogResult = DialogResult.OK;
            NewTag = txtTagInfo.Text;
            NewPassword = txtPassword.Text;
            NewUsername = txtUsername.Text;
            this.Close();
         }
      }

      private void txtTagInfo_TextChanged(object sender, EventArgs e)
      {
         UpdateTagChanged();
         cmdOk.Enabled = ((mTagChanged == true) || (mUsernameChanged == true) || (mPasswordChanged == true));
      }

      private void txtUsername_TextChanged(object sender, EventArgs e)
      {
         UpdateUsernameChanged();
         cmdOk.Enabled = ((mTagChanged == true) || (mUsernameChanged == true) || (mPasswordChanged == true));
      }

      private void txtPassword_TextChanged(object sender, EventArgs e)
      {
         UpdatePasswordChanged();
         cmdOk.Enabled = ((mTagChanged == true) || (mUsernameChanged == true) || (mPasswordChanged == true));
      }

      private void cmdCancel_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.Cancel;
         NewTag = "";
         NewPassword = "";
         NewUsername = "";
         this.Close();
      }
   }
}
