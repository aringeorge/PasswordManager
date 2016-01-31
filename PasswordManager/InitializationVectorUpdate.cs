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
   public partial class InitializationVectorUpdate : Form
   {
      public string CurrentPassword { private get; set; }
      public string NewInitializationVector { get; private set; }

      private bool OldPasswordError;
      private bool NewInitializationVectorError;

      public InitializationVectorUpdate()
      {
         InitializeComponent();

         OldPasswordError = false;
         NewInitializationVectorError = false;
         NewInitializationVector = "";

         cmdOK.Enabled = false;

         CheckForErrorsOnPasswordAndInitializationVector();
         errCurrentPassword.Clear();
         errInitializationVector.Clear();
      }

      private bool ValidateCurrentPassword()
      {
         return (CurrentPassword == txtPassword.Text);
      }

      private bool ValidateInitialiationVector()
      {
         return ((txtNewInitializationVector.Text.Length > 0) && (txtNewInitializationVector.Text == txtReenterNewInitializationVector.Text));
      }

      private void CheckForErrorsOnPasswordAndInitializationVector()
      {
         OldPasswordError = false;
         errCurrentPassword.Clear();
         if (ValidateCurrentPassword() == false)
         {
            OldPasswordError = true;
            errCurrentPassword.SetError(txtPassword, "Incorrect!");
         }

         NewInitializationVectorError = false;
         errInitializationVector.Clear();
         if (ValidateInitialiationVector() == false)
         {
            NewInitializationVectorError = true;
            errInitializationVector.SetError(txtReenterNewInitializationVector, "Mismatch!");
         }

         cmdOK.Enabled = ((OldPasswordError == false) && (NewInitializationVectorError == false));
      }

      private void cmdOK_Click(object sender, EventArgs e)
      {
         if ((OldPasswordError == false) && (NewInitializationVectorError == false))
         {
            DialogResult = DialogResult.OK;
            CurrentPassword = "";
            NewInitializationVector = txtNewInitializationVector.Text;
            this.Close();
         }
      }

      private void cmdCancel_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.Cancel;
         CurrentPassword = "";
         NewInitializationVector = "";
         this.Close();
      }
   }
}
