using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using WpfAppProjet;
using Newtonsoft.Json;


namespace Projet_progsys
{
    class Logs
    {
        private string log;
        private string log1;
        public void LogD(string name, string filenamesource, string filenametarget, long fSize, string transferttime, string time) //daily log
        {
            string log;
            //creation of the variable logs containing the log details
            log = $"{Environment.NewLine}"
                +"{"
                + $"{Environment.NewLine} " +(char)34+ " Name " + (char)34 + ": " + (char)34 + name + (char)34 
                + ","
                + $"{Environment.NewLine} " + (char)34 + "FileSource" + (char)34 + ": " + (char)34 + filenamesource + (char)34 
                + ","
                + $"{Environment.NewLine} " + (char)34 + "FileTarget" + (char)34 + ": " + (char)34 + filenametarget + (char)34 
                + ","
                + $"{Environment.NewLine} " + (char)34 + "destPath" + (char)34 + ": '' "
                + ","
                + $"{Environment.NewLine} " + (char)34 + "FileSize" + (char)34 + ": " + fSize  
               + ","
                + $"{Environment.NewLine} " + (char)34 + "FileTransferTime" + (char)34 + ": " + transferttime
                + ","
                + $"{Environment.NewLine} " + (char)34 + "time" + (char)34 + ": " + (char)34 + time + (char)34
               + ","
                + $"{Environment.NewLine}"
                + "},";
            //calling the file function to write in the log file
            var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            string projectDirectory = currentDirectory.Parent.Parent.Parent.FullName;

            File.AppendAllText(projectDirectory+@"\temp\log.json", log); 
        }

        public void CreateLogI(string path) //In real time log
        {
            string log;
            //creation of the variable logs containing the log details
            string name = "";
            log = "";
            for (int i = 1; i < 6; i++)
            {
                name = "Save " + i;
                log += $"{Environment.NewLine}"
                    + "{"
                    + $"{Environment.NewLine} " + (char)34 + "Name" + (char)34 + ": " + (char)34 + name + (char)34
                    + ","
                    + $"{Environment.NewLine} " + (char)34 + "FileSource" + (char)34 + ": "
                    + ","
                    + $"{Environment.NewLine} " + (char)34 + "FileTarget" + (char)34 + ": "
                    + ","
                    + $"{Environment.NewLine} " + (char)34 + "State" + (char)34 + ": " + (char)34 + "END" + (char)34
                    + ","
                    + $"{Environment.NewLine} " + (char)34 + "TotalFilesToCopy" + (char)34 + ": "
                    + ","
                    + $"{Environment.NewLine} " + (char)34 + "TotalFilesSize" + (char)34 + ": "
                    + ","
                    + $"{Environment.NewLine} " + (char)34 + "NbFilesLeftToDo" + (char)34 + ": "
                    + $","
                    + $"{Environment.NewLine} " + (char)34 + "Progression" + (char)34 + ": "
                    + $","
                    + $"{Environment.NewLine}"
                    + "},";
            }

            //calling the file function to write in the log file
            File.AppendAllText(path, log);

        }

        public string SetLog1(string name)
        {
            string logpattern = $"{ Environment.NewLine}"
            + "{"
            + $"{Environment.NewLine} " + (char)34 + "Name" + (char)34 + ": " + (char)34 + name + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "FileSource" + (char)34 + ": " + (char)34 + "" + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "FileTarget" + (char)34 + ": " + (char)34 + "" + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "State" + (char)34 + ": " + (char)34 + "END" + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "TotalFilesToCopy" + (char)34 + ": "
            + ","
            + $"{Environment.NewLine} " + (char)34 + "TotalFilesSize" + (char)34 + ": "
            + ","
            + $"{Environment.NewLine} " + (char)34 + "NbFilesLeftToDo" + (char)34 + ": "
            + $","
            + $"{Environment.NewLine} " + (char)34 + "Progression" + (char)34 + ": "
            + $","
            + $"{Environment.NewLine}"
            + "},";

            this.log1 = logpattern;
            return this.log1;
        }

