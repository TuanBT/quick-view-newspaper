using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Quick_View_Newspaper
{
    public class Log
    {
        private static string pathFileLog = Application.StartupPath + "\\QVNLog.txt";
        

        public static void WriteLog(string content)
        {
            string prefix = DateTime.Now.ToString();
            StreamWriter streamWriter = File.AppendText(pathFileLog);
            streamWriter.WriteLine(prefix + ": " + content);
            streamWriter.Close();
        }
    }
}
