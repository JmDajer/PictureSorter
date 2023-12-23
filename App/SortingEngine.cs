﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class SortingEngine
    {
        private string ImportPath { get; set; }
        private string ExportPath { get; set; }

        public SortingEngine(string importPath, string exportPath)
        {
            ImportPath = importPath;
            ExportPath = exportPath;
        }

        public void Sort()
        {
            var images = Directory.EnumerateFiles(ImportPath);
            foreach (var image in images)
            {
                var date = GetImageDate(image);
                var folderPath = CreateFolder(date);
                var fileName = image.Split(Path.PathSeparator).Last();
                var copyFilePath = Path.Combine(folderPath, fileName);
                File.Copy(image, copyFilePath, true);
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

        private string GetImageDate(string imagePath)
        {
            string fileDate = "";

            try
            {
                using (var image = Image.FromFile(imagePath))
                {
                    var propertyItems = image.PropertyItems;

                    foreach (var propertyItem in propertyItems)
                    {
                        if (propertyItem.Id == 0x0132)
                        {
                            string dateString = Encoding.UTF8.GetString(propertyItem.Value);
                            DateTime dateTime = DateTime.ParseExact(dateString, "yyyy:MM:d H:m:s", null);
                            fileDate = dateTime.Date.ToString();
                            image.Dispose();
                        }
                    }   
                }
            } 
            
            catch (Exception e)
            {
                Console.Error.WriteLine(e.ToString());
            }

            return fileDate;
        }
    }
}
