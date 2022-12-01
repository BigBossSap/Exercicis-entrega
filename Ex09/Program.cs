using System;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9.- Volem fer un programa per calcular la mitjana de kw hora que hem de pagar a l’empresa Ipertrola
   per dia. Un usuari entrarà les dades i acabarà amb un 0.
   - Els kw han de ser positius i si la lectura indica més de 35,3 kw indicar que es un error, tant si és
   negatiu com si la lectura és massa elevada, les descartem i seguim amb les següents.
   - Si l’usuari no ha estat a casa i per tant la primera lectura es un 0, direm per consola “Usuari
   absent”.
   - Ipertrola no li agraden els valors petits, així que totes les lectures inferiors a 7,3 li afegeix +5kw a
   l’hora de contabilitzar.
   - El resultat més petit de tots el treu del recompte, per tant tampoc contarem aquesta lectura.
   - Finalment el programa ha de mostrar la mitjana de consum que ha tingut l’usuari per consola i ha
   de tenir emmagatzemada la dada més baixa en una variable per a saber quina ha sigut descartada. */


            double kw, min = int.MaxValue, kwMin = 0, suma = 0, cont=0;
            double sumaTotal = 0;



            kw = double.Parse(Console.ReadLine());
            
            while (kw!=0)
            {
                while (kw<=0 || kw > 35.3)
                {
                    Console.WriteLine("Error, valor demasiado alto/bajo");
                    kw=double.Parse(Console.ReadLine());
                }

                if (kw<7.3)
                {
                    kw += 5;
                }

                if (kw<min)
                {
                    min = kw;
                    kwMin = kw;

                }


                cont++;
                suma += kw;
                sumaTotal = suma - kwMin;
                kw = double.Parse(Console.ReadLine());

            }

           
            if (suma==0)
                Console.WriteLine("Usuario absente");
            else
                Console.WriteLine($"El consumo total ha sido {sumaTotal}kw, descartando la lectura mas baja: {kwMin}kw. La media de consumo ha sido: {Math.Round(sumaTotal / cont, 2)}kw");




        }
    }
}
