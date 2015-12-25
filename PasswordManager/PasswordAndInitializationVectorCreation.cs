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
   public partial class PasswordAndInitializationVectorCreation : Form
   {
      public string Password { get; private set; }
      public string InitializationVector { get; private set; }

      private bool mPasswordError;
      private bool mInitVectorError;

      public PasswordAndInitializationVectorCreation()
      {
         InitializeComponent();
      }

      private void PasswordAndInitializatiionVector_Load(object sender, EventArgs e)
      {
         mPasswordError = true;
         mInitVectorError = true;
         Password = "";
         InitializationVector = "";

         txtPassword.Text = "";
         txtIV.Text = "";
         txtReenterPassword.Text = "";
         txtReenterIV.Text = "";

         cmdOK.Enabled = false;

         errPasswordMismatch.Clear();
         errIVMismatch.Clear();
      }

      private void txtPassword_TextChanged(object sender, EventArgs e)
      {
         CheckForPasswordError();
      }

      private void txtReenterPassword_TextChanged(object sender, EventArgs e)
      {
         CheckForPasswordError();
      }

      private void CheckForPasswordError()
      {
         mPasswordError = false;
         errPasswordMismatch.Clear();
         if ((txtPassword.TextLength > 0) && (txtReenterPassword.TextLength > 0))
         {
            if (txtPassword.Text != txtReenterPassword.Text)
            {
               errPasswordMismatch.SetError(txtReenterPassword, "Mismatch!");
               mPasswordError = true;
            }
         }
         if ((txtPassword.TextLength == 0) || (txtReenterPassword.TextLength == 0))
         {
            mPasswordError = true;
         }
         cmdOK.Enabled = ((mPasswordError == false) && (mInitVectorError == false));
      }

      private void CheckForIVError()
      {
         mInitVectorError = false;
         errIVMismatch.Clear();
         if ((txtIV.TextLength > 0) && (txtReenterIV.TextLength > 0))
         {
            if (txtIV.Text != txtReenterIV.Text)
            {
               errIVMismatch.SetError(txtReenterIV, "Mismatch!");
               mInitVectorError = true;
            }
         }
         if ((txtIV.TextLength == 0) || (txtReenterIV.TextLength == 0))
         {
            mInitVectorError = true;
         }
         cmdOK.Enabled = ((mPasswordError == false) && (mInitVectorError == false));
      }

      private void txtIV_TextChanged(object sender, EventArgs e)
      {
         CheckForIVError();
      }

      private void txtReenterIV_TextChanged(object sender, EventArgs e)
      {
         CheckForIVError();
      }

      private void cmdOK_Click(object sender, EventArgs e)
      {
         if ((mInitVectorError == false) && (mPasswordError == false))
         {
            Password = txtPassword.Text;
            InitializationVector = txtIV.Text;
            DialogResult = DialogResult.OK;
            this.Close();
         }
      }

      private void cmdCancel_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.Cancel;
         Password = "";
         InitializationVector = "";
         this.Close();
      }
   }
}
