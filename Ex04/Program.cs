using System;
using System.IO;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
           /* 4.- Disposem de les dades de l'atur a Espanya des de l'any 1990 en forma de seqüència d'enters. Cada
valor de la seqüència es correspon al nombre d'habitants aturats un mes i any concret. Les dades
arriben ordenadament començant per l'any 1990 mes 1 , any 1990 mes 2, ...., any 1990 mes 11 , any
1990 mes 12 , any 1991 mes 1, any 1991 mes 2 etc.La seqüència acaba amb el 0.
 Es demana : informar en quin més i any la tendència d'atur es va invertir.
 Mireu l'exemple (any 1990 mes 1,2,3,4,5,6,etc). En el mes 7 de l'any 1990 es va invertir la tendència ja
que hi ha 3 mesos seguits com a mínim que cada mes el valor es inferior a l’anterior
 5748382(any 1990 mes 1)
 6789900(any 1990 mes 2)
 7000002(any 1990 mes 3)
 7560101(any 1990 mes 3)
 8001013(any 1990 mes 4)
 8231101(any 1990 mes 5)
 8110110(any 1990 mes 7)
 8053429(any 1990 mes 8)
 8000101(any 1990 mes 9)
 7910110(any 1990 mes 10)
*/

            int paro1, paro2=int.MinValue;
           
            int i;
            int contador = 0;
            int contador2 = 0;
            Random rnd = new Random();

            //Per generar un fitxer amb dades aleatories

            StreamWriter fitxerW = new StreamWriter("paro.txt");
           

            int num = rnd.Next(45,50);

            for (i=0; i<=num;i++)
            {
                fitxerW.WriteLine(rnd.Next(8000000, 99999999));
            }

            fitxerW.Close();
           
            // Comença l'exercici en sí;

            StreamReader fitxerR = new StreamReader("paro.txt");
            StreamWriter fitxerW2 = new StreamWriter("resultat.txt");

            paro1 = int.Parse(fitxerR.ReadLine());

            do
            {
                if (paro2 < paro1) 
                    contador++;
                else contador = 0;               
                paro1 = paro2;               
                paro2 = int.Parse(fitxerR.ReadLine());
                contador2++;

            } while (!fitxerR.EndOfStream && contador < 3);
            int mes;            
            int anys;          
            anys = contador2 / 12;
            mes = contador2 % 12;
            fitxerW2.WriteLine($"La tendencia cambia l'any {anys+1990} al mes {mes}.({paro2} aturats)");
            fitxerW2.Close();
            fitxerR.Close();




        }
    }
}
