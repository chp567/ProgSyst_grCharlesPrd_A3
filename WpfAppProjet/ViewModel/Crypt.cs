using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfAppProjet;

namespace WpfAppProjet.Model
{
    class Crypt
    {
        public string type;

        public void Encrypt(string path, List<string> extensions)
        {
            var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            string projectDirectory = currentDirectory.Parent.Parent.Parent.Parent.FullName;
            using (StreamReader r = new StreamReader(projectDirectory + @"\Cryptosoft\Cryptosoft\bin\Debug\netcoreapp3.1\Cryptosoft.exe"))
            {
                foreach (string extension in extensions)
                {
                    foreach (string newPath in Directory.GetFiles(path, $"*{extension}", SearchOption.AllDirectories))
                    {

                        type = "cesar";

                        ProcessStartInfo cryptosoft = new ProcessStartInfo();
                        cryptosoft.FileName = projectDirectory + @"\Cryptosoft\Cryptosoft\bin\Debug\netcoreapp3.1\Cryptosoft.exe";
                        cryptosoft.Arguments = "\"" + $"{newPath}" + "\"" + $" {type}";
                        Process.Start(cryptosoft);
                    }
                }
            }
        }

        /*public void Decrypt(string path)
        {
            type = "uncesar";

            ProcessStartInfo cryptosoft = new ProcessStartInfo();
            cryptosoft.FileName = @"C:\Users\Hanton\Documents\GitHub\Projet_Web\ProgSyst_grCharlesPrd_A3\Cryptosoft\Cryptosoft\bin\Debug\netcoreapp3.1\Cryptosoft.exe";
            cryptosoft.Arguments = "\"" + $"{path}" + "\"" + $" {type}";
            Process.Start(cryptosoft);
        }*/
    }
}
