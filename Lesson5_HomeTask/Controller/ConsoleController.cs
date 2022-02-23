using System;

namespace Lesson5_HomeTask
{
    public class ConsoleController
    {
        private static string fileExtension;
        private static string separator;

        public static void Start()
        {
            ChooseInputFile();

            FileReaderWriter model = new FileReaderWriter(fileExtension, separator);
            model.ReadFile();
            model.WriteResults();
        }

        private static void ChooseInputFile()
        {
            Console.WriteLine("Select input file extension:");
            Console.WriteLine($"1 - {FileExtensions.TxtExtension}");
            Console.WriteLine($"2 - {FileExtensions.CsvExtension}");
            Console.Write("> ");

            string choise = Console.ReadLine();

            if (choise == "1")
            {
                fileExtension = FileExtensions.TxtExtension;
                separator = Separators.WhiteSpaceSep;
            }
            else if (choise == "2")
            {
                fileExtension = FileExtensions.CsvExtension;
                separator = Separators.CommaSep;
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
