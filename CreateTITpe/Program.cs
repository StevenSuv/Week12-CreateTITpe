using System;
using System.IO;

namespace CreateTITpe
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\samples";
            string userDirectory = "titpe21";
            string fullDirectoryPath = $@"{rootDirectory}\{userDirectory}";

            bool directoryExists = Directory.Exists(fullDirectoryPath);

            if (directoryExists)
            {
                Console.WriteLine($"{userDirectory} already exists in {rootDirectory}.");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"{userDirectory} does not exist in {rootDirectory}.");
                Directory.CreateDirectory(fullDirectoryPath);
                Console.WriteLine($"{userDirectory} has been created in {rootDirectory}.");

            }
            else
            {
                Directory.CreateDirectory(fullDirectoryPath);
                Console.WriteLine($"{userDirectory} has been created in {rootDirectory}.");
            }
        }
    }
}
