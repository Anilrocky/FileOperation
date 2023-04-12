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
                Console.WriteLine("\nChoose option to perform \n1.Check File exists \n2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        operation.FileExists(@"D:\BridgeLabz\FileOperation\FileOperation\File.txt");
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
