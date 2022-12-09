using System.IO;
using System;



namespace Exercici_extra_ordenar
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Random rnd = new Random();
            StreamWriter fitxerW = new StreamWriter("numeros.txt");

            // Generamos un número aleatorio entre 30 y 100
            int num = rnd.Next(30, 100);

            // Escribimos el número aleatorio en el fichero
            for (i = 0; i <= num; i++)
            {
                fitxerW.WriteLine(rnd.Next(20, 1001));
            }

            // Cerramos el fichero
            fitxerW.Close();

            // Inicializamos la variable valor con el valor más grande posible para un entero
            int valor = 0;

            // Creamos un objeto StreamReader para leer el fichero
            StreamReader fitxer = new StreamReader("numeros.txt");

            // Iniciamos un ciclo while para leer y mostrar los números del fichero en orden
            while (valor != int.MaxValue)
            {
                // Inicializamos la variable valor con el valor más grande posible para un entero
                valor = int.MaxValue;

                // Iniciamos un ciclo for para encontrar el número más pequeño del fichero
                for (i = 0; i <= num; i++)
                {
                    // Leemos el siguiente valor del fichero
                    int n = int.Parse(fitxer.ReadLine());

                    // Si el valor leído es menor que valor y no es igual a int.MaxValue (para evitar que se muestre el mismo número más de una vez), lo asignamos a valor
                    if (n < valor && n != int.MaxValue)
                    {
                        valor = n;
                    }
                }

                // Si valor es diferente a int.MaxValue, mostramos el número más pequeño del fichero en consola
                if (valor != int.MaxValue)
                {
                    Console.WriteLine(valor);
                }
            }

            // Cerramos el fichero
            fitxer.Close();
        }
    }
}