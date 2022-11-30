using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fer un programa que permeti la introducció d’una sèrie de números fins que
     un d’aquests números sigui major que la suma dels dos números anteriors.
     Al finalitzar, ha de dir el número d'introduccions i valors dels números que
     han complert la condició de finalització del programa.*/

            int seguent;
            int suma = int.MaxValue;
            int anterior = 0;
            int num1 = 0;
            int num2 = 0;
            int contador = 2;


            Console.WriteLine("num: ");
            anterior = int.Parse(Console.ReadLine());
            seguent = int.Parse(Console.ReadLine());



            do
            {
                contador++;
                suma = anterior + seguent;
                num2 = anterior;
                anterior = seguent;
                num1 = seguent;
                seguent = int.Parse(Console.ReadLine());

            } while (seguent <= suma);

            Console.WriteLine($"Els valors que han complert la condicio son {num2} i {num1} que sumen {suma} i el numero {seguent} es major");
            Console.WriteLine($"S'han introduit {contador} numeros");
        }
    }
}
