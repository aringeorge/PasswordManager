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
   public partial class PasswordUpdate : Form
   {
      public string CurrentPassword { private get; set; }
      public string NewPassword { get; private set; }

      private bool OldPasswordError;
      private bool NewPasswordError;

      public PasswordUpdate()
      {
         InitializeComponent();

         NewPassword = "";
         OldPasswordError = false;
         NewPasswordError = false;
         cmdOK.Enabled = false;

         CheckForErrorsOnPasswords();
         errCurrentPassword.Clear();
         errNewPassword.Clear();
      }

      private bool ValidateCurrentPassword()
      {
         return (CurrentPassword == txtPassword.Text);
      }

      private bool ValidateNewPassword()
      {
         return ((txtNewPassword.Text.Length > 0) && (txtNewPassword.Text == txtReenterNewPassword.Text));
      }

      private void CheckForErrorsOnPasswords()
      {
         errCurrentPassword.Clear();
         OldPasswordError = false;
         if (ValidateCurrentPassword() == false)
         {
            errCurrentPassword.SetError(txtPassword, "Incorrect!");
            OldPasswordError = true;
         }

         errNewPassword.Clear();
         NewPasswordError = false;
         if (ValidateNewPassword() == false)
         {
            errNewPassword.SetError(txtReenterNewPassword, "Mismatch!");
            NewPasswordError = true;
         }

         cmdOK.Enabled = ((OldPasswordError == false) && (NewPasswordError == false));
      }

      private void cmdOK_Click(object sender, EventArgs e)
      {
         if ((OldPasswordError == false) && (NewPasswordError == false))
         {
            NewPassword = txtNewPassword.Text;
            DialogResult = DialogResult.OK;
            this.Close();
         }
      }

      private void cmdCancel_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.Cancel;
         CurrentPassword = "";
         NewPassword = "";
         this.Close();
      }

      private void txtPassword_TextChanged(object sender, EventArgs e)
      {
         CheckForErrorsOnPasswords();
      }

      private void txtNewPassword_TextChanged(object sender, EventArgs e)
      {
         CheckForErrorsOnPasswords();
      }

      private void txtReenterNewPassword_TextChanged(object sender, EventArgs e)
      {
         CheckForErrorsOnPasswords();
      }
   }
}
