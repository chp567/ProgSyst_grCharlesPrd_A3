using System;
using System.IO;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void fre()
        {
            string source = @"C://Users//cperr//Downloads//source";
            string target = @"C://Users//cperr//Downloads//target";


            if (Directory.Exists(source) & Directory.Exists(target))
            {
                Console.WriteLine("oui, la source et la destination existe bien");

                //avoir le nom de la source (afficher avec filename)
                string filenamesource = null;
                filenamesource = Path.GetDirectoryName(source);
                Console.WriteLine("Source = " + filenamesource);

                //avoir le nom de la target (afficher avec filename)
                string filenametarget = null;
                filenametarget = Path.GetDirectoryName(target);
                Console.WriteLine("target = " + filenametarget);

                //calculer la taille de la source
                DirectoryInfo dInfo = new DirectoryInfo(source);
                long sizeOfDir = DirectorySize(dInfo, true);
                Console.WriteLine("Directory size in Bytes : " +
                "{0:N0} Bytes", sizeOfDir);
                Console.WriteLine("Directory size in KB : " +
                "{0:N2} KB", ((double)sizeOfDir) / 1024);
                Console.WriteLine("Directory size in MB : " +
                "{0:N2} MB", ((double)sizeOfDir) / (1024 * 1024));
                Console.WriteLine("Tap enter to continue");
                Console.ReadLine();


                //dstpath (afficher les directory et sous file de la target)
                string[] files = Directory.GetFiles(target);
                foreach (string file in files)
                    Console.WriteLine(file);
                Console.WriteLine("sauvegarde effectué avec succès");

            }
            else
            {
                Console.WriteLine("non, la source ou la destination est mauvaise -> arrêt des travaux");
            }
        }

        static long DirectorySize(DirectoryInfo dInfo, bool includeSubDir)
        {
            //calculer la taille de la source
            long totalSize = dInfo.EnumerateFiles()
                         .Sum(file => file.Length);
            if (includeSubDir)
            {
                totalSize += dInfo.EnumerateDirectories()
                         .Sum(dir => DirectorySize(dir, true));
            }
            return totalSize;
        }
    }

}
