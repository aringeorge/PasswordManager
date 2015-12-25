namespace PasswordManager
{
   partial class PasswordAndInititalizationVectorRead
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
         this.txtIV = new System.Windows.Forms.TextBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.lblIV = new System.Windows.Forms.Label();
         this.lblPassword = new System.Windows.Forms.Label();
         this.cmdCancel = new System.Windows.Forms.Button();
         this.cmdOK = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // txtIV
         // 
         this.txtIV.Location = new System.Drawing.Point(102, 38);
         this.txtIV.Name = "txtIV";
         this.txtIV.Size = new System.Drawing.Size(236, 20);
         this.txtIV.TabIndex = 1;
         this.txtIV.UseSystemPasswordChar = true;
         this.txtIV.TextChanged += new System.EventHandler(this.txtIV_TextChanged);
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(102, 12);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Size = new System.Drawing.Size(236, 20);
         this.txtPassword.TabIndex = 0;
         this.txtPassword.UseSystemPasswordChar = true;
         this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
         // 
         // lblIV
         // 
         this.lblIV.AutoSize = true;
         this.lblIV.Location = new System.Drawing.Point(48, 41);
         this.lblIV.Name = "lblIV";
         this.lblIV.Size = new System.Drawing.Size(48, 13);
         this.lblIV.TabIndex = 9;
         this.lblIV.Text = "Enter IV:";
         this.lblIV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // lblPassword
         // 
         this.lblPassword.AutoSize = true;
         this.lblPassword.Location = new System.Drawing.Point(12, 15);
         this.lblPassword.Name = "lblPassword";
         this.lblPassword.Size = new System.Drawing.Size(84, 13);
         this.lblPassword.TabIndex = 8;
         this.lblPassword.Text = "Enter Password:";
         this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // cmdCancel
         // 
         this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.cmdCancel.Location = new System.Drawing.Point(182, 84);
         this.cmdCancel.Name = "cmdCancel";
         this.cmdCancel.Size = new System.Drawing.Size(75, 30);
         this.cmdCancel.TabIndex = 2;
         this.cmdCancel.Text = "Cancel";
         this.cmdCancel.UseVisualStyleBackColor = true;
         this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
         // 
         // cmdOK
         // 
         this.cmdOK.Location = new System.Drawing.Point(263, 84);
         this.cmdOK.Name = "cmdOK";
         this.cmdOK.Size = new System.Drawing.Size(75, 30);
         this.cmdOK.TabIndex = 3;
         this.cmdOK.Text = "OK";
         this.cmdOK.UseVisualStyleBackColor = true;
         this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
         // 
         // PasswordAndInititalizationVectorRead
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.cmdCancel;
         this.ClientSize = new System.Drawing.Size(350, 126);
         this.Controls.Add(this.txtIV);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.lblIV);
         this.Controls.Add(this.lblPassword);
         this.Controls.Add(this.cmdCancel);
         this.Controls.Add(this.cmdOK);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "PasswordAndInititalizationVectorRead";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Enter Password And Inititalization Vector";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtIV;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.Label lblIV;
      private System.Windows.Forms.Label lblPassword;
      private System.Windows.Forms.Button cmdCancel;
      private System.Windows.Forms.Button cmdOK;
   }
}