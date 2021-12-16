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
            //set source
            string src = source;
            this.src = src;
            return this.src;
        }

        public string Destination(string destination)
        {
            //set destination
            string dest = destination;
            this.dest = dest;
            return this.dest;
        }

        public string GetSource()
        {
            //get source
            return this.src;
        }

        public string GetDest()
        {
            //get destination
            return this.dest;
        }
        
        public string SetName(string name)
        {
            //set name
            this.name = name;
            return this.name;
        }

        public string GetName()
        {
            //get name
            return this.name;
        }
    }
}
