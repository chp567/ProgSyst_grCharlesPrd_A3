using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_progsys
{
    class _Inputs
    {
        private string src;
        private string dest;
        private string name;

        public string Source(string source)
        {
            string src = source;
            this.src = src;
            return this.src;
        }

        public string Destination(string destination)
        {
            string dest = destination;
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
