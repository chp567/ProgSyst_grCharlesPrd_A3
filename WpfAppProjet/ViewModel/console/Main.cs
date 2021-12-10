using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Projet_progsys
{
    class _Main
    {
        /*static void Main()
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
                WorkChoice = "Choissez le travail à effectuer (1 à 5)";
            }
            else if (language == 2)  //Eng
            {
                InputSrc = "Insert the source directory";
                InputDest = "Insert the destination directory";
                Save = "Choose the save mode " +
                    $"{Environment.NewLine}1 = Unique save" +
                    $"{Environment.NewLine}2 = Sequential save";
                WorkChoice = "Choose the save work you want to do (1 to 5)";
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
            string name = "";

            //setting up the saves
            Console.WriteLine($"{Environment.NewLine}1");
            name = "Save 1";
            inp1.SetName(name);
            inp1.SetSource(InputSrc);
            inp1.Source();
            inp1.SetDestination(InputDest);
            inp1.Destination();

            inp2.SetName("Save 2");
            Console.WriteLine("2");
            name = "Save 2";
            inp2.SetName(name);
            inp2.SetSource(InputSrc);
            inp2.Source();
            inp2.SetDestination(InputDest);
            inp2.Destination();

            inp3.SetName("Save 3");
            Console.WriteLine("3");
            name = "Save 3";
            inp3.SetName(name);
            inp3.SetSource(InputSrc);
            inp3.Source();
            inp3.SetDestination(InputDest);
            inp3.Destination();

            inp4.SetName("Save 4");
            Console.WriteLine("4");
            name = "Save 4";
            inp4.SetName(name);
            inp4.SetSource(InputSrc);
            inp4.Source();
            inp4.SetDestination(InputDest);
            inp4.Destination();

            inp5.SetName("Save 5");
            Console.WriteLine("5");
            name = "Save 5";
            inp5.SetName(name);
            inp5.SetSource(InputSrc);
            inp5.Source();
            inp5.SetDestination(InputDest);
            inp5.Destination();

            // create the in real time log
            string path = "C:/Users/Hanton/Desktop/Tout/logIRT.json";
            Logs log = new Logs();

            if (File.Exists(path))
            {

            }
            else
            {
                log.CreateLogI(path);
            }

            if (SaveType == 1)
            {
                Console.WriteLine(WorkChoice);
                int work = int.Parse(Console.ReadLine());
                if (work == 1)
                {
                    src = inp1.GetSource();
                    dest = inp1.GetDest();
                    dest = @"" + dest;
                    name = inp1.GetName();
                    copy1.Copy(src, dest, name);
                }
                else if (work == 2)
                {
                    src = inp2.GetSource();
                    dest = inp2.GetDest();
                    dest = @"" + dest;
                    name = inp2.GetName();
                    copy1.Copy(src, dest, name);
                }
                else if (work == 3)
                {
                    src = inp3.GetSource();
                    dest = inp3.GetDest();
                    dest = @"" + dest;
                    name = inp3.GetName();
                    copy1.Copy(src, dest, name);
                }
                else if (work == 4)
                {
                    src = inp4.GetSource();
                    dest = inp4.GetDest();
                    dest = @"" + dest;
                    name = inp4.GetName();
                    copy1.Copy(src, dest, name);
                }
                else if (work == 5)
                {
                    src = inp5.GetSource();
                    dest = inp5.GetDest();
                    dest = @"" + dest;
                    name = inp1.GetName();
                    copy1.Copy(src, dest, name);
                }
            }
            else if (SaveType == 2)
            {
                src = inp1.GetSource();
                dest = inp1.GetDest();
                dest = @"" + dest;
                name = inp1.GetName();
                copy1.Copy(src, dest, name);

                src = inp2.GetSource();
                dest = inp2.GetDest();
                dest = @"" + dest;
                name = inp2.GetName();
                copy1.Copy(src, dest, name);

                src = inp3.GetSource();
                dest = inp3.GetDest();
                dest = @"" + dest;
                name = inp3.GetName();
                copy1.Copy(src, dest, name);

                src = inp4.GetSource();
                dest = inp4.GetDest();
                dest = @"" + dest;
                name = inp4.GetName();
                copy1.Copy(src, dest, name);

                src = inp5.GetSource();
                dest = inp5.GetDest();
                dest = @"" + dest;
                name = inp5.GetName();
                copy1.Copy(src, dest, name);
            }
        }*/
    }
}
