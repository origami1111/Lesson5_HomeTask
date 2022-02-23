using System;
using System.Collections.Generic;
using System.IO;

namespace Lesson5_HomeTask
{
    public class FileReaderWriter
    {
        private readonly List<int> firstNumber = new List<int>();
        private readonly List<int> secondNumber = new List<int>();

        private readonly string fileExtension;
        private readonly string textFile;
        private readonly string separator;

        public FileReaderWriter(string fileExtension, string separator)
        {
            this.fileExtension = fileExtension;
            this.separator = separator;
            textFile = $@"{Folders.DataFiles}\{Folders.Text}{fileExtension}";
        }

        public void WriteResults()
        {
            string oppositeExtension = fileExtension == FileExtensions.CsvExtension ?
                                                        FileExtensions.TxtExtension : FileExtensions.CsvExtension;
            string newFile = $@"{Folders.Output}_{DateTime.Now.ToString("MM.dd.yyyy")}{oppositeExtension}";
            FileStream fs = File.Create(newFile);

            using (StreamWriter sr = new StreamWriter(fs))
            {
                for (int i = 0; i < firstNumber.Count; i++)
                {
                    sr.Write($"{firstNumber[i]}, {secondNumber[i]}, ");
                    sr.Write($"{firstNumber[i]}+{secondNumber[i]}={Calculation.GetSum(firstNumber[i], secondNumber[i])}, ");
                    sr.Write($"{firstNumber[i]}*{secondNumber[i]}={Calculation.GetMultiply(firstNumber[i], secondNumber[i])}, ");

                    try
                    {
                        sr.Write($"{firstNumber[i]}/{secondNumber[i]}={Calculation.GetDivide(firstNumber[i], secondNumber[i])}");
                    }
                    catch (DivideByZeroException ex)
                    {
                        sr.Write($"{firstNumber[i]}/{secondNumber[i]}={ex.Message}");
                    }
                    finally
                    {
                        sr.WriteLine();
                    }
                }
            }
        }

        public void ReadFile()
        {
            using (StreamReader reader = new StreamReader(textFile))
            {
                while (!reader.EndOfStream)
                {
                    string[] splits = reader.ReadLine().Split(separator);
                    firstNumber.Add(Convert.ToInt32(splits[0]));
                    secondNumber.Add(Convert.ToInt32(splits[1]));
                }
            }
        }

    }
}
