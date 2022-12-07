using System;
using System.IO;

namespace Ex16__Exercici_3_llista_extra_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Un fitxer conté línies amb tripletes PRODUCTE, UNITATS, PREU_UNITARI
   corresponents a un ticket de venda d’un supermercat. Els productes rics amb colesterol
   són aquells que contenen el substring “PIZZ”.
   Retornarem la compra si en el ticket apareixen més d’un producte ric en colesterol.
   Per exemple, el següent fitxer implica un retorn de la compra ja que hi han 2 productes
   rics en colesterol (importa l’aparició de l’element, no el nombre d’unitats).
   GALETES INTEGRALS.
   3
   1,6
   PIZZA 4 ESTACIONS.
   8
   2,3
   SAFATA D’EMBOTITS IBÈRICS.
   1
   15
   BAGUETTE.
   2
   0,7
   PACK DE PIZZES.
   1
   11,5
   Es demana:
   A partir de la seqüència d’entrada, informar si retornem la compra o bé fem la compra
   finalment. Si fem la compra, informar de l’import total de la compra i en cas que hi hagi
   un producte ric en colesterol, cal informar-ne de quin és (ho pots afegir a un string de
   productes).
    Part b) Per a introduir-nos als strings podeu intentar fer aquest exercici amb
   tractament de cadenes per als productes. */


            int cont = 0;
            double quantitat, preu;
            char lletra;
            char caracter;
            StreamReader fitxerR;
            StreamWriter fitxerW;

            fitxerR=new StreamReader("comanda.txt");

            lletra = (char)fitxerR.ReadLine());
            quantitat=double.Parse(fitxerR.ReadLine());
            preu=double.Parse(fitxerR.ReadLine());

            while(!fitxerR.EndOfStream)
            {




                caracter = lletra.Read();




                

                lletra = fitxerR.ReadLine();
                quantitat = double.Parse(fitxerR.ReadLine());
                preu = double.Parse(fitxerR.ReadLine());



                


            }


            Console.WriteLine(lletra);
            Console.WriteLine(quantitat);
            Console.WriteLine(preu);





        }
    }
}
