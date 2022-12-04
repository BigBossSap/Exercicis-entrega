using System;

namespace Ex11__Extra_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2.- Fer un programa que ens permet escriure una frase completa acabada en intro ‘\r’. Haurem
   d’analitzar la frase caràcter a caràcter amb Console.Read().
   Ens indique la mitjana de paraula, la longitud màxima de paraula i paraula màxima. Per a saber que
   hem detectat una paraula haurem de mirar que el caràcter anterior sigui una lletra i l’actual no sigui
   una lletra.
   Signes de puntuació, espais, números, … no són paraula QUALSEVOL COSA QUE NO SIGUI UNA
   LLETRA NO ÉS PART DE LA PARAULA (no conteu accents).
   Ex: hola, com estas?
   té 3 paraules, que són hola com estas ha
   de mostrar per pantalla:
   mitjana de paraula 4, longitud màxima 5 la paraula es estas
   Ex2: 342hola,,,, ,,, ??? com,,, estas43_--- ; té 3
   paraules, que són hola com estas
   ha de mostrar per pantalla:
   mitjana de paraula 4, longitud màxima 5 la paraula es estas 
   */




            int contTotal = 0, contParaules = 1, contLong = 0, comparador = 0;
            string paraulaM = "", paraulaActual="";
            char lletraA, lletraS;

            lletraA = (char)Console.Read();
            lletraS = (char)Console.Read();

            while (lletraS!='\r')
            {

                contLong++;
                paraulaActual += lletraS;
               

                if((lletraA>='a'&&lletraA<='z')&&(lletraS<'a'||lletraS>'z')||(lletraS=='\r'))
                {

                    contParaules++;
                    contLong = 0;
                    paraulaActual = "";
                }

                if (contLong > comparador)
                {
                    comparador = contLong;
                    paraulaM = paraulaActual;
                    
                }
               
                
                if(lletraA<'a' || lletraA>'z')
                    contTotal--;

                contTotal++;
                lletraA = lletraS;
                lletraS = (char)Console.Read();
                
            }
            int mitjana;
            mitjana = contTotal / contParaules;
            Console.WriteLine($"La mitjana de paraula es {mitjana}, la longitud maxima es {comparador} que correspon a {paraulaM}");
            
            //No esta be, falla si fas espais o caracters diferents a lletra. I tambe si començes amb algun caracter que no sigui lletra.




        }
    }
}
