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


            char lletra;
            string paraula="";
            string paraula2="";
            bool escriu=true;
            lletra = (char)(Console.Read());


            while (lletra != '.')
            {

                if (escriu && lletra!=' ')
                    paraula += lletra;

                if (lletra == ' ')
                {

                    if (paraula == paraula2)
                    {
                        Console.WriteLine($"repetida {paraula2}");
                        paraula = "";
                        paraula2 = "";
                    }
                    if (paraula != paraula2 && lletra == ' ')
                    {
                        paraula = "";

                    }
                    escriu = false;
                    lletra = (char)(Console.Read());
                    
                    while (lletra != ' ' && lletra !='.' && lletra !='\r')
                    {
                        paraula2 += lletra;
                        lletra = (char)(Console.Read());
                                      
                    }


                   

                    escriu = true;
                }
                //paraula2 += lletra;


                
               
                
                lletra = (char)(Console.Read());

            }

            
        }
    }
}
