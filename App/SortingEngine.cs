﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace App
{

    internal class SortingProgressEventArgs : EventArgs
    {
        public int Progress { get; set; }
    }

    internal class SortingEngine
    {
        const int DateTakenId = 0x9003;

        private string ImportPath { get; set; }
        private string ExportPath { get; set; }

        public event EventHandler<SortingProgressEventArgs> SortingProgressChanged;

        public SortingEngine(string importPath, string exportPath)
        {
            ImportPath = importPath;
            ExportPath = exportPath;
        }

        protected virtual void OnSortingProgressChanged(int progress)
        {
            SortingProgressChanged?.Invoke(this, new SortingProgressEventArgs { Progress = progress });
        }

        public void Sort()
        {
            var images = Directory.EnumerateFiles(ImportPath).ToArray();
            var currentImage = 0;
            var totalImages = images.Length;

            foreach (var image in images)
            {
                var date = GetImageTakenDate(image);
                var folderPath = CreateFolder(date);
                var fileName = image.Split(Path.DirectorySeparatorChar).Last();
                var copyFilePath = Path.Combine(folderPath, fileName);
                File.Copy(image, copyFilePath, true);

                currentImage++;
                var progress = currentImage / totalImages * 100;
                OnSortingProgressChanged(progress);
            }
        }

        private string CreateFolder(string folderName)
        {
            var folderPath = Path.Combine(ExportPath, folderName);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            return folderPath;
        }

        private string GetImageTakenDate(string imagePath)
        {
            string fileDate = "Teadmata";

            using (var image = Image.FromFile(imagePath))
            {
                if (image.PropertyItems.Any(p => p.Id is DateTakenId))
                {
                    var dateTaken = image.GetPropertyItem(DateTakenId).Value;
                    var date = Encoding.UTF8.GetString(dateTaken).Trim().Substring(0, 10);
                    var parsedDate = DateTime.ParseExact(date, "yyyy:MM:dd", CultureInfo.InvariantCulture);
                    fileDate = parsedDate.ToString("dd-MM-yyyy");
                }
                image.Dispose();
            }

            return fileDate;
        }
    }
}
