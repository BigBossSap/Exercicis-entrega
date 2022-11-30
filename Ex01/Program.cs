using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Donada una frase acabada en punt, fer un programa que compti el nombre
     de caràcters que hi apareixen a partir de la primera ‘a’, ja sigui majúscula o
     minúscula. 
     */

            char lletra;
            int contador = 0;
            string frase = "";
            bool lletraA = false;

            Console.WriteLine("Introdueix una frase acabada en punt: ");
            lletra = Console.ReadKey().KeyChar;

            while (lletra != '.' && lletraA == false)
            {
                if (lletra == 'a' || lletra == 'A')
                {
                    lletraA = true;
                }

                frase += lletra;
                lletra = Console.ReadKey().KeyChar;
            }
            while (lletra != '.' && lletraA == true)
            {

                if (lletra == ' ' || lletra == '.')
                {
                    contador--;
                    frase += lletra;
                }


                contador++;
                frase += lletra;
                lletra = Console.ReadKey().KeyChar;

            }

            Console.WriteLine($"\r La frase #{frase}# te {contador} caràcters a partir de la primera 'a', sense contar espais.");
        }
    }
}
