using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    class Media
    {
        public static void Aluno()
        {
            Console.WriteLine("Cálculo de média..");
            Console.WriteLine("Quantas notas deseja calcular ?");
            int nNotas = Convert.ToInt32(Console.ReadLine());
            var Notas = new List<int>();
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            for (int c = 0; c < nNotas; c++)
            {
                Console.WriteLine($"Digite a {c + 1}ª nota: ");
                int nota = int.Parse(Console.ReadLine());
                Notas.Add(nota);

            }

            double total = 0;
            foreach (double x in Notas)
            {
                total += x;
            }

            double media = total / Notas.Count;
            Console.WriteLine($"À media do {nome} é {media}\n");
        }
    }
}
