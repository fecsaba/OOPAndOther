using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAndOther
{
    class Termekek
    {
        private string nev;

        public string Nev
        {
            get
            {
                return nev;
            }
            set
            {
                nev = value;
                if (nev.Length==0)
                {
                    Console.WriteLine("El...tad");
                }
                
               

            }
            
        }
        //public Termekek(string n)
        //{
        //    nev = n;
        //}
    }
}
