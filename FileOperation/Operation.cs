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
    }
}
