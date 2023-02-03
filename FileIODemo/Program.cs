using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\shivp\source\repos\FileIODemo\FileIODemo\FileIOOperation\Sample.txt";
            Console.WriteLine("\n1.File Exists\n2.Read All Lines one by one\n3.Read All lines at once\n4.Copy Existing File\n5.Delete Existing File");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option) 
            {
                case 1:
                    FileExists(path);
                    break;

                case 2:
                    ReadAllLinesOneByOne(path);
                    break;

                case 3:
                    ReadAllLinesAtOnce(path);
                    break;

                case 4:
                    CopyAnExistingFile(path); 
                    break;

                case 5:
                    DeleteAnExistingFile(path);
                    break;

                default: 
                    Console.WriteLine("\n Choose From Given Options Only...");
                    break;
            }
            Console.ReadLine();
        }

        public static bool FileExists(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("\nGiven File Exists");
                return true;
            }
            else
            {
                Console.WriteLine("\nGiven File not Exists");
                return false;
            }
        }
        //The lines are read line by line
        public static void ReadAllLinesOneByOne(string path)
        {
            if (FileExists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }           
        }
        public static void ReadAllLinesAtOnce(string path)
        {
            if (FileExists(path))
            {
                string line = File.ReadAllText(path);
                Console.WriteLine(line);
            }
        }
        public static void CopyAnExistingFile(string path)
        {
            string destination = @"C:\Users\shivp\source\repos\FileIODemo\FileIODemo\FileIOOperation\Destination.txt";
            if (FileExists(path))
            {
                File.Copy(path,destination);
                
            }
        }
        public static void DeleteAnExistingFile(string path)
        {
            string destination = @"C:\Users\shivp\source\repos\FileIODemo\FileIODemo\FileIOOperation\Destination.txt";
            if (FileExists(path))
            {
                File.Delete( destination);

            }
        }
    }
}
