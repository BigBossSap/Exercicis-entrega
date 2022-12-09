using System;
using System.Globalization;
using System.IO;

namespace Exercici_extra_ordenar
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Random rnd = new Random();
            StreamWriter fitxerW = new StreamWriter("numeros.txt");


            int num = rnd.Next(30, 100);

            for (i = 0; i <= num; i++)
            {
                fitxerW.WriteLine(rnd.Next(20, 1001));
            }

            fitxerW.Close();



            int valor;
            int menor= int.MinValue; 
            int menorAnt=int.MaxValue;
            
            StreamReader fitxer;

            
            while (menor!=int.MaxValue)
            {
                fitxer = new StreamReader("numeros.txt");
                valor = int.Parse(fitxer.ReadLine());
                menorAnt = menor;
                menor = int.MaxValue;
                
                

                while (!fitxer.EndOfStream)
                {

                    

                    if (valor > menorAnt && valor<menor)
                        
                            menor = valor;
                                         
                 
                    valor = int.Parse(fitxer.ReadLine());
                }

                if (menor == int.MaxValue)
                    break;


                Console.WriteLine(menor);


                fitxer.Close();
            }





            
            
            fitxerW.Close();
            







        }
    }
}
