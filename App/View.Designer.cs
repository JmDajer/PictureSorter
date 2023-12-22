namespace App
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.SortButton = new System.Windows.Forms.Button();
            this.ImportTextBox = new System.Windows.Forms.TextBox();
            this.ImportLable = new System.Windows.Forms.Label();
            this.ImportButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ExportLable = new System.Windows.Forms.Label();
            this.ExportTextBox = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ImportBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderSettingsBox = new System.Windows.Forms.GroupBox();
            this.FolderSettingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SortButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.SortButton.FlatAppearance.BorderSize = 10;
            this.SortButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SortButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SortButton.Location = new System.Drawing.Point(75, 222);
            this.SortButton.Margin = new System.Windows.Forms.Padding(4);
            this.SortButton.Name = "SortButton";
            this.SortButton.Padding = new System.Windows.Forms.Padding(4);
            this.SortButton.Size = new System.Drawing.Size(75, 41);
            this.SortButton.TabIndex = 0;
            this.SortButton.Text = "Sorteeri";
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // ImportTextBox
            // 
            this.ImportTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportTextBox.Location = new System.Drawing.Point(11, 65);
            this.ImportTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImportTextBox.Name = "ImportTextBox";
            this.ImportTextBox.Size = new System.Drawing.Size(472, 26);
            this.ImportTextBox.TabIndex = 1;
            // 
            // ImportLable
            // 
            this.ImportLable.AutoSize = true;
            this.ImportLable.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportLable.Location = new System.Drawing.Point(10, 42);
            this.ImportLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ImportLable.Name = "ImportLable";
            this.ImportLable.Size = new System.Drawing.Size(102, 19);
            this.ImportLable.TabIndex = 2;
            this.ImportLable.Text = "Piltide asukoht";
            // 
            // ImportButton
            // 
            this.ImportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImportButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.Location = new System.Drawing.Point(487, 64);
            this.ImportButton.Margin = new System.Windows.Forms.Padding(0);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(30, 27);
            this.ImportButton.TabIndex = 3;
            this.ImportButton.Text = "...";
            this.ImportButton.UseVisualStyleBackColor = true;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.Location = new System.Drawing.Point(487, 125);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(30, 27);
            this.ExportButton.TabIndex = 6;
            this.ExportButton.Text = "...";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ExportLable
            // 
            this.ExportLable.AutoSize = true;
            this.ExportLable.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportLable.Location = new System.Drawing.Point(10, 103);
            this.ExportLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExportLable.Name = "ExportLable";
            this.ExportLable.Size = new System.Drawing.Size(176, 19);
            this.ExportLable.TabIndex = 5;
            this.ExportLable.Text = "Sorteeritud piltide auskoht";
            // 
            // ExportTextBox
            // 
            this.ExportTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportTextBox.Location = new System.Drawing.Point(11, 126);
            this.ExportTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ExportTextBox.Name = "ExportTextBox";
            this.ExportTextBox.Size = new System.Drawing.Size(472, 26);
            this.ExportTextBox.TabIndex = 4;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(156, 222);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(444, 41);
            this.ProgressBar.TabIndex = 7;
            // 
            // FolderSettingsBox
            // 
            this.FolderSettingsBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FolderSettingsBox.Controls.Add(this.ImportTextBox);
            this.FolderSettingsBox.Controls.Add(this.ImportLable);
            this.FolderSettingsBox.Controls.Add(this.ExportButton);
            this.FolderSettingsBox.Controls.Add(this.ImportButton);
            this.FolderSettingsBox.Controls.Add(this.ExportLable);
            this.FolderSettingsBox.Controls.Add(this.ExportTextBox);
            this.FolderSettingsBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderSettingsBox.Location = new System.Drawing.Point(75, 32);
            this.FolderSettingsBox.Margin = new System.Windows.Forms.Padding(2);
            this.FolderSettingsBox.Name = "FolderSettingsBox";
            this.FolderSettingsBox.Padding = new System.Windows.Forms.Padding(8);
            this.FolderSettingsBox.Size = new System.Drawing.Size(525, 165);
            this.FolderSettingsBox.TabIndex = 8;
            this.FolderSettingsBox.TabStop = false;
            this.FolderSettingsBox.Text = "Kausta sätted";
            // 
            // View
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 342);
            this.Controls.Add(this.FolderSettingsBox);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.SortButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureManager";
            this.FolderSettingsBox.ResumeLayout(false);
            this.FolderSettingsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.TextBox ImportTextBox;
        private System.Windows.Forms.Label ImportLable;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label ExportLable;
        private System.Windows.Forms.TextBox ExportTextBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.FolderBrowserDialog ImportBrowserDialog;
        private System.Windows.Forms.GroupBox FolderSettingsBox;
    }
}

