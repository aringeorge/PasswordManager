namespace PasswordManager
{
   partial class PasswordManager
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
         this.mnuToolStripMenu = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.modifyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.editInitializationVectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.aboutToolStripMenuItemDialog = new System.Windows.Forms.ToolStripMenuItem();
         this.gridViewPasswordListData = new System.Windows.Forms.DataGridView();
         this.colTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.rowsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.gridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.dlgOpenPasswordFile = new System.Windows.Forms.OpenFileDialog();
         this.dlgSavePasswordFile = new System.Windows.Forms.SaveFileDialog();
         this.dlgSaveAsPasswordFile = new System.Windows.Forms.SaveFileDialog();
         this.mnuToolStripMenu.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewPasswordListData)).BeginInit();
         this.rowsContextMenu.SuspendLayout();
         this.gridContextMenu.SuspendLayout();
         this.SuspendLayout();
         // 
         // mnuToolStripMenu
         // 
         this.mnuToolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
         this.mnuToolStripMenu.Location = new System.Drawing.Point(0, 0);
         this.mnuToolStripMenu.Name = "mnuToolStripMenu";
         this.mnuToolStripMenu.Size = new System.Drawing.Size(478, 24);
         this.mnuToolStripMenu.TabIndex = 0;
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // newToolStripMenuItem
         // 
         this.newToolStripMenuItem.Name = "newToolStripMenuItem";
         this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
         this.newToolStripMenuItem.Text = "New";
         this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
         // 
         // openToolStripMenuItem
         // 
         this.openToolStripMenuItem.Name = "openToolStripMenuItem";
         this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
         this.openToolStripMenuItem.Text = "Open";
         this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
         this.saveToolStripMenuItem.Text = "Save";
         this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
         // 
         // saveAsToolStripMenuItem
         // 
         this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
         this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
         this.saveAsToolStripMenuItem.Text = "Save As";
         this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
         // 
         // closeToolStripMenuItem
         // 
         this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
         this.closeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
         this.closeToolStripMenuItem.Text = "Close";
         this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
         this.exitToolStripMenuItem.Text = "Exit";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
         // 
         // editToolStripMenuItem
         // 
         this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyPasswordToolStripMenuItem,
            this.editInitializationVectorToolStripMenuItem});
         this.editToolStripMenuItem.Name = "editToolStripMenuItem";
         this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
         this.editToolStripMenuItem.Text = "Edit";
         // 
         // modifyPasswordToolStripMenuItem
         // 
         this.modifyPasswordToolStripMenuItem.Name = "modifyPasswordToolStripMenuItem";
         this.modifyPasswordToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
         this.modifyPasswordToolStripMenuItem.Text = "Edit Password";
         this.modifyPasswordToolStripMenuItem.Click += new System.EventHandler(this.modifyPasswordToolStripMenuItem_Click);
         // 
         // editInitializationVectorToolStripMenuItem
         // 
         this.editInitializationVectorToolStripMenuItem.Name = "editInitializationVectorToolStripMenuItem";
         this.editInitializationVectorToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
         this.editInitializationVectorToolStripMenuItem.Text = "Edit Initialization Vector";
         this.editInitializationVectorToolStripMenuItem.Click += new System.EventHandler(this.editInitializationVectorToolStripMenuItem_Click);
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItemDialog});
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
         this.aboutToolStripMenuItem.Text = "About";
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
         this.helpToolStripMenuItem.Text = "Help";
         // 
         // aboutToolStripMenuItemDialog
         // 
         this.aboutToolStripMenuItemDialog.Name = "aboutToolStripMenuItemDialog";
         this.aboutToolStripMenuItemDialog.Size = new System.Drawing.Size(107, 22);
         this.aboutToolStripMenuItemDialog.Text = "About";
         this.aboutToolStripMenuItemDialog.Click += new System.EventHandler(this.aboutToolStripMenuItemDialog_Click);
         // 
         // gridViewPasswordListData
         // 
         this.gridViewPasswordListData.AllowUserToAddRows = false;
         this.gridViewPasswordListData.AllowUserToDeleteRows = false;
         this.gridViewPasswordListData.AllowUserToResizeRows = false;
         this.gridViewPasswordListData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.gridViewPasswordListData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
         this.gridViewPasswordListData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
         this.gridViewPasswordListData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         this.gridViewPasswordListData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTag,
            this.colUsername,
            this.colPassword});
         this.gridViewPasswordListData.ContextMenuStrip = this.gridContextMenu;
         this.gridViewPasswordListData.GridColor = System.Drawing.SystemColors.Control;
         this.gridViewPasswordListData.Location = new System.Drawing.Point(12, 27);
         this.gridViewPasswordListData.MultiSelect = false;
         this.gridViewPasswordListData.Name = "gridViewPasswordListData";
         this.gridViewPasswordListData.ReadOnly = true;
         this.gridViewPasswordListData.RowHeadersVisible = false;
         this.gridViewPasswordListData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         this.gridViewPasswordListData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.gridViewPasswordListData.ShowEditingIcon = false;
         this.gridViewPasswordListData.ShowRowErrors = false;
         this.gridViewPasswordListData.Size = new System.Drawing.Size(458, 283);
         this.gridViewPasswordListData.TabIndex = 1;
         this.gridViewPasswordListData.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridViewPasswordListData_CellMouseDown);
         // 
         // colTag
         // 
         this.colTag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
         this.colTag.ContextMenuStrip = this.rowsContextMenu;
         this.colTag.HeaderText = "Tag";
         this.colTag.Name = "colTag";
         this.colTag.ReadOnly = true;
         this.colTag.Width = 51;
         // 
         // rowsContextMenu
         // 
         this.rowsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.deleteToolStripMenuItem});
         this.rowsContextMenu.Name = "rowsContextMenu";
         this.rowsContextMenu.Size = new System.Drawing.Size(113, 48);
         // 
         // modifyToolStripMenuItem
         // 
         this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
         this.modifyToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
         this.modifyToolStripMenuItem.Text = "Modify";
         this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
         // 
         // deleteToolStripMenuItem
         // 
         this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
         this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
         this.deleteToolStripMenuItem.Text = "Delete";
         this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
         // 
         // colUsername
         // 
         this.colUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
         this.colUsername.ContextMenuStrip = this.rowsContextMenu;
         this.colUsername.HeaderText = "Username";
         this.colUsername.Name = "colUsername";
         this.colUsername.ReadOnly = true;
         this.colUsername.Width = 80;
         // 
         // colPassword
         // 
         this.colPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
         this.colPassword.ContextMenuStrip = this.rowsContextMenu;
         this.colPassword.HeaderText = "Password";
         this.colPassword.Name = "colPassword";
         this.colPassword.ReadOnly = true;
         this.colPassword.Width = 78;
         // 
         // gridContextMenu
         // 
         this.gridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem});
         this.gridContextMenu.Name = "gridContextMenu";
         this.gridContextMenu.Size = new System.Drawing.Size(97, 26);
         // 
         // addNewToolStripMenuItem
         // 
         this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
         this.addNewToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
         this.addNewToolStripMenuItem.Text = "Add";
         this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
         // 
         // dlgOpenPasswordFile
         // 
         this.dlgOpenPasswordFile.DefaultExt = "agt";
         this.dlgOpenPasswordFile.RestoreDirectory = true;
         this.dlgOpenPasswordFile.Title = "Open Password File";
         // 
         // dlgSavePasswordFile
         // 
         this.dlgSavePasswordFile.CheckFileExists = true;
         this.dlgSavePasswordFile.DefaultExt = "agt";
         this.dlgSavePasswordFile.OverwritePrompt = false;
         this.dlgSavePasswordFile.RestoreDirectory = true;
         // 
         // dlgSaveAsPasswordFile
         // 
         this.dlgSaveAsPasswordFile.DefaultExt = "agt";
         this.dlgSaveAsPasswordFile.OverwritePrompt = false;
         this.dlgSaveAsPasswordFile.RestoreDirectory = true;
         // 
         // PasswordManager
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(478, 322);
         this.Controls.Add(this.gridViewPasswordListData);
         this.Controls.Add(this.mnuToolStripMenu);
         this.MainMenuStrip = this.mnuToolStripMenu;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "PasswordManager";
         this.Text = "Password Manager";
         this.mnuToolStripMenu.ResumeLayout(false);
         this.mnuToolStripMenu.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewPasswordListData)).EndInit();
         this.rowsContextMenu.ResumeLayout(false);
         this.gridContextMenu.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip mnuToolStripMenu;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.DataGridView gridViewPasswordListData;
      private System.Windows.Forms.ContextMenuStrip gridContextMenu;
      private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
      private System.Windows.Forms.ContextMenuStrip rowsContextMenu;
      private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
      private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
      private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
      private System.Windows.Forms.DataGridViewTextBoxColumn colTag;
      private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem modifyPasswordToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem editInitializationVectorToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItemDialog;
      private System.Windows.Forms.OpenFileDialog dlgOpenPasswordFile;
      private System.Windows.Forms.SaveFileDialog dlgSavePasswordFile;
      private System.Windows.Forms.SaveFileDialog dlgSaveAsPasswordFile;
   }
}

