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
            int ant, ant1 = 0, ant2 = 0, i = 0, num, posterior;
            bool semafor = false;

            Console.WriteLine("Escriu un num");
            num = Convert.ToInt32(Console.ReadLine());

            ant = 0;
            posterior = 0;

            while (num != -1)
            {
                if (semafor == true && i == 0)
                {
                    posterior = num;
                    i++;
                }


                if (num == 5 && ant == 2)
                {
                    semafor = true;
                    ant2 = ant1;
                }

                ant1 = ant;
                ant = num;
                num = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine($"L'anterior de 25 es {ant2} i el posterior {posterior}");
        }
    }
}
