using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastrocarroo
{
    class Program
    {
        public struct Carro
        {
            public string marca, cor, modelo, placa;
            public int ano;

        }

        public static void Main(string[] args)
        {

            Carro[] carros = new Carro[500];
            Console.WriteLine("Menu");
            Console.WriteLine();
            int menu;
            int x = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n1-Cadastrar carro\n2-Consultar carro por ano de fabricação\n3-Consultar carro por modelo\n4-Consultar carro por cor \n5-Exibir todos os carros cadastrados\n6-Alterar algum dado de um carro\n7-Excluir um carro\n0-SAIR\n\nDigite sua opção: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Write("\nCadastrar carro");
                        Console.WriteLine("\nMarca do carro: ");
                        carros[x].marca = Console.ReadLine();
                        Console.WriteLine("\nCor do carro: ");
                        carros[x].cor = Console.ReadLine();
                        Console.WriteLine("\nModelo do carro: ");
                        carros[x].modelo = Console.ReadLine();
                        Console.WriteLine("\nAno do carro: ");
                        carros[x].ano = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nPlaca: ");
                        carros[x].placa = Console.ReadLine();
                        x++;
                        break;
                    case 2:
                        Console.Write("\nConsultar carro por ano de fabricação");
                        Console.Write("\nDigite o ano: ");
                        int a = int.Parse(Console.ReadLine());
                        for (int y = 0; y < x; y++)
                        {
                            if (carros[y].ano == a)
                            {
                                Console.WriteLine("\n{0},{1},{2},{3}", carros[y].marca, carros[y].modelo, carros[y].cor, carros[y].ano, carros[y].placa);
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("\nConsultar carro por modelo");
                        Console.Write("\nDigite o modelo: ");
                        string m = Console.ReadLine();
                        for (int y = 0; y < x; y++)
                        {
                            if (carros[y].modelo == m)
                            {
                                Console.WriteLine("\n{0},{1},{2},{3}", carros[y].marca, carros[y].modelo, carros[y].cor, carros[y].ano, carros[y].placa);
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("\nConsultar carro por cor");
                        Console.Write("\nDigite a cor: ");
                        string c = Console.ReadLine();
                        for (int y = 0; y < x; y++)
                        {
                            if (carros[y].cor == c)
                            {
                                Console.WriteLine("\n{0},{1},{2},{3}", carros[y].marca, carros[y].modelo, carros[y].cor, carros[y].ano, carros[y].placa);
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Write("\nExibir todos os carros cadastrados");
                        for (int y = 0; y < x; y++)
                        {
                            Console.WriteLine("\n\nCarro: {0},{1},{2},{3}", carros[y].marca, carros[y].modelo, carros[y].cor, carros[y].ano, carros[y].placa);
                        }
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Write("\nAlterar algum dado de um carro");
                        Console.Write("\nDigite a placa: ");
                        string p = Console.ReadLine();
                        for (int y = 0; y < x; y++)
                        {
                            if (carros[y].placa == p)
                            {
                                Console.WriteLine("\n1-Marca \n2-Cor \n3-Modelo \n4-Ano \n5-Placa");
                                Console.WriteLine("Qual opção deseja alterar? ");
                                int op = int.Parse(Console.ReadLine());
                                if (op == 1)
                                {
                                    Console.WriteLine("Digite a nova marca: ");
                                    carros[y].marca = Console.ReadLine();
                                    Console.WriteLine("Alteração feita. Aperte qualquer tecla para voltar ao menu.");

                                }
                                else if (op == 2)
                                {
                                    Console.WriteLine("Digite a nova cor: ");
                                    carros[y].cor = Console.ReadLine();
                                    Console.WriteLine("Alteração feita. Aperte qualquer tecla para voltar ao menu.");

                                }
                                else if (op == 3)
                                {
                                    Console.WriteLine("Digite o novo modelo: ");
                                    carros[y].modelo = Console.ReadLine();
                                    Console.WriteLine("Alteração feita. Aperte qualquer tecla para voltar ao menu.");

                                }
                                else if (op == 4)
                                {
                                    Console.WriteLine("Digite a novo ano: ");
                                    carros[y].ano = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Alteração feita. Aperte qualquer tecla para voltar ao menu.");

                                }
                                else
                                {
                                    Console.WriteLine("Digite a nova placa: ");
                                    carros[y].placa = Console.ReadLine();
                                    Console.WriteLine("Alteração feita. Aperte qualquer tecla para voltar ao menu.");
                                }
                            }
                        }
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Write("\nExcluir um carro");
                        Console.Write("\nDigite a placa: ");
                        p = Console.ReadLine();
                        for (int y = 0; y < x; y++)
                        {
                            if (carros[y].placa == p)
                            {
                                carros[y].modelo = "";
                                carros[y].cor = "";
                                carros[y].marca = "";
                                carros[y].ano = 0;
                                carros[y].placa = "";

                                Console.WriteLine("Carro excluido. Aperte qualquer tecla para voltar ao menu.");
                            }
                        }
                        Console.ReadKey();
                        break;
                    default:
                        if (menu > 7)
                        {
                            Console.WriteLine("Opção inválida!");
                            Console.ReadKey();
                        }
                        break;
                }
            }
            while (menu != 0);
            Console.WriteLine("O Programa acabou.");

        }
    }
}
