namespace PasswordManager
{
   partial class InitializationVectorUpdate
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
         this.cmdCancel = new System.Windows.Forms.Button();
         this.cmdOK = new System.Windows.Forms.Button();
         this.txtReenterNewInitializationVector = new System.Windows.Forms.TextBox();
         this.lblReenterNewInitializationVector = new System.Windows.Forms.Label();
         this.txtNewInitializationVector = new System.Windows.Forms.TextBox();
         this.lblNewInitializationVector = new System.Windows.Forms.Label();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.lblPassword = new System.Windows.Forms.Label();
         this.errInitializationVector = new System.Windows.Forms.ErrorProvider(this.components);
         this.errCurrentPassword = new System.Windows.Forms.ErrorProvider(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.errInitializationVector)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.errCurrentPassword)).BeginInit();
         this.SuspendLayout();
         // 
         // cmdCancel
         // 
         this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.cmdCancel.Location = new System.Drawing.Point(265, 121);
         this.cmdCancel.Name = "cmdCancel";
         this.cmdCancel.Size = new System.Drawing.Size(75, 30);
         this.cmdCancel.TabIndex = 23;
         this.cmdCancel.Text = "Cancel";
         this.cmdCancel.UseVisualStyleBackColor = true;
         this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
         // 
         // cmdOK
         // 
         this.cmdOK.Location = new System.Drawing.Point(346, 121);
         this.cmdOK.Name = "cmdOK";
         this.cmdOK.Size = new System.Drawing.Size(75, 30);
         this.cmdOK.TabIndex = 24;
         this.cmdOK.Text = "OK";
         this.cmdOK.UseVisualStyleBackColor = true;
         this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
         // 
         // txtReenterNewInitializationVector
         // 
         this.txtReenterNewInitializationVector.Location = new System.Drawing.Point(185, 76);
         this.txtReenterNewInitializationVector.Name = "txtReenterNewInitializationVector";
         this.txtReenterNewInitializationVector.Size = new System.Drawing.Size(236, 20);
         this.txtReenterNewInitializationVector.TabIndex = 21;
         this.txtReenterNewInitializationVector.UseSystemPasswordChar = true;
         // 
         // lblReenterNewInitializationVector
         // 
         this.lblReenterNewInitializationVector.AutoSize = true;
         this.lblReenterNewInitializationVector.Location = new System.Drawing.Point(12, 79);
         this.lblReenterNewInitializationVector.Name = "lblReenterNewInitializationVector";
         this.lblReenterNewInitializationVector.Size = new System.Drawing.Size(167, 13);
         this.lblReenterNewInitializationVector.TabIndex = 22;
         this.lblReenterNewInitializationVector.Text = "Re-enter New Initialization Vector:";
         this.lblReenterNewInitializationVector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // txtNewInitializationVector
         // 
         this.txtNewInitializationVector.Location = new System.Drawing.Point(185, 50);
         this.txtNewInitializationVector.Name = "txtNewInitializationVector";
         this.txtNewInitializationVector.Size = new System.Drawing.Size(236, 20);
         this.txtNewInitializationVector.TabIndex = 19;
         this.txtNewInitializationVector.UseSystemPasswordChar = true;
         // 
         // lblNewInitializationVector
         // 
         this.lblNewInitializationVector.AutoSize = true;
         this.lblNewInitializationVector.Location = new System.Drawing.Point(28, 53);
         this.lblNewInitializationVector.Name = "lblNewInitializationVector";
         this.lblNewInitializationVector.Size = new System.Drawing.Size(151, 13);
         this.lblNewInitializationVector.TabIndex = 20;
         this.lblNewInitializationVector.Text = "Enter New Initialization Vector:";
         this.lblNewInitializationVector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(185, 12);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Size = new System.Drawing.Size(236, 20);
         this.txtPassword.TabIndex = 17;
         this.txtPassword.UseSystemPasswordChar = true;
         // 
         // lblPassword
         // 
         this.lblPassword.AutoSize = true;
         this.lblPassword.Location = new System.Drawing.Point(58, 15);
         this.lblPassword.Name = "lblPassword";
         this.lblPassword.Size = new System.Drawing.Size(121, 13);
         this.lblPassword.TabIndex = 18;
         this.lblPassword.Text = "Enter Current Password:";
         this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // errInitializationVector
         // 
         this.errInitializationVector.ContainerControl = this;
         // 
         // errCurrentPassword
         // 
         this.errCurrentPassword.ContainerControl = this;
         // 
         // InitializationVectorUpdate
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(435, 175);
         this.Controls.Add(this.cmdCancel);
         this.Controls.Add(this.cmdOK);
         this.Controls.Add(this.txtReenterNewInitializationVector);
         this.Controls.Add(this.lblReenterNewInitializationVector);
         this.Controls.Add(this.txtNewInitializationVector);
         this.Controls.Add(this.lblNewInitializationVector);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.lblPassword);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "InitializationVectorUpdate";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Update Initialization Vector";
         ((System.ComponentModel.ISupportInitialize)(this.errInitializationVector)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.errCurrentPassword)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button cmdCancel;
      private System.Windows.Forms.Button cmdOK;
      private System.Windows.Forms.TextBox txtReenterNewInitializationVector;
      private System.Windows.Forms.Label lblReenterNewInitializationVector;
      private System.Windows.Forms.TextBox txtNewInitializationVector;
      private System.Windows.Forms.Label lblNewInitializationVector;
      private System.Windows.Forms.TextBox txtPassword;
      private System.Windows.Forms.Label lblPassword;
      private System.Windows.Forms.ErrorProvider errInitializationVector;
      private System.Windows.Forms.ErrorProvider errCurrentPassword;
   }
}