using System;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7.- Donada una seqüència de números acabada en -1, indicar en quants números tenen el 25 entre les
   seues xifres... per exemple el 14254 té aquesta condició i dir quins números són (podeu concatenar un
   string)*/
            int ant, act, act2, cont = 0;
            string numeros = "";
            ant = int.Parse(Console.ReadLine());
            act = int.Parse(Console.ReadLine());


            while (act != -1)
            {
                if (act==2)
                {
                       numeros += ant;
                                    
               }
                ant = act;
                act = int.Parse(Console.ReadLine());

                if (act==5)
                {
                    cont++;
                }
                else if (act != 5)
                    numeros += "\b";

                ant = act;
                act = int.Parse(Console.ReadLine());
                act2 = act;
                


            }

            Console.WriteLine(numeros);
        }
    }
}
