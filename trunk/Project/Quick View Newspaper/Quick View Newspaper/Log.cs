using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Quick_View_Newspaper
{
    public class Log
    {
        private static string pathFileLog = "QVNLog.txt";

        public static void WriteLog(string content)
        {
            string prefix = DateTime.Now.ToString();
            StreamWriter streamWriter = File.AppendText(pathFileLog);
            streamWriter.WriteLine(prefix + ": " + content);
            streamWriter.Close();
        }
    }
}
