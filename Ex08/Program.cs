using System;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.- Un professor fa diferents exàmens als seus estudiants, posant a cada estudiant una nota
      real entre 0 i 10 . El professor, ha encarregat a un alumne trampós que li faci un programa
      amb C# per obtenir la nota final d'un estudiant , però l’estudiant ha decidit que el programa
      funcionarà de la següent forma:
      • Si la nota no està entre 0 i 10 informa que hi ha un error en la nota, la descarta i en
      demana una altra.
      • Fa la mitjana de totes les notes, però sense incloure les notes més petites de 5.
      • Per maquillar el resultat, també exclourà la nota màxima entrada .
      • Si la nota màxima és menor que 5 (és a dir, el programa les descartaria totes) ,
      Llavors la nota final que el programa ha de mostrar és un 5 independentment de les
      notes que hagi tret.
      • Si no s'entra cap nota, llavors s'ha de mostrar el missatge "NO HI HAN NOTES"
      Per exemple, si un alumne ha tret les següents qualificacions en els exàmens:
      8,5
      3,4
      5,5
      4,4
      7,9
      La seva nota final seria : (5,5+7,9) / 2
      I la nota descartada seria 8,5
      Es demana :
      Donada Una seqüència de nombres reals acabada amb -1 mostrar :
      • El promig de les notes, descartant la més alta i les menors de 5.
      • La nota descartada (òbviament la més alta).
      Tingueu en compte que no sabem quantes notes s'han d'entrar a priori.*/
            double nota;
            double mediana;
            double cuantos = -1;
            double suma = 0;
            double notaMax = 0;
            double minim = double.MinValue;
            Console.WriteLine("Notes: ");
            nota = double.Parse(Console.ReadLine());
            while (nota != -1)
            {
                while (nota < 0 || nota > 10)
                {
                    Console.WriteLine("Error");
                    nota = double.Parse(Console.ReadLine());
                }
                if (nota < 5)
                {
                    nota = 0;
                    cuantos--;
                }
                if (nota > minim)
                {
                    minim = nota;
                    notaMax = nota;
                }
                cuantos++;
                suma = suma + nota;
                nota = double.Parse(Console.ReadLine());
            }
            if (suma == 0)
                Console.WriteLine("No hi ha notes per fer la mitjana");
            else
            {
                suma -= notaMax;
                mediana = suma / cuantos;
                Console.WriteLine($"La nota mitjana es {Math.Round(mediana, 1)}");
            }
        }
    }
}
