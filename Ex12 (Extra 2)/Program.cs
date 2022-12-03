using System;
using System.IO;

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

            string serie = "";
            char valorActual;
            char valorAnterior ;
            int cont = 0;


            valorAnterior = fitxerR.Read();
            valorActual = fitxerR.Read();
            

            while(valorActual != -1 && !fitxerR.EndOfStream)
            {
                if (valorActual == valorAnterior)
                    cont++;


                Console.WriteLine(valorActual);
                Console.WriteLine(valorAnterior);
            }



        }
    }
}
