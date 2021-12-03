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

        public string Source()
        {
            string src = @"C:\Users\Hanton\Desktop\Tout\CESI\ASSOS";
            this.src = src;
            return this.src;
        }

        public string Destination()
        {
            string dest = @"C:\Users\Hanton\Desktop\Tout\CESI\A1";
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
        
        public string SetName()
        {
            this.name = "Save 1";
            return this.name;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
