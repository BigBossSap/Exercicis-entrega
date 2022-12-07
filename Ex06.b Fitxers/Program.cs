using System;
using System.IO;

namespace Ex06.b_Fitxers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader fitxerR = new StreamReader(@"frase.txt");
            StreamWriter fitxerW = new StreamWriter(@"resultat.txt");

            char lletra;
            int cont = 1;
            bool parell = true;

            
            lletra = (char)(fitxerR.Read());

            while (!(lletra == '.') && parell == true)
            {
                if (lletra == 'a' || lletra == 'e' || lletra == 'i' || lletra == 'o' || lletra == 'u')

                {
                    if (cont % 2 != 0)
                        parell = false;
                }


                else if (!(lletra == 'a' && lletra == 'e' && lletra == 'i' && lletra == 'o' && lletra == 'u') && lletra != ' ')
                {
                    if (cont % 2 == 0)
                        parell = false;
                }



                



                cont++;
                lletra = (char)(fitxerR.Read());


            }

            if (parell == false)
                fitxerW.WriteLine("No es correcta");
            else
                fitxerW.WriteLine("Es correcta");

            fitxerR.Close();
            fitxerW.Close();
        }
    }
}
