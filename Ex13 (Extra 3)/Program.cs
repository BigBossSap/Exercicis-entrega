using System;

namespace Ex13__Extra_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4.- Diccionari. Tenim un fitxer en el nostre ordinador que es dirà diccionari.txt. En aquest contindrem
   les paraules d’un diccionari, per a l’examen podeu crear un diccionari amb 10 paraules. Ara (a casa)
   podeu buscar diccionaris a internet de català en txt (compte amb els accents i compte amb els
   catxarros que teniu que si el diccionari és gran li costarà compilar).
   Es demana que feu un programa on pugam escriure un text acabat amb intro ‘\r’. (igual que l’exercici
   2, la llegim en un Console.Read()). El nostre codi ha de comprovar que no hi ha espais en blanc
   innecessaris, si els hi ha els traiem (ho hem fet mil cops a classe). Per a cada paraula escrita (al igual
   que el 2, sabem que és una paraula si el caràcter anterior es una lletra i l’actual no ho és) hem de
   buscar en el diccionari si existeix. Hem de reescriure el nostre text sense errors.
   1.- Si la paraula existeix al diccionari la escrivim igual i passem a la següent paraula. 2.- Si la
   paraula no existeix escrivim un ‘*’ i passem a la següent paraula.
   PD. Penseu que el nostre programa pot tenir signes de puntuació, espais, números, … no són
   paraula QUALSEVOL COSA QUE NO SIGUI UNA LLETRA NO ÉS PART DE LA
   PARAULA (no conteu accents).
   Exemple de diccionari.txt (penseu que les paraules al diccionari estaran una baix l’altra): repetir
   examen prova Jordi programacio dificil avorrida professor es suspes
   Ex:
   i tenim el text:
   Jordi es un mal professor i em fa tenir la programacio avorrida perque ho fa dificil. Hem
   de reescriure:
   Jordi es * * professor * * * * * programacio avorrida * * * dificil
   Ex2:
   He suspes programacio,,, perque 2313 no pegue??? ni23 brot
   Reescriu:
   * suspes programacio,,, * 2313 * *??? *23 *
   PD: Això és el que demanava a l’exam, si 
            voleu podeu treure tot el restant números,
   elements repetits, ... */


            int contTotal = 2, contParaules = 1, contLong = 0, comparador = 0;
            string paraulaM = "", paraulaActual = "";
            char lletraA, lletraS;

            lletraA = (char)Console.Read();

            do
            {
                lletraA = (char)Console.Read();

            } while (lletraA < 'a' || lletraA > 'z');

            lletraS = (char)Console.Read();

            do
            {

                if (lletraS >= 'a' && lletraS <= 'z')
                {
                    paraulaActual += lletraS;
                    contLong++;
                }

                if ((lletraA >= 'a' && lletraA <= 'z') && (lletraS < 'a' || lletraS > 'z') || ((lletraA < 'a' && lletraA > 'z') && (lletraS >= 'a' || lletraS <= 'z')))
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


                if (lletraA < 'a' || lletraA > 'z')
                    contTotal--;


                contTotal++;
                lletraA = lletraS;
                lletraS = (char)Console.Read();

            } while (lletraS != '\r');
            int mitjana;

            if (lletraS < 'a' || lletraS > 'z')

                contParaules--;



            if (contParaules == 0)
                Console.WriteLine("No hi ha paraules!");
            else
            {
                mitjana = contTotal / contParaules;
                Console.WriteLine(contTotal);
                Console.WriteLine(contParaules);
                Console.WriteLine($"La mitjana de paraula es {mitjana}, la longitud maxima es {comparador} que correspon a {paraulaM}");
            }




        }
    }
}
