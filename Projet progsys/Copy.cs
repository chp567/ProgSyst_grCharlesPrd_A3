using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Projet_progsys
{
    class Data
    {
        //method copying the file
        public void Copy(string src, string dest)
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
                }
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }
        }
    }
}
