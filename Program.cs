using System;
using System.Globalization;
using System.IO;

namespace Course {
    class Program {
        static void Main(string[] args) {

            try {
                var line = string.Format("{0},{1}", "first", "B");

                string sourceFolderPath = @"C:\Users\Luan\Documents\Out";
                string targetFilePath = sourceFolderPath + @"\summary.csv";

                Directory.CreateDirectory(sourceFolderPath);

                using (StreamWriter sw = File.CreateText(targetFilePath)) {
                    for (int i = 0; i < line.Length ; i++)
                    {
                        sw.WriteLine(line);
                    }                   
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
