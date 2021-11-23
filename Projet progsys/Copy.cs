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

                    //get the file source
                    string filenamesource = null;
                    filenamesource = Path.GetDirectoryName(src);

                    //get the file target 
                    string filenametarget = null;
                    filenametarget = Path.GetDirectoryName(dest);

                    //find size of the file
                    FileInfo fi = new FileInfo(newPath);
                    
                    log1.LogD(name,filenamesource,filenametarget, fi.Length);
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
