using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;
using System.Threading;

namespace Projet_progsys
{
    class Data
    {

        //method copying the file
        public void Copy(string src, string dest, string name)
        {
            int i = 0;
            try
            {
                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(""+src ,"*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(src,dest));
                }
                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(src, "*.*", SearchOption.AllDirectories))
                {
                    i++;
                    File.Copy(newPath, newPath.Replace(src, dest), true);
                    Logs log1 = new Logs();
                    _File file1 = new _File();

                    //daily log handling
                    string filenamesource = file1.GetFilenamesrc(newPath);

                    string filenametarget = file1.GetFilenamedest(newPath.Replace(src, dest));

                    long fSize = file1.Getsize(newPath);

                    string transferttime = file1.GetTranfertTime();

                    string time = file1.Gettime();

                    log1.LogD(name,filenamesource,filenametarget, fSize, transferttime, time);

                    //In real time log handling
                    //depending on the save work use a one of the loop
                    string path = newPath;
                    if (name is "Save 1")
                    {
                        filenamesource = file1.GetFilenamesrc(newPath);
                        filenametarget = file1.GetFilenamedest(newPath.Replace(src, dest));
                        double sizedir = file1.Getdirsize(src);
                        int fCount = file1.Getfilesnumber(src);
                        int Lfile = file1.Remainingfiles(fCount, i);
                        double progression = file1.Progression(fCount, i);
                        string state = "ACTIVE";
                        log1.SetLog(name, filenamesource, filenametarget, state, sizedir, fCount, Lfile, progression);
                        

                        string log = log1.UpdateLogI(name, filenamesource, filenametarget, state, sizedir, fCount, Lfile, progression, path);
                        log = log1.UpdateLogIEnd(log, name, path);
                    }
                    else if (name is "Save 2")
                    {
                        filenamesource = file1.GetFilenamesrc(newPath);
                        filenametarget = file1.GetFilenamedest(newPath.Replace(src, dest));
                        double sizedir = file1.Getdirsize(src);
                        int fCount = file1.Getfilesnumber(src);
                        int Lfile = file1.Remainingfiles(fCount, i);
                        double progression = file1.Progression(fCount, i);
                        string state = "ACTIVE";
                        log1.SetLog(name, filenamesource, filenametarget, state, sizedir, fCount, Lfile, progression);


                        string log = log1.UpdateLogI(name, filenamesource, filenametarget, state, sizedir, fCount, Lfile, progression, path);
                        log = log1.UpdateLogIEnd(log, name, path);
                    }
                    else if (name is "Save 3")
                    {
                        filenamesource = file1.GetFilenamesrc(newPath);
                        filenametarget = file1.GetFilenamedest(newPath.Replace(src, dest));
                        double sizedir = file1.Getdirsize(src);
                        int fCount = file1.Getfilesnumber(src);
                        int Lfile = file1.Remainingfiles(fCount, i);
                        double progression = file1.Progression(fCount, i);
                        string state = "ACTIVE";
                        log1.SetLog(name, filenamesource, filenametarget, state, sizedir, fCount, Lfile, progression);


                        string log = log1.UpdateLogI(name, filenamesource, filenametarget, state, sizedir, fCount, Lfile, progression, path);
                        log = log1.UpdateLogIEnd(log, name, path);
                    }
                    else if (name is "Save 4")
                    {
                        filenamesource = file1.GetFilenamesrc(newPath);
                        filenametarget = file1.GetFilenamedest(newPath.Replace(src, dest));
                        double sizedir = file1.Getdirsize(src);
                        int fCount = file1.Getfilesnumber(src);
                        int Lfile = file1.Remainingfiles(fCount, i);
                        double progression = file1.Progression(fCount, i);
                        string state = "ACTIVE";
                        log1.SetLog(name, filenamesource, filenametarget, state, sizedir, fCount, Lfile, progression);


                        string log = log1.UpdateLogI(name, filenamesource, filenametarget, state, sizedir, fCount, Lfile, progression, path);
                        log = log1.UpdateLogIEnd(log, name, path);
                    }
                    else if (name is "Save 5")
                    {
                        filenamesource = file1.GetFilenamesrc(newPath);
                        filenametarget = file1.GetFilenamedest(newPath.Replace(src, dest));
                        double sizedir = file1.Getdirsize(src);
                        int fCount = file1.Getfilesnumber(src);
                        int Lfile = file1.Remainingfiles(fCount, i);
                        double progression = file1.Progression(fCount, i);
                        string state = "ACTIVE";
                        log1.SetLog(name, filenamesource, filenametarget, state, sizedir, fCount, Lfile, progression);


                        string log = log1.UpdateLogI(name, filenamesource, filenametarget, state, sizedir, fCount, Lfile, progression, path);
                        log = log1.UpdateLogIEnd(log, name, path);
                    }


                }
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }
        }
    }
}
