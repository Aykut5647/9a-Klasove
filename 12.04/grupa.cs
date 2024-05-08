using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._04
{
    class grupa
    {
        private string ime;
        private string adres;
        private double ocenki;
        public String Ime
        {
            get { return  ime; }
            set { ime = value; }
        }
        public String Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        public double Ocenki
        {
            get { return ocenki; }
            set { ocenki = value; }
        }
        public void izhodi()
        {
            Console.WriteLine("Zdravey! Az sum {0}, jiveq v {1} i imam {2} ocenka",ime, adres, ocenki);
            Console.WriteLine($"Zdravey! Az sum {ime}, jiveq v {adres} i imam {ocenki} ocenka");
            Console.WriteLine("Zdravey! Az sum "+ ime+" jiveq v "+ adres+" i imam ocenka "+ ocenki);
        }
    }
}
