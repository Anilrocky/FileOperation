using System;
namespace FileOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Check File exists \n2.Read all lines \n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        operation.FileExists(@"D:\BridgeLabz\FileOperation\FileOperation\File.txt");
                        break;
                    case 2:
                        operation.FileReadAllLines(@"D:\BridgeLabz\FileOperation\FileOperation\File.txt");
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