        public string SetLog(string name, string filenamesource, string filenametarget, string state, double sizedir, int filecount, int Lfile, double progression)
        {
            string logpattern = $"{ Environment.NewLine}"
            + "{"
            + $"{Environment.NewLine} " + (char)34 + "Name" + (char)34 + ": " + (char)34 + name + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "FileSource" + (char)34 + ": " + (char)34 + "" + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "FileTarget" + (char)34 + ": " + (char)34 + "" + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "State" + (char)34 + ": " + (char)34 + "END" + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "TotalFilesToCopy" + (char)34 + ": "
            + ","
            + $"{Environment.NewLine} " + (char)34 + "TotalFilesSize" + (char)34 + ": "
            + ","
            + $"{Environment.NewLine} " + (char)34 + "NbFilesLeftToDo" + (char)34 + ": "
            + $","
            + $"{Environment.NewLine} " + (char)34 + "Progression" + (char)34 + ": "
            + $","
            + $"{Environment.NewLine}"
            + "},";

            this.log = logpattern;
            return this.log;
        }

        public string Getlog()
        {
            return this.log1;
        }

        public string SetLogI(string name, string filenamesource, string filenametarget, string state, double sizedir, int filecount, int Lfile, double progression, string path)
        {
            string log = $"{ Environment.NewLine}"
            + "{"
            + $"{Environment.NewLine} " + (char)34 + "Name" + (char)34 + ": " + (char)34 + name + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "FileSource" + (char)34 + ": " + (char)34 + filenamesource + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "FileTarget" + (char)34 + ": " + (char)34 + filenametarget + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "State" + (char)34 + ": " + (char)34 + state + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "TotalFilesToCopy" + (char)34 + ": " + filecount
            + ","
            + $"{Environment.NewLine} " + (char)34 + "TotalFilesSize" + (char)34 + ": " + sizedir
            + ","
            + $"{Environment.NewLine} " + (char)34 + "NbFilesLeftToDo" + (char)34 + ": " + Lfile
            + $","
            + $"{Environment.NewLine} " + (char)34 + "Progression" + (char)34 + ": " + progression + " %"
            + $","
            + $"{Environment.NewLine}"
            + "},";

            this.log = log;
            return this.log;
        }

        public string GetLogI()
        {
            return this.log;
        }

            public string UpdateLogI(string name, string filenamesource, string filenametarget, string state, double sizedir, int filecount, int Lfile, double progression, string path)
        {
            string log = $"{ Environment.NewLine}"
            + "{"
            + $"{Environment.NewLine} " + (char)34 + "Name" + (char)34 + ": " + (char)34 + name + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "FileSource" + (char)34 + ": " + (char)34 + filenamesource + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "FileTarget" + (char)34 + ": " + (char)34 + filenametarget + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "State" + (char)34 + ": " + (char)34 + state + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "TotalFilesToCopy" + (char)34 + ": " + filecount
            + ","
            + $"{Environment.NewLine} " + (char)34 + "TotalFilesSize" + (char)34 + ": " + sizedir
            + ","
            + $"{Environment.NewLine} " + (char)34 + "NbFilesLeftToDo" + (char)34 + ": " + Lfile
            + $","
            + $"{Environment.NewLine} " + (char)34 + "Progression" + (char)34 + ": " + progression + " %" 
            + $","
            + $"{Environment.NewLine}"
            + "},";

            //Console.WriteLine(log);
            MessageBox.Show(log);
            string text = File.ReadAllText(path);
            string log1 = GetLogI();
            text = text.Replace( log1, log);
            File.WriteAllText(path, text);

            return log;
        }

        public string UpdateLogIEnd(string log , string name, string path)
        {
            string log1 = $"{ Environment.NewLine}"
            + "{"
            + $"{Environment.NewLine} " + (char)34 + "Name" + (char)34 + ": " + (char)34 + name + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "FileSource" + (char)34 + ": " + (char)34 + "" + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "FileTarget" + (char)34 + ": " + (char)34 + "" + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "State" + (char)34 + ": " + (char)34 + "END" + (char)34
            + ","
            + $"{Environment.NewLine} " + (char)34 + "TotalFilesToCopy" + (char)34 + ": "
            + ","
            + $"{Environment.NewLine} " + (char)34 + "TotalFilesSize" + (char)34 + ": "
            + ","
            + $"{Environment.NewLine} " + (char)34 + "NbFilesLeftToDo" + (char)34 + ": "
            + $","
            + $"{Environment.NewLine} " + (char)34 + "Progression" + (char)34 + ": "
            + $","
            + $"{Environment.NewLine}"
            + "},";

            //Console.WriteLine(log1);
            string text = File.ReadAllText(path);
            log = GetLogI();
            text = text.Replace(log, log1);
            File.WriteAllText(path, text);

            return log;
        }
        }
    }

