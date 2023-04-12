using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation
{
    public class Operation
    {
        public void FileExists(string filePath)
        {
            if (File.Exists(filePath))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File not exists");
        }
        public void FileReadAllLines(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var data in lines)
                {
                    Console.WriteLine(data);
                }
            }
            else
            {
                Console.WriteLine("File not exists");
            }
        }
        public void FileReadAllText(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine(lines);
                foreach (var data in lines)
                {
                    Console.WriteLine(data);
                }
            }
            else
            {
                Console.WriteLine("File not exists");
            }
        }
        public void FileCopy(string filePath, string newFile)
        {
            if (File.Exists(filePath))
                File.Copy(filePath, newFile);
            else
                Console.WriteLine("File not exists");
        }
        public void FileDelete(string newFile)
        {
            if (File.Exists(newFile))
                File.Delete(newFile);
            else
                Console.WriteLine("File not exists");
        }
        public void FileStreamReader(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    while (sr.ReadLine() != null)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            else
            {
                Console.WriteLine("File not exists");
            }
        }
    }
}
