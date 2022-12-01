using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6.- Donada una seqüència de caràcters, hem de detectar si la cadena acabada en '.' és errònia. Serà
   errònia si apareixen vocals en posicions senars o consonants en posicions parells. Considerem que la
   seqüència comença per la posició 1.
   Per exemple la seqüència:
   sara es la amiga. -- és correcta vocals en posicions parell i consonants en senar
   jordi no es amic. -- no és correcta ja que apareix una consonant en una posició parell d (4) */


            char lletra;
            int cont=1, contC=0, contV=0;
            bool parell = true;

            Console.WriteLine("frase:");
            lletra = (char)(Console.Read());

            while (!(lletra=='.'))
            {
                if (lletra == 'a' || lletra == 'e' || lletra == 'i' || lletra == 'o' || lletra == 'u')
                    
                {
                    if (cont % 2 != 0)
                        parell = false;
                }
                    

                else if (!(lletra == 'a' || lletra == 'e' || lletra == 'i' || lletra == 'o' || lletra == 'u') && lletra!=' ')
                {
                    if (cont % 2 == 0)
                        parell = false;
                }



                cont++;
                lletra = (char)(Console.Read());
            }

            if (parell==false)
                Console.WriteLine("No es correcta");
            else
                Console.WriteLine("Es correcta");



        }
    }
}
