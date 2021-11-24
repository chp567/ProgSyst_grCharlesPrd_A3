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
                    File.Copy(newPath, newPath.Replace(src, dest), true);
                    Logs log1 = new Logs();
                    _File file1 = new _File();

                    string filenamesource = file1.GetFilenamesrc(newPath);

                    string filenametarget = file1.GetFilenamedest(newPath.Replace(src, dest));

                    long fi = file1.Getsize(newPath);

                    string transferttime = file1.GetTranfertTime();

                    string time = file1.Gettime();

                    log1.LogD(name,filenamesource,filenametarget, fi, transferttime, time);

                    //log1.LogI();
                }
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }
        }
    }
}
