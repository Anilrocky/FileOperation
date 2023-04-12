﻿using System;
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
                Console.WriteLine("\nChoose option to perform \n1.Check File exists \n2.Read all lines \n3.Read all text \n4.Copy text to new file \n5.Delete new file \n6.File stream reader \n7.File stream writer \n8.Exit");
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
                        operation.FileReadAllText(@"D:\BridgeLabz\FileOperation\FileOperation\File.txt");
                        break;
                    case 4:
                        operation.FileCopy(@"D:\BridgeLabz\FileOperation\FileOperation\File.txt", @"D:\BridgeLabz\FileOperation\FileOperation\Demo.txt");
                        break;
                    case 5:
                        operation.FileDelete(@"D:\BridgeLabz\FileOperation\FileOperation\Demo.txt");
                        break;
                    case 6:
                        operation.FileStreamReader(@"D:\BridgeLabz\FileOperation\FileOperation\File.txt");
                        break;
                    case 7:
                        operation.FileStreamWriter(@"D:\BridgeLabz\FileOperation\FileOperation\File.txt");
                        break;
                    case 8:
                        flag = false;
                        break;
                }
            }
        }
    }
}
