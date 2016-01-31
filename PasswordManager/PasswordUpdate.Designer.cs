namespace PasswordManager
{
   partial class PasswordUpdate
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.lblPassword = new System.Windows.Forms.Label();
         this.txtNewPassword = new System.Windows.Forms.TextBox();
         this.lblNewPassword = new System.Windows.Forms.Label();
         this.txtReenterNewPassword = new System.Windows.Forms.TextBox();
         this.lblReenterNewPassword = new System.Windows.Forms.Label();
         this.cmdCancel = new System.Windows.Forms.Button();
         this.cmdOK = new System.Windows.Forms.Button();
         this.errCurrentPassword = new System.Windows.Forms.ErrorProvider(this.components);
         this.errNewPassword = new System.Windows.Forms.ErrorProvider(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.errCurrentPassword)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errNewPassword)).BeginInit();
         this.SuspendLayout();
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(139, 12);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Size = new System.Drawing.Size(236, 20);
         this.txtPassword.TabIndex = 9;
         this.txtPassword.UseSystemPasswordChar = true;
         this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
         // 
         // lblPassword
         // 
         this.lblPassword.AutoSize = true;
         this.lblPassword.Location = new System.Drawing.Point(12, 15);
         this.lblPassword.Name = "lblPassword";
         this.lblPassword.Size = new System.Drawing.Size(121, 13);
         this.lblPassword.TabIndex = 10;
         this.lblPassword.Text = "Enter Current Password:";
         this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // txtNewPassword
         // 
         this.txtNewPassword.Location = new System.Drawing.Point(139, 50);
         this.txtNewPassword.Name = "txtNewPassword";
         this.txtNewPassword.Size = new System.Drawing.Size(236, 20);
         this.txtNewPassword.TabIndex = 11;
         this.txtNewPassword.UseSystemPasswordChar = true;
         this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
         // 
         // lblNewPassword
         // 
         this.lblNewPassword.AutoSize = true;
         this.lblNewPassword.Location = new System.Drawing.Point(24, 53);
         this.lblNewPassword.Name = "lblNewPassword";
         this.lblNewPassword.Size = new System.Drawing.Size(109, 13);
         this.lblNewPassword.TabIndex = 12;
         this.lblNewPassword.Text = "Enter New Password:";
         this.lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // txtReenterNewPassword
         // 
         this.txtReenterNewPassword.Location = new System.Drawing.Point(139, 76);
         this.txtReenterNewPassword.Name = "txtReenterNewPassword";
         this.txtReenterNewPassword.Size = new System.Drawing.Size(236, 20);
         this.txtReenterNewPassword.TabIndex = 13;
         this.txtReenterNewPassword.UseSystemPasswordChar = true;
         this.txtReenterNewPassword.TextChanged += new System.EventHandler(this.txtReenterNewPassword_TextChanged);
         // 
         // lblReenterNewPassword
         // 
         this.lblReenterNewPassword.AutoSize = true;
         this.lblReenterNewPassword.Location = new System.Drawing.Point(8, 79);
         this.lblReenterNewPassword.Name = "lblReenterNewPassword";
         this.lblReenterNewPassword.Size = new System.Drawing.Size(125, 13);
         this.lblReenterNewPassword.TabIndex = 14;
         this.lblReenterNewPassword.Text = "Re-enter New Password:";
         this.lblReenterNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // cmdCancel
         // 
         this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.cmdCancel.Location = new System.Drawing.Point(219, 122);
         this.cmdCancel.Name = "cmdCancel";
         this.cmdCancel.Size = new System.Drawing.Size(75, 30);
         this.cmdCancel.TabIndex = 15;
         this.cmdCancel.Text = "Cancel";
         this.cmdCancel.UseVisualStyleBackColor = true;
         this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
         // 
         // cmdOK
         // 
         this.cmdOK.Location = new System.Drawing.Point(300, 122);
         this.cmdOK.Name = "cmdOK";
         this.cmdOK.Size = new System.Drawing.Size(75, 30);
         this.cmdOK.TabIndex = 16;
         this.cmdOK.Text = "OK";
         this.cmdOK.UseVisualStyleBackColor = true;
         this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
         // 
         // errCurrentPassword
         // 
         this.errCurrentPassword.ContainerControl = this;
         // 
         // errNewPassword
         // 
         this.errNewPassword.ContainerControl = this;
         // 
         // PasswordUpdate
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.cmdCancel;
         this.ClientSize = new System.Drawing.Size(391, 165);
         this.Controls.Add(this.cmdCancel);
         this.Controls.Add(this.cmdOK);
         this.Controls.Add(this.txtReenterNewPassword);
         this.Controls.Add(this.lblReenterNewPassword);
         this.Controls.Add(this.txtNewPassword);
         this.Controls.Add(this.lblNewPassword);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.lblPassword);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "PasswordUpdate";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Update Password";
         ((System.ComponentModel.ISupportInitialize)(this.errCurrentPassword)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errNewPassword)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.Label lblPassword;
      private System.Windows.Forms.TextBox txtNewPassword;
      private System.Windows.Forms.Label lblNewPassword;
      private System.Windows.Forms.TextBox txtReenterNewPassword;
      private System.Windows.Forms.Label lblReenterNewPassword;
      private System.Windows.Forms.Button cmdCancel;
      private System.Windows.Forms.Button cmdOK;
      private System.Windows.Forms.ErrorProvider errCurrentPassword;
      private System.Windows.Forms.ErrorProvider errNewPassword;
   }
}