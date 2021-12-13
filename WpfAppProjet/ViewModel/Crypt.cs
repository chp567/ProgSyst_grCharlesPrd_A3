using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppProjet.Model
{
    class Crypt
    {
        public string type;

        public void Encrypt(string path)
        {
            foreach (string newPath in Directory.GetFiles(path, $"*.txt", SearchOption.AllDirectories))
            {
                type = "cesar";

                ProcessStartInfo cryptosoft = new ProcessStartInfo();
                cryptosoft.FileName = @"C:\Users\Hanton\Documents\GitHub\Projet_Web\ProgSyst_grCharlesPrd_A3\Cryptosoft\Cryptosoft\bin\Debug\netcoreapp3.1\Cryptosoft.exe";
                cryptosoft.Arguments = "\"" + $"{newPath}" + "\"" + $" {type}";
                Process.Start(cryptosoft);
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
