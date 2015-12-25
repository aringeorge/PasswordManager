namespace PasswordManager
{
   partial class AddNewEntry
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
         this.lblTagLabel = new System.Windows.Forms.Label();
         this.lblUsernameLabel = new System.Windows.Forms.Label();
         this.lblPasswordLabel = new System.Windows.Forms.Label();
         this.txtTagInfo = new System.Windows.Forms.TextBox();
         this.txtUsername = new System.Windows.Forms.TextBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.cmdCancel = new System.Windows.Forms.Button();
         this.cmdOK = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lblTagLabel
         // 
         this.lblTagLabel.AutoSize = true;
         this.lblTagLabel.Location = new System.Drawing.Point(12, 9);
         this.lblTagLabel.Name = "lblTagLabel";
         this.lblTagLabel.Size = new System.Drawing.Size(84, 13);
         this.lblTagLabel.TabIndex = 0;
         this.lblTagLabel.Text = "Tag Information:";
         // 
         // lblUsernameLabel
         // 
         this.lblUsernameLabel.AutoSize = true;
         this.lblUsernameLabel.Location = new System.Drawing.Point(38, 35);
         this.lblUsernameLabel.Name = "lblUsernameLabel";
         this.lblUsernameLabel.Size = new System.Drawing.Size(58, 13);
         this.lblUsernameLabel.TabIndex = 1;
         this.lblUsernameLabel.Text = "Username:";
         // 
         // lblPasswordLabel
         // 
         this.lblPasswordLabel.AutoSize = true;
         this.lblPasswordLabel.Location = new System.Drawing.Point(40, 61);
         this.lblPasswordLabel.Name = "lblPasswordLabel";
         this.lblPasswordLabel.Size = new System.Drawing.Size(56, 13);
         this.lblPasswordLabel.TabIndex = 2;
         this.lblPasswordLabel.Text = "Password:";
         // 
         // txtTagInfo
         // 
         this.txtTagInfo.Location = new System.Drawing.Point(102, 6);
         this.txtTagInfo.Name = "txtTagInfo";
         this.txtTagInfo.Size = new System.Drawing.Size(170, 20);
         this.txtTagInfo.TabIndex = 0;
         this.txtTagInfo.TextChanged += new System.EventHandler(this.txtTagInfo_TextChanged);
         // 
         // txtUsername
         // 
         this.txtUsername.Location = new System.Drawing.Point(102, 32);
         this.txtUsername.Name = "txtUsername";
         this.txtUsername.Size = new System.Drawing.Size(170, 20);
         this.txtUsername.TabIndex = 1;
         this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(102, 58);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Size = new System.Drawing.Size(170, 20);
         this.txtPassword.TabIndex = 2;
         this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
         // 
         // cmdCancel
         // 
         this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.cmdCancel.Location = new System.Drawing.Point(116, 109);
         this.cmdCancel.Name = "cmdCancel";
         this.cmdCancel.Size = new System.Drawing.Size(75, 30);
         this.cmdCancel.TabIndex = 3;
         this.cmdCancel.Text = "Cancel";
         this.cmdCancel.UseVisualStyleBackColor = true;
         this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
         // 
         // cmdOK
         // 
         this.cmdOK.Location = new System.Drawing.Point(197, 109);
         this.cmdOK.Name = "cmdOK";
         this.cmdOK.Size = new System.Drawing.Size(75, 30);
         this.cmdOK.TabIndex = 4;
         this.cmdOK.Text = "OK";
         this.cmdOK.UseVisualStyleBackColor = true;
         this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
         // 
         // AddNewEntry
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.cmdCancel;
         this.ClientSize = new System.Drawing.Size(284, 151);
         this.Controls.Add(this.cmdCancel);
         this.Controls.Add(this.cmdOK);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.txtUsername);
         this.Controls.Add(this.txtTagInfo);
         this.Controls.Add(this.lblPasswordLabel);
         this.Controls.Add(this.lblUsernameLabel);
         this.Controls.Add(this.lblTagLabel);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "AddNewEntry";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Add New Entry";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblTagLabel;
      private System.Windows.Forms.Label lblUsernameLabel;
      private System.Windows.Forms.Label lblPasswordLabel;
      private System.Windows.Forms.TextBox txtTagInfo;
      private System.Windows.Forms.TextBox txtUsername;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.Button cmdCancel;
      private System.Windows.Forms.Button cmdOK;
   }
}