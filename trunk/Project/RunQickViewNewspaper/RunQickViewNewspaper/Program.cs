using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using RunQickViewNewspaper.Properties;

namespace RunQickViewNewspaper
{
    class Program
    {
        static string databaseFile = "QVN.s3db";
        static string SQLiteLibaryFile = "System.Data.SQLite.dll";
        static string mainFile = "Quick View Newspaper.exe";


        static void Main(string[] args)
        {
            string folder = "Quick View Newspaper\\";

            //string tempPath = Path.GetTempPath();
            string tempPath = AppDomain.CurrentDomain.BaseDirectory;
            //string tempPath = "C:\\";
            //string tempPath = ProgramFilesx86();

            string path = tempPath + folder;

            //Nếu đường dẫn này chưa tồn tại
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(path + databaseFile))
            {
                File.WriteAllBytes(path + databaseFile, Resources.QVN);
            }
            if (!File.Exists(path + SQLiteLibaryFile))
            {
                File.WriteAllBytes(path + SQLiteLibaryFile, Resources.System_Data_SQLite);
            }
            if (!File.Exists(path + mainFile))
            {
                File.WriteAllBytes(path + mainFile, Resources.Quick_View_Newspaper);
            }

            //Process.Start(path + mainFile);
        }


        //Trả về vị trí của Programfile. Do phần mềm chạy x86 nên phải kiểm tra để phù hợp win 32 hoặc 64
        static string ProgramFilesx86()
        {
            if (8 == IntPtr.Size
                || (!String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))))
            {
                return Environment.GetEnvironmentVariable("ProgramFiles(x86)") + "\\";
            }

            return Environment.GetEnvironmentVariable("ProgramFiles") + "\\";
        }
    }
}
