using System;
using System.IO;

namespace MyFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\samples\MyFiles.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            for (int i = 0; i < dataFromFile.Length; i++)
            {
                dataFromFile[i] = dataFromFile[i].Replace('4', 'a');
                dataFromFile[i] = dataFromFile[i].Replace('3', 'e');
                dataFromFile[i] = dataFromFile[i].Replace('0', 'o');
                dataFromFile[i] = dataFromFile[i].Replace('1', 'i');
            }

            foreach (string line in dataFromFile)
            {
                Console.WriteLine(line);
            }
            for(int i = 0; i < dataFromFile.Length; i++)
            {
                File.Create($@"C:\Users\opilane\samples\titpe21\{dataFromFile[i]}.txt");
            }

            File.WriteAllLines(filePath, dataFromFile);
        }
    }
}
