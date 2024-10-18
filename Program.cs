using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Doga_2
{
    internal class Program
    {
        public static void Jelszo()
        {
            string real_jelszo = "HamiltonTheGoat44";
            string jelszo;
            bool jelszoElfogadva = false;

            while (!jelszoElfogadva)
            {
                Console.Write("Kérem, adja meg a jelszót: ");
                jelszo = Console.ReadLine();

                if (real_jelszo == jelszo)
                {
                    Console.WriteLine("Jelszó elfogadva!");
                    jelszoElfogadva = true;
                }
                else
                {
                    Console.WriteLine("A jelszó nem felel meg. Kérjük, próbálja újra.");
                }
            }
        }

        static void Main(string[] args)
        {
            Jelszo();
        }
    }

}
   

