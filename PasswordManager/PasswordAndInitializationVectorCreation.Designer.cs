namespace PasswordManager
{
   partial class PasswordAndInitializationVectorCreation
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
         this.cmdOK = new System.Windows.Forms.Button();
         this.cmdCancel = new System.Windows.Forms.Button();
         this.lblPassword = new System.Windows.Forms.Label();
         this.lblIV = new System.Windows.Forms.Label();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.txtIV = new System.Windows.Forms.TextBox();
         this.txtReenterIV = new System.Windows.Forms.TextBox();
         this.lblReenterIV = new System.Windows.Forms.Label();
         this.txtReenterPassword = new System.Windows.Forms.TextBox();
         this.lblReenterPassword = new System.Windows.Forms.Label();
         this.errPasswordMismatch = new System.Windows.Forms.ErrorProvider(this.components);
         this.errIVMismatch = new System.Windows.Forms.ErrorProvider(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.errPasswordMismatch)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errIVMismatch)).BeginInit();
         this.SuspendLayout();
         // 
         // cmdOK
         // 
         this.cmdOK.Location = new System.Drawing.Point(277, 139);
         this.cmdOK.Name = "cmdOK";
         this.cmdOK.Size = new System.Drawing.Size(75, 30);
         this.cmdOK.TabIndex = 5;
         this.cmdOK.Text = "OK";
         this.cmdOK.UseVisualStyleBackColor = true;
         this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
         // 
         // cmdCancel
         // 
         this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.cmdCancel.Location = new System.Drawing.Point(196, 139);
         this.cmdCancel.Name = "cmdCancel";
         this.cmdCancel.Size = new System.Drawing.Size(75, 30);
         this.cmdCancel.TabIndex = 4;
         this.cmdCancel.Text = "Cancel";
         this.cmdCancel.UseVisualStyleBackColor = true;
         this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
         // 
         // lblPassword
         // 
         this.lblPassword.AutoSize = true;
         this.lblPassword.Location = new System.Drawing.Point(20, 9);
         this.lblPassword.Name = "lblPassword";
         this.lblPassword.Size = new System.Drawing.Size(84, 13);
         this.lblPassword.TabIndex = 2;
         this.lblPassword.Text = "Enter Password:";
         this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // lblIV
         // 
         this.lblIV.AutoSize = true;
         this.lblIV.Location = new System.Drawing.Point(56, 70);
         this.lblIV.Name = "lblIV";
         this.lblIV.Size = new System.Drawing.Size(48, 13);
         this.lblIV.TabIndex = 3;
         this.lblIV.Text = "Enter IV:";
         this.lblIV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(110, 6);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Size = new System.Drawing.Size(242, 20);
         this.txtPassword.TabIndex = 0;
         this.txtPassword.UseSystemPasswordChar = true;
         this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
         // 
         // txtIV
         // 
         this.txtIV.Location = new System.Drawing.Point(110, 67);
         this.txtIV.Name = "txtIV";
         this.txtIV.Size = new System.Drawing.Size(242, 20);
         this.txtIV.TabIndex = 2;
         this.txtIV.UseSystemPasswordChar = true;
         this.txtIV.TextChanged += new System.EventHandler(this.txtIV_TextChanged);
         // 
         // txtReenterIV
         // 
         this.txtReenterIV.Location = new System.Drawing.Point(110, 93);
         this.txtReenterIV.Name = "txtReenterIV";
         this.txtReenterIV.Size = new System.Drawing.Size(242, 20);
         this.txtReenterIV.TabIndex = 3;
         this.txtReenterIV.UseSystemPasswordChar = true;
         this.txtReenterIV.TextChanged += new System.EventHandler(this.txtReenterIV_TextChanged);
         // 
         // lblReenterIV
         // 
         this.lblReenterIV.AutoSize = true;
         this.lblReenterIV.Location = new System.Drawing.Point(43, 96);
         this.lblReenterIV.Name = "lblReenterIV";
         this.lblReenterIV.Size = new System.Drawing.Size(61, 13);
         this.lblReenterIV.TabIndex = 6;
         this.lblReenterIV.Text = "Reenter IV:";
         this.lblReenterIV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // txtReenterPassword
         // 
         this.txtReenterPassword.Location = new System.Drawing.Point(110, 32);
         this.txtReenterPassword.Name = "txtReenterPassword";
         this.txtReenterPassword.Size = new System.Drawing.Size(242, 20);
         this.txtReenterPassword.TabIndex = 1;
         this.txtReenterPassword.UseSystemPasswordChar = true;
         this.txtReenterPassword.TextChanged += new System.EventHandler(this.txtReenterPassword_TextChanged);
         // 
         // lblReenterPassword
         // 
         this.lblReenterPassword.AutoSize = true;
         this.lblReenterPassword.Location = new System.Drawing.Point(7, 35);
         this.lblReenterPassword.Name = "lblReenterPassword";
         this.lblReenterPassword.Size = new System.Drawing.Size(97, 13);
         this.lblReenterPassword.TabIndex = 8;
         this.lblReenterPassword.Text = "Reenter Password:";
         this.lblReenterPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // errPasswordMismatch
         // 
         this.errPasswordMismatch.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
         this.errPasswordMismatch.ContainerControl = this;
         // 
         // errIVMismatch
         // 
         this.errIVMismatch.ContainerControl = this;
         // 
         // PasswordAndInitializationVectorCreation
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.CancelButton = this.cmdCancel;
         this.ClientSize = new System.Drawing.Size(378, 181);
         this.Controls.Add(this.txtReenterPassword);
         this.Controls.Add(this.lblReenterPassword);
         this.Controls.Add(this.txtReenterIV);
         this.Controls.Add(this.lblReenterIV);
         this.Controls.Add(this.txtIV);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.lblIV);
         this.Controls.Add(this.lblPassword);
         this.Controls.Add(this.cmdCancel);
         this.Controls.Add(this.cmdOK);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "PasswordAndInitializationVectorCreation";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Create Password And Initialization Vector";
         this.Load += new System.EventHandler(this.PasswordAndInitializatiionVector_Load);
         ((System.ComponentModel.ISupportInitialize)(this.errPasswordMismatch)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errIVMismatch)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button cmdOK;
      private System.Windows.Forms.Button cmdCancel;
      private System.Windows.Forms.Label lblPassword;
      private System.Windows.Forms.Label lblIV;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.TextBox txtIV;
      private System.Windows.Forms.TextBox txtReenterIV;
      private System.Windows.Forms.Label lblReenterIV;
      private System.Windows.Forms.TextBox txtReenterPassword;
      private System.Windows.Forms.Label lblReenterPassword;
      private System.Windows.Forms.ErrorProvider errPasswordMismatch;
      private System.Windows.Forms.ErrorProvider errIVMismatch;
   }
}