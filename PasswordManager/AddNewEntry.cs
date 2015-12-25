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
   public partial class AddNewEntry : Form
   {
      public string Username { get; private set; }
      public string Password { get; private set; }
      public string TagInfo { get; private set; }

      private bool mUsernameError = true;
      private bool mPasswordError = true;
      private bool mTagInfoError = true;

      public AddNewEntry()
      {
         InitializeComponent();

         mUsernameError = true;
         mPasswordError = true;
         mTagInfoError = true;

         txtTagInfo.Text = "";
         txtPassword.Text = "";
         txtUsername.Text = "";

         cmdOK.Enabled = false;
         
      }

      private void cmdOK_Click(object sender, EventArgs e)
      {
         if ((mUsernameError == false) && (mPasswordError == false) && (mTagInfoError == false))
         {
            DialogResult = DialogResult.OK;
            Username = txtUsername.Text;
            Password = txtPassword.Text;
            TagInfo = txtTagInfo.Text;
            this.Close();
         }
      }

      private bool IsStringValid(string value)
      {
         return ((value != null) && (string.IsNullOrEmpty(value) != true) && (string.IsNullOrWhiteSpace(value) != true) && (value.Trim().Length > 0));
      }

      private void cmdCancel_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.Cancel;
         Username = "";
         Password = "";
         TagInfo = "";
         this.Close();
      }

      private void txtTagInfo_TextChanged(object sender, EventArgs e)
      {
         mTagInfoError = (IsStringValid(txtTagInfo.Text) == false);
         cmdOK.Enabled = ((mTagInfoError == false) && (mUsernameError == false) && (mPasswordError == false));
      }

      private void txtUsername_TextChanged(object sender, EventArgs e)
      {
         mUsernameError = (IsStringValid(txtUsername.Text) == false);
         cmdOK.Enabled = ((mTagInfoError == false) && (mUsernameError == false) && (mPasswordError == false));
      }

      private void txtPassword_TextChanged(object sender, EventArgs e)
      {
         mPasswordError = (IsStringValid(txtPassword.Text) == false);
         cmdOK.Enabled = ((mTagInfoError == false) && (mUsernameError == false) && (mPasswordError == false));
      }
   }
}
