using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Globalization;
using System.Linq;

namespace Projet_progsys
{
    class _File
    {
        public string GetFilenamesrc(string newPath)
        {
            //get the file source
            string filenamesource = null;
            filenamesource = Path.GetDirectoryName(newPath);
            return filenamesource;
        }

        public string GetFilenamedest(string newPath)
        {
            //get the file target 
            string filenametarget = null;
            filenametarget = Path.GetDirectoryName(newPath);
            return filenametarget;

        }

        public long Getsize(string newPath)
        {
            //find size of the file
            FileInfo fi = new FileInfo(newPath);
            return fi.Length;
        }

        public string GetTranfertTime()
        {
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now;

            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = (end - start);

            // Format and display the TimeSpan value.
            double time = ts.TotalMilliseconds;
            String times = time.ToString();
            times = times.Replace(',', '.');
            return times;
        }

        public string Gettime() //get the time when the copy is done 
        {
            DateTime localDate = DateTime.Now;
            String culture = "fr-FR";
            var place = new CultureInfo(culture);
            string time = localDate.ToString();

            return time;
        }

        static long DirectorySize(DirectoryInfo dInfo, bool includeSubDir)
        {
            //find directory
            long totalSize = dInfo.EnumerateFiles()
                         .Sum(file => file.Length);
            if (includeSubDir)
            {
                totalSize += dInfo.EnumerateDirectories()
                         .Sum(dir => DirectorySize(dir, true));
            }
            return totalSize;
        }

        public long Getdirsize(string src)
        {
            //gets the directory size
            DirectoryInfo dInfo = new DirectoryInfo(src);
            long sizeOfDir = DirectorySize(dInfo, true);
            return sizeOfDir;
        }

        public int Getfilesnumber(string src)
        {
            //gets the file number
            int fCount = Directory.GetFiles(src, "*.*", SearchOption.AllDirectories).Length;
            return fCount;
        }

        public int Remainingfiles(int fCount, int i)
        {
            //gets remaining files
            int filesleft;
            filesleft = fCount - i;

            return filesleft;
        }

        public double Progression(int fCount, int i)
        {
            //gets progression in %
            double progression;
            progression = ((double)i / (double)fCount) * 100;
            return progression;
        }
    }
}
