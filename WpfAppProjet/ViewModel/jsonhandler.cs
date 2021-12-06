using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppProjet;
using Projet_progsys;

namespace ConsoleApp3testjson
{
    public class Utilisateur
    {

        public string SaveName { get; set; }

        public string Source { get; set; }

        public string Target { get; set; }



        public Utilisateur()
        {
            
        }

        public override string ToString()
        {
            return $"SaveName : {SaveName}\n" +
                $"Source : {Source}\n" +
                $"Target : {Target}\n";
        }

    }
}
