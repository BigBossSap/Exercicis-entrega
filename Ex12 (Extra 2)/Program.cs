using System;
using System.IO;
using System.Xml;

namespace Ex12__Extra_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3.- Donat un fitxer anomenat serieAmagada.txt que conté una sèrie numèrica volem saber si aquesta
 és creixent o decreixent. Aquesta sèrie està amagada, només té en compte els valors repetits 3 o
 més cops de forma seguida, la resta no ens serveixen per a res. La sèrie acaba en -1 o al final del
 fitxer.
 (nota, en el fitxer els tindreu un baix l’altre amb un intro) Ex:
 Si tenim una sèrie 1 1 2 5 2 3 3 3 3 1 9 3 1 7 7 7 7 7 7 7 7 7 2 3 9 9 9 -1
 Només ens interessa el 3 7 9 ja que de forma seguida estan repetits 3 o més cops, dona igual que el
 7 estigui repetit 9 cops, el contarem com a un únic 7
 Ex2:
 Si tenim la sèrie 1 2 3 4 1 2 3 56 7 3 7 8 3 4 8 9 9 5 3 4 No ens
 interessa cap valor.
 Un cop hem reconegut els valors en la sèrie amagada hem de dir si és creixent, decreixent o res */


            StreamReader fitxerR = new StreamReader("amagada.txt");

            
            int valorActual;
            int valorAnterior;
            int numRepetit=int.MinValue;
            int aux = 0;
            int cont = 0, contRepetits = 0;
            string secuencia = "";
            bool creixent = true;


            valorAnterior = int.Parse(fitxerR.ReadLine());
            valorActual = int.Parse(fitxerR.ReadLine());
            

            while(valorActual != -1 && !fitxerR.EndOfStream)
            {
                if (valorActual == valorAnterior)
                {
                    cont++;
                    
                }

                if (valorAnterior != valorActual)
                    cont = 0;


               

                if (cont>1)
                {


                    aux = numRepetit;
                    numRepetit = valorActual;

                    if (aux>valorActual)
                        creixent = false;

                    secuencia += valorActual;
                    contRepetits++;
                }

                
                


                valorAnterior = valorActual;
                valorActual = int.Parse(fitxerR.ReadLine());


                
                
            }
            
            if (creixent==false)
                Console.WriteLine("No es creixent");

            else if (contRepetits==0)
                Console.WriteLine("No hi ha secuencia amagada");
            else 
                Console.WriteLine("Es creixent");

            Console.WriteLine(secuencia);

            
           



        }
    }
}
