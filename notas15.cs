using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notas15
{
    class Program
    {
        public struct Aluno
        {
            public string nome;
            public int nota1;
            public int nota2;
            public double media;
        }
        static void Main(string[] args)
        {
            const int TAM = 15;
            Aluno[] aluno = new Aluno[TAM];
            for(int x = 0; x < TAM; x++)
            {
                Console.WriteLine("Nome do {0}° aluno: ", x);
                aluno[x].nome = Console.ReadLine();
                Console.WriteLine("Primeira nota: ");
                aluno[x].nota1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Segunda nota: ");
                aluno[x].nota1 = int.Parse(Console.ReadLine());
            }
        }
    }
}
