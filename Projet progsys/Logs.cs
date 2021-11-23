using System;
using System.IO;
using System.Threading.Tasks;


namespace Projet_progsys
{
    class Logs
    {
        void LogD() //daily log
        {
            string log;
            //creation of the variable logs containing the log details
            log = $"{Environment.NewLine}"
                +"{"
                + $"{Environment.NewLine} 'Name':"
                + ","
                + $"{Environment.NewLine} 'FileSource':"
                + ","
                + $"{Environment.NewLine} 'FileTarget':"
                + ","
                + $"{Environment.NewLine} 'destPath':"
                + ","
                + $"{Environment.NewLine} 'FileSize':"
                + ","
                + $"{Environment.NewLine} 'FileTransferTime':"
                + ","
                + $"{Environment.NewLine} 'time':"
                + $"{Environment.NewLine}"
                + "},";
            //calling the file function to write in the log file
            File.AppendAllText("C:/Users/Hanton/Desktop/Tout/log.json", log); 
        }

        void LogI() //In real time log
        {
            string log;
            //creation of the variable logs containing the log details
            log = $"{Environment.NewLine}"
                + "{"
                + $"{Environment.NewLine} 'Name':"
                + ","
                + $"{Environment.NewLine} 'FileSource':"
                + ","
                + $"{Environment.NewLine} 'FileTarget':"
                + ","
                + $"{Environment.NewLine} 'State':"
                + ","
                + $"{Environment.NewLine} 'TotalFilesToCopy':"
                + ","
                + $"{Environment.NewLine} 'TotalFilesSize':"
                + ","
                + $"{Environment.NewLine} 'NbFilesLeftToDo':" 
                + $"{Environment.NewLine} 'Progressiob': "
                + $"{Environment.NewLine}"
                + "},";
             //calling the file function to write in the log file
             File.AppendAllText("C:/Users/Hanton/Desktop/Tout/log.json", log);

        }

        static void Main()
        {
            _Language l1 = new _Language();
            l1.SetLanguage();
            int language = l1.GetLanguage();
            string InputSrc = "";
                if (language == 1)
                {
                InputSrc = "Insérez le dossier source";
                }
                else if(language == 2)
                {
                InputSrc = "Insert the source directory";
                }

            Interface int1 = new Interface();
            int1.SetSource(InputSrc);

            string src = "C:/Users/Hanton/Documents/GitHub/Projet_Web/ProgSyst_grCharlesPrd_A3/Projet progsys";
            string dest = "C:/Users/Hanton/Documents/GitHub/Projet_Web/ProgSyst_grCharlesPrd_A3/Projet progsys";
            dest = @"" + dest;
            //Console.WriteLine(dest);
            //Data copy1 = new Data();
            //copy1.Copy(src, dest);
            //Logs log1 = new Logs();
            //log1.LogD();
            //log1.LogI();
        }
    }

}
