using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using RunQickViewNewspaper.Properties;

namespace RunQickViewNewspaper
{
    public partial class RunForm : Form
    {
        static string databaseFile = "QVN.s3db";
        static string SQLiteLibaryFile = "System.Data.SQLite.dll";
        static string mainFile = "Quick View Newspaper.exe";
        private static string configFile = "QVN_Config.ini";

        private int tmr = 0;

        public RunForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void start()
        {
            string folder = "Quick View Newspaper\\";
            string tempPath = Path.GetTempPath();
            string path = tempPath + folder;

            //Nếu đường dẫn này chưa tồn tại
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa phiên làm việc cũ hay không?", "Test xác nhận", MessageBoxButtons.YesNo);
            //Xóa cũ đè mới
            //if (dialogResult == DialogResult.Yes)
            //{
                File.WriteAllBytes(path + databaseFile, Resources.QVN);
                File.WriteAllBytes(path + SQLiteLibaryFile, Resources.System_Data_SQLite);
                File.WriteAllBytes(path + mainFile, Resources.Quick_View_Newspaper);
                File.WriteAllText(path + configFile, Resources.QVN_Config);
            //}
            //else if (dialogResult == DialogResult.No)
            //{
            //}

            //if (!File.Exists(path + databaseFile))
            //{
            //    File.WriteAllBytes(path + databaseFile, Resources.QVN);
            //}
            //if (!File.Exists(path + SQLiteLibaryFile))
            //{
            //    File.WriteAllBytes(path + SQLiteLibaryFile, Resources.System_Data_SQLite);
            //}
            //if (!File.Exists(path + mainFile))
            //{
            //    File.WriteAllBytes(path + mainFile, Resources.Quick_View_Newspaper);
            //}
            //if (!File.Exists(path + configFile))
            //{
            //    File.WriteAllText(path + configFile, Resources.QVN_Config);
            //}
            Process.Start(new ProcessStartInfo(path + mainFile, "\"" + path));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tmr++;
            if(tmr==2)
            {
                timer1.Stop();
                start();
                this.Close();
            }
        }
    }
}
