using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*10.- Fes un programa que demani una seqüència de caràcters (lletra a lletra amb Read) acabada en '.' i
   digui les paraules seguides iguals i en quines posicions es troben, i finalment que ens compte quantes
   n’hi ha.
    Ex:
    Es un un examen massa massa fàcil.
    Paraules repetides 2:
    paraula un posició 2
    paraula massa posició 5*/


            int  contParaules = 0, contRep = 0;
            string paraulaAnterior = "", paraulaActual = "";
            char lletraA, lletraS;
            bool escriure = true;

            lletraA = (char)Console.Read();
            lletraS = (char)Console.Read();
            paraulaActual += lletraA;

            do
            {


                if (lletraS != ' ')
                {
                    paraulaActual += lletraS;

                }


                if ((lletraA >= 'a' && lletraS <= 'z') && (lletraS < 'a' || lletraS > 'z') ||(paraulaAnterior == paraulaActual))
                {

                    contParaules++;

                    if (paraulaAnterior == paraulaActual)
                    {
                        contRep++;
                        Console.WriteLine($"{paraulaActual} en posicio {contParaules}");

                    }

                    paraulaAnterior = paraulaActual;
                    paraulaActual = "";
                }






                lletraA = lletraS;
                lletraS = (char)Console.Read();

            } while (lletraS != '.');


            Console.WriteLine($"paraules repetides en total {contRep}");




















        }
    }
}