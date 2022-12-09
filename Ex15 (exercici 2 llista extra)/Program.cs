using System;

namespace Ex15__exercici_2_llista_extra_
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            double n, resultat=0, resultatAnt=1,i=0;

            Console.WriteLine("n:");
            n= double.Parse(Console.ReadLine());


            while (resultat!=resultatAnt)
            {
                resultatAnt = resultat;
                resultat = ((n+i) + (n / (n+i))) / 2;
                i++;
                

                Console.WriteLine(resultat);
                


            }

           



        }
    }
}
