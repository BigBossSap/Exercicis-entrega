using System;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fer un programa, que després d’haver-li entrat N números positius, ens digui
  quin és el més petit, i quina posició ocupa dins la seqüència.*/


            int num, i=0;
            string numComplet = "";
            int comparador = int.MaxValue;
            int contTotal = 1;
            int Cont =0;
            

            Console.WriteLine("num: ");
            num = int.Parse(Console.ReadLine());


            while (num != 0)
            {
                if (num < comparador)
                {
                    comparador = num;
                    Cont = contTotal;
                }

                numComplet += num;


                contTotal++;
                num = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine(comparador);
            Console.WriteLine(Cont);

           
            
        }
    }
}
