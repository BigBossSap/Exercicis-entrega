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


            int  contParaules = 1, contRep = 0;
            string paraulaAnterior = "", paraulaActual = "";
            char lletraA, lletraS;
            bool escriure = true;

            lletraA = (char)Console.Read();
            lletraS = (char)Console.Read();

            while (lletraS != '\r')
            {


                if (lletraS != ' ')
                {
                    paraulaActual += lletraS;
                    contParaules++;
                }


                    if ((lletraA >= 'a' && lletraA <= 'z') && (lletraS < 'a' || lletraS > 'z') || (lletraS == '\r'))
                {

                    contParaules++;
                    
                    if (paraulaAnterior == paraulaActual)
                    {
                       contRep++;

                    }
                        
                    paraulaAnterior = paraulaActual;
                    paraulaActual = "";
                }

                

                

                
                lletraA = lletraS;
                lletraS = (char)Console.Read();

            }

            Console.WriteLine($"Paraules repetides {contRep}");
            







        
                





               

            


        }
    }
}