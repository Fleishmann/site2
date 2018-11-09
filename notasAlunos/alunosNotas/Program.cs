using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notasAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; //contador
            double nota = 0, somadasnotas = 0, mediadasnotas = 0;

            //laço de repetição para ler as 5 Notas 
            for (i = 1; i<=5;i++)
                {
                Console.Write("Informe a [{0}ª] Nota: ", i);
                nota = Double.Parse(Console.ReadLine());

                somadasnotas = somadasnotas + nota;
                }
            //calcula a media das notas
            mediadasnotas = somadasnotas / 5;
            Console.Write("\nA soma das notas é : /n /n" + somadasnotas);
            Console.Write("\nA media das notas é : /n /n" + mediadasnotas);
            Console.ReadKey();  
        }
    }
}
