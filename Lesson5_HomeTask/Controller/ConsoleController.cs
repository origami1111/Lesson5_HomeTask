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
            Console.WriteLine($"1 - {FileExtensions.txtExtension}");
            Console.WriteLine($"2 - {FileExtensions.csvExtension}");
            Console.Write("> ");

            string choise = Console.ReadLine();

            if (choise == "1")
            {
                fileExtension = FileExtensions.txtExtension;
                separator = Separators.whiteSpaceSep;
            }
            else if (choise == "2")
            {
                fileExtension = FileExtensions.csvExtension;
                separator = Separators.commaSep;
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
