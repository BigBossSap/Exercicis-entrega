using System;

namespace Ex14__Ex01_llista_extra_
{
    class Program
    {
        static void Main(string[] args)
        {
            char lletraA, lletraS;
            int cont = 0, repeticions=0;


            lletraA = (char)Console.Read();
            lletraS = (char)Console.Read();


            while(lletraS!='\r')
            {

                if (lletraA == 'l' && lletraS == 'a')
                {
                    cont++;
                    if (!(lletraA == 'l' || lletraS == 'a'))
                    {

                        cont = 0;
                    }

                    if (cont == 2)
                        repeticions++;

                }

                
                lletraA = (char)Console.Read();
                lletraS = (char)Console.Read();
            }

            Console.WriteLine($"S'han trobat {repeticions} lala's");
        }
    }
}
