using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            SortingEngine sortingEngine = new SortingEngine(ImportTextBox.Text, ExportTextBox.Text);
            sortingEngine.Sort();
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
