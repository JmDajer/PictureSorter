using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            bool formReady = true;

            if (ImportTextBox.Text is null || ImportTextBox.Text is "")
            {
                ImportErrorProvider.SetError(this.ImportButton, "Piltide kausta on vaja!");
                formReady = false;
                
            } 
            else
            {
                ImportErrorProvider.SetError(this.ImportButton, string.Empty);
            }

            if (ExportTextBox.Text is null || ExportTextBox.Text is "")
            {
                ExportErrorProvider.SetError(this.ExportButton, "Kausta kuhu sorteeritud pildid panna on vaja!");
                formReady = false;
            }
            else
            {
                ExportErrorProvider.SetError(this.ExportButton, string.Empty);
            }

            if (formReady) {
                SortingEngine sortingEngine = new SortingEngine(ImportTextBox.Text, ExportTextBox.Text);
                ProgressText.Text = "Töötlen, palun oota.";
                sortingEngine.Sort();
                ProgressText.Text = "Valmis!";
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ImportTextBox.Text = dialog.SelectedPath;
                Environment.SpecialFolder root = dialog.RootFolder;
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ExportTextBox.Text = dialog.SelectedPath;
                Environment.SpecialFolder root = dialog.RootFolder;
            }
        }
    }
}
