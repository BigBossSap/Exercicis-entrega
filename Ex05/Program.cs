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
            StreamWriter fitxerW = new StreamWriter(@"resultat.txt");

            string nom, nomMajor="";
            int edat, edat2 = int.MinValue, edatMajor = 0; 

            nom = fitxerR.ReadLine();
            edat = int.Parse(fitxerR.ReadLine());


            while(!fitxerR.EndOfStream)
            {
                
                
                if (edat > edat2)
                {
                    edatMajor = edat;
                    edat2 = edat;
                    nomMajor = nom;
                }
                
                
                
                
                nom = fitxerR.ReadLine();
                edat = int.Parse(fitxerR.ReadLine());
            }

            fitxerW.WriteLine($"El major es en/la {nomMajor} que te {edatMajor}");

            fitxerR.Close();
            fitxerW.Close();
            
        }
    }
}
