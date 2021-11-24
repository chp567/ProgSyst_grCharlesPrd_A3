using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_progsys
{
    class _Inputs : Interface
    {
        private string src;
        private string dest;
        private string name;

        public string Source()
        {
            string src = Console.ReadLine();
            this.src = src;
            return this.src;
        }

        public string Destination()
        {
            string dest = Console.ReadLine();
            this.dest = dest;
            return this.dest;
        }

        public string GetSource()
        {
            return this.src;
        }

        public string GetDest()
        {
            return this.dest;
        }
        
        public string SetName(string name)
        {
            this.name = name;
            return this.name;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
