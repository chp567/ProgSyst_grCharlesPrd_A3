using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Net.Sockets;
using WpfAppProjet.ViewModel;

namespace Projet_progsys
{
    class Data
    {

        List<string> logs = new List<string>();
        Server s1 = new Server();
        Socket ClientCon;

        //method copying the file
        public void Copy(string src, string dest, string name, bool Checked, List<string> extensions, List<string> destination, bool server_started)
        {
            int i = 0;
            try
            {
                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(src ,"*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(src,dest));
                    
                }
                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(src, "*.*", SearchOption.AllDirectories))
                {
                    FileInfo size = new FileInfo(newPath);
                    i++;
                    if (size.Length < 1000000000)
                    {
                        File.Copy(newPath, newPath.Replace(src, dest), true);
                        Logs log1 = new Logs();
                        _File file1 = new _File();

                        //daily log handling
                        string filenamesource = newPath;

                        string filenametarget = newPath.Replace(src, dest);

                        long fSize = file1.Getsize(newPath);

                        string transferttime = file1.GetTranfertTime();

                        string time = file1.Gettime();

                        log1.LogD(name, filenamesource, filenametarget, fSize, transferttime, time, Checked, extensions, destination);

                        //In real time log handling
                        //depending on the save work use a one of the loop
                        string path = newPath;

                        filenamesource = file1.GetFilenamesrc(newPath);
                        filenametarget = file1.GetFilenamedest(newPath.Replace(src, dest));
                        double sizedir = file1.Getdirsize(src);
                        int fCount = file1.Getfilesnumber(src);
                        int Lfile = file1.Remainingfiles(fCount, i);
                        double progression = file1.Progression(fCount, i);
                        string state = "ACTIVE";
                        log1.SetLog(name, filenamesource, filenametarget, state, sizedir, fCount, Lfile, progression);


                        string log = log1.UpdateLogI(name, filenamesource, filenametarget, state, sizedir, fCount, Lfile, progression, path);
                        logs.Add(log);
                        log = log1.UpdateLogIEnd(log, name, path);


                    }
                    else
                    {
                        MessageBox.Show(size.Name + "> 1Go");
                    }
                }
                if (server_started is true)
                {
                    Socket ServerCon = s1.ServerConnect();

                    ClientCon = s1.ClientConnect(ServerCon);

                    s1.NetworkListener(ClientCon, logs);


                    s1.Disconnecting(ServerCon);
                }
                else
                {

                }

            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }
        }
    }
}
