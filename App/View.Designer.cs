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
            this.sort = new System.Windows.Forms.Button();
            this.FolderLocationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureLocationButton = new System.Windows.Forms.Button();
            this.OutputLocationButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputPictureTextBox = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.InputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderSettingsBox = new System.Windows.Forms.GroupBox();
            this.FolderSettingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sort
            // 
            this.sort.BackColor = System.Drawing.Color.RoyalBlue;
            this.sort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sort.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.sort.FlatAppearance.BorderSize = 10;
            this.sort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sort.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sort.Location = new System.Drawing.Point(75, 222);
            this.sort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sort.Name = "sort";
            this.sort.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sort.Size = new System.Drawing.Size(75, 41);
            this.sort.TabIndex = 0;
            this.sort.Text = "Sorteeri";
            this.sort.UseVisualStyleBackColor = false;
            // 
            // FolderLocationTextBox
            // 
            this.FolderLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FolderLocationTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderLocationTextBox.Location = new System.Drawing.Point(11, 65);
            this.FolderLocationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FolderLocationTextBox.Name = "FolderLocationTextBox";
            this.FolderLocationTextBox.Size = new System.Drawing.Size(472, 26);
            this.FolderLocationTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Piltide asukoht";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PictureLocationButton
            // 
            this.PictureLocationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureLocationButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureLocationButton.Location = new System.Drawing.Point(487, 64);
            this.PictureLocationButton.Margin = new System.Windows.Forms.Padding(0);
            this.PictureLocationButton.Name = "PictureLocationButton";
            this.PictureLocationButton.Size = new System.Drawing.Size(30, 27);
            this.PictureLocationButton.TabIndex = 3;
            this.PictureLocationButton.Text = "...";
            this.PictureLocationButton.UseVisualStyleBackColor = true;
            this.PictureLocationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OutputLocationButton
            // 
            this.OutputLocationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OutputLocationButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLocationButton.Location = new System.Drawing.Point(487, 125);
            this.OutputLocationButton.Margin = new System.Windows.Forms.Padding(0);
            this.OutputLocationButton.Name = "OutputLocationButton";
            this.OutputLocationButton.Size = new System.Drawing.Size(30, 27);
            this.OutputLocationButton.TabIndex = 6;
            this.OutputLocationButton.Text = "...";
            this.OutputLocationButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sorteeritud piltide auskoht";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OutputPictureTextBox
            // 
            this.OutputPictureTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputPictureTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputPictureTextBox.Location = new System.Drawing.Point(11, 126);
            this.OutputPictureTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OutputPictureTextBox.Name = "OutputPictureTextBox";
            this.OutputPictureTextBox.Size = new System.Drawing.Size(472, 26);
            this.OutputPictureTextBox.TabIndex = 4;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(156, 222);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(444, 41);
            this.ProgressBar.TabIndex = 7;
            // 
            // InputFolderBrowserDialog
            // 
            this.InputFolderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // FolderSettingsBox
            // 
            this.FolderSettingsBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FolderSettingsBox.Controls.Add(this.FolderLocationTextBox);
            this.FolderSettingsBox.Controls.Add(this.label1);
            this.FolderSettingsBox.Controls.Add(this.OutputLocationButton);
            this.FolderSettingsBox.Controls.Add(this.PictureLocationButton);
            this.FolderSettingsBox.Controls.Add(this.label2);
            this.FolderSettingsBox.Controls.Add(this.OutputPictureTextBox);
            this.FolderSettingsBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderSettingsBox.Location = new System.Drawing.Point(75, 32);
            this.FolderSettingsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FolderSettingsBox.Name = "FolderSettingsBox";
            this.FolderSettingsBox.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.FolderSettingsBox.Size = new System.Drawing.Size(525, 165);
            this.FolderSettingsBox.TabIndex = 8;
            this.FolderSettingsBox.TabStop = false;
            this.FolderSettingsBox.Text = "Kausta sätted";
            this.FolderSettingsBox.Enter += new System.EventHandler(this.FolderSettingsBox_Enter);
            // 
            // View
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 303);
            this.Controls.Add(this.FolderSettingsBox);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.sort);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureManager";
            this.Load += new System.EventHandler(this.View_Load);
            this.FolderSettingsBox.ResumeLayout(false);
            this.FolderSettingsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.TextBox FolderLocationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PictureLocationButton;
        private System.Windows.Forms.Button OutputLocationButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutputPictureTextBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.FolderBrowserDialog InputFolderBrowserDialog;
        private System.Windows.Forms.GroupBox FolderSettingsBox;
    }
}

