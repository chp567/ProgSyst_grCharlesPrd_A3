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
        public string type; //variable type only used for crypting

        public void Encrypt(List<string> extensions, string destination) //encrypts the data
        {
            List<string> Encrypted = new List<string>();
            bool flag = true;
            var currentDirectory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            string projectDirectory = currentDirectory.Parent.Parent.Parent.Parent.FullName;
            using (StreamReader r = new StreamReader(projectDirectory + @"\Cryptosoft\Cryptosoft\bin\Debug\netcoreapp3.1\Cryptosoft.exe"))
            {
                foreach (string extension in extensions)
                {


                        foreach (string newPath in Directory.GetFiles(destination, $"*{extension}", SearchOption.AllDirectories))
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

        public string GetFileEncryptionTime() //get file encryption time
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
    }
}
