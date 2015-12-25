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
   public partial class PasswordAndInititalizationVectorRead : Form
   {
      public string Password { get; private set; }
      public string InitializationVector { get; private set; }

      private bool mPasswordValid = false;
      private bool mInitializationVectorValid = false;

      public PasswordAndInititalizationVectorRead()
      {
         InitializeComponent();

         txtIV.Text = "";
         txtPassword.Text = "";

         mPasswordValid = false;
         mInitializationVectorValid = false;

         cmdOK.Enabled = false;
      }

      private void cmdCancel_Click(object sender, EventArgs e)
      {
         txtIV.Text = "";
         txtPassword.Text = "";
         Password = "";
         InitializationVector = "";
         DialogResult = DialogResult.Cancel;
         this.Close();
      }

      private void cmdOK_Click(object sender, EventArgs e)
      {
         if ((mPasswordValid == true) && (mInitializationVectorValid == true))
         {
            DialogResult = DialogResult.OK;
            Password = txtPassword.Text;
            InitializationVector = txtIV.Text;
            this.Close();
         }
      }

      private void txtPassword_TextChanged(object sender, EventArgs e)
      {
         mPasswordValid = (txtPassword.Text.Length > 0);
         cmdOK.Enabled = ((mPasswordValid == true) && (mInitializationVectorValid == true));
      }

      private void txtIV_TextChanged(object sender, EventArgs e)
      {
         mInitializationVectorValid = (txtIV.Text.Length > 0);
         cmdOK.Enabled = ((mPasswordValid == true) && (mInitializationVectorValid == true));
      }
   }
}
