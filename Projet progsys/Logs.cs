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
            string InputDest = "";
            string Save = "";
            string WorkChoice = "";

                if (language == 1)      //FR
                {
                InputSrc = "Insérez le dossier source";
                InputDest = "Insérez le dossier de sauvegarde";
                Save = "Choisissez le mode sauvegarde " +
                    $"{Environment.NewLine}1 = Sauvegarde seule" +
                    $"{Environment.NewLine}2 = Sauvegarde séquentielle";
                WorkChoice = "Choissez le travail à effectuer";
                }
                else if(language == 2)  //Eng
                {
                InputSrc = "Insert the source directory";
                InputDest = "Insert the destination directory";
                Save = "Choose the save mode " +
                    $"{Environment.NewLine}1 = Unique save" +
                    $"{Environment.NewLine}2 = Sequential save";
                WorkChoice = "Choose the save work you want to do";
            }

            //Interface int1 = new Interface();
            //instatiation of the 5 save works
            _Inputs inp1 = new _Inputs();
            _Inputs inp2 = new _Inputs();
            _Inputs inp3 = new _Inputs();
            _Inputs inp4 = new _Inputs();
            _Inputs inp5 = new _Inputs();

            // ask if you want to do one save or the 5 in a sequential way
            Console.WriteLine(Save);
            int SaveType = int.Parse(Console.ReadLine());
            Data copy1 = new Data();
            string src;
            string dest;

            //setting up the saves
            Console.WriteLine($"{Environment.NewLine}1");
            inp1.SetSource(InputSrc);
            inp1.Source();
            inp1.SetDestination(InputDest);
            inp1.Destination();

            Console.WriteLine("2");
            inp2.SetSource(InputSrc);
            inp2.Source();
            inp2.SetDestination(InputDest);
            inp2.Destination();

            Console.WriteLine("3");
            inp3.SetSource(InputSrc);
            inp3.Source();
            inp3.SetDestination(InputDest);
            inp3.Destination();

            Console.WriteLine("4");
            inp4.SetSource(InputSrc);
            inp4.Source();
            inp4.SetDestination(InputDest);
            inp4.Destination();

            Console.WriteLine("5");
            inp5.SetSource(InputSrc);
            inp5.Source();
            inp5.SetDestination(InputDest);
            inp5.Destination();

            if (SaveType == 1)
            {
                Console.WriteLine(WorkChoice);
                int work = int.Parse(Console.ReadLine());
                if (work == 1)
                {
                    src = inp1.GetSource();
                    dest = inp1.GetDest();
                    dest = @"" + dest;
                    copy1.Copy(src, dest);
                }
                else if (work == 2)
                {
                    src = inp2.GetSource();
                    dest = inp2.GetDest();
                    dest = @"" + dest;
                    copy1.Copy(src, dest);
                }
                else if (work == 3)
                {
                    src = inp3.GetSource();
                    dest = inp3.GetDest();
                    dest = @"" + dest;
                    copy1.Copy(src, dest);
                }
                else if (work == 4)
                {
                    src = inp4.GetSource();
                    dest = inp4.GetDest();
                    dest = @"" + dest;
                    copy1.Copy(src, dest);
                }
                else if (work == 5)
                {
                    src = inp5.GetSource();
                    dest = inp5.GetDest();
                    dest = @"" + dest;
                    copy1.Copy(src, dest);
                }
            }
            else if (SaveType == 2)
            {
                src = inp1.GetSource();
                dest = inp1.GetDest();
                dest = @"" + dest;
                copy1.Copy(src, dest);

                src = inp2.GetSource();
                dest = inp2.GetDest();
                dest = @"" + dest;
                copy1.Copy(src, dest);

                src = inp3.GetSource();
                dest = inp3.GetDest();
                dest = @"" + dest;
                copy1.Copy(src, dest);

                src = inp4.GetSource();
                dest = inp4.GetDest();
                dest = @"" + dest;
                copy1.Copy(src, dest);

                src = inp5.GetSource();
                dest = inp5.GetDest();
                dest = @"" + dest;               
                copy1.Copy(src, dest);
            }

            //Logs log1 = new Logs();
            //log1.LogD();
            //log1.LogI();
        }
    }

}
