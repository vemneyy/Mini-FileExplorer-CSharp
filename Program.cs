using System;
using System.Collections.Generic;
using System.IO;


namespace console_lab_1_yureva
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("Название: {0}", drive.Name);

                if (drive.IsReady)
                {
                    Console.WriteLine("Объем диска: {0}", drive.TotalSize);
                    Console.WriteLine("Свободное пространство: {0}", drive.TotalFreeSpace);

                }
                Console.WriteLine();
            }

            string dirName = "C:\\";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }

            Console.WriteLine();

            string dirName_program = "C:\\Program Files";
            DirectoryInfo dirInfo = new DirectoryInfo(dirName_program);
            Console.WriteLine("Название каталога: {0}", dirInfo.Name);
            Console.WriteLine("Полное название каталога: {0}", dirInfo.FullName);
            Console.WriteLine("Время создания каталога: {0}", dirInfo.CreationTime);
            Console.WriteLine("Корневой каталог: {0}", dirInfo.Root);

            Console.WriteLine();

            string path = "C:\\Users\\sonoma\\Desktop\\dsadsa.docx";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.WriteLine("Имя файла: {0}", fileInf.Name);
                Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                Console.WriteLine("Размер: {0}", fileInf.Length);
            }

        }
    }

}
