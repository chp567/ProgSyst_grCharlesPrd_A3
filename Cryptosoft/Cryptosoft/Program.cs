using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Cryptosoft
{
    class Program
    {
        static public string Cesar(string mot, int decalage)
        {
            Func<int, int, int> mod = (val, m) => val % m + (val < 0 ? m : 0);

            Func<char, char, int, char> decal =
                (c, offset, m) => (char)(offset + mod(c - offset + decalage, m));

            Func<char, char> cesar =
             c => ('a' <= c && c <= 'z') ? decal(c, 'a', 26)
                : ('A' <= c && c <= 'Z') ? decal(c, 'A', 26)
                : ('0' <= c && c <= '9') ? decal(c, '0', 10)
                : c;

            return new string(mot.Select(cesar).ToArray());
        }
        static void Main()
        {
            string d;
            string chemin;
            Console.WriteLine("décalage");
            d = Console.ReadLine();
            int decalage = Int32.Parse(d);
            Console.WriteLine("chemin du fichier");
            chemin = Console.ReadLine();
            string word = File.ReadAllText(@chemin);

            Console.WriteLine(Cesar(word, decalage));
        }
    }
}
