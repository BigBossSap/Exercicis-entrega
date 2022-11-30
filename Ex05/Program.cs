using System;
using System.IO;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5.- A partir d’un fitxer del tipus mostrat ens diu el nom de l’usuari major.
   (Si dos usuaris tenen la mateixa edat, només en mostra un). */

            StreamReader fitxerR = new StreamReader(@"edats.txt");

            string nom;
            int edat, edat2;

            nom = fitxerR.ReadLine();
            edat = int.Parse(fitxerR.ReadLine());


            while(!fitxerR.EndOfStream)
            {
                
                
                if ()
                
                
                
                
                nom = fitxerR.ReadLine();
                edat = int.Parse(fitxerR.ReadLine());
            }

        }
    }
}
