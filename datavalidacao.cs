using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MainClass
{
    public struct Data
    {
        public int dia, mes, ano;
    }
    public static void Main(string[] args)
    {
        Data dataNasc;

        Console.WriteLine("Data do seu Nascimento");
        Console.Write("Dia: ");
        dataNasc.dia = int.Parse(Console.ReadLine());
        Console.Write("Mês: ");
        dataNasc.mes = int.Parse(Console.ReadLine());
        Console.Write("Ano: ");
        dataNasc.ano = int.Parse(Console.ReadLine());

        if (dataNasc.dia >= 32 || dataNasc.dia < 1 || dataNasc.mes >= 13 || dataNasc.mes >= 0)
        {
            Console.WriteLine("Data Inválida! ");
        }
        else if (dataNasc.mes == 02 && dataNasc.dia > 29 && dataNasc.ano % 4 == 0 && dataNasc.ano % 100 != 0 || dataNasc.ano % 400 == 0)
        {
            Console.WriteLine("Data Inválida! ");
        }
        else if (dataNasc.mes == 04 || dataNasc.mes == 06 || dataNasc.mes == 09 || dataNasc.mes == 11 && dataNasc.dia >= 31)
        {
            Console.WriteLine("Data Inválida! ");
        }
        else if (dataNasc.mes == 02 && dataNasc.dia > 28)
        {
            Console.WriteLine("Data Inválida! ");

        }
        else
        {

            Console.Write("\n\nData de Nascimento informada: ");
            Console.WriteLine("{0}/{1}/{2} \n\n", dataNasc.dia, dataNasc.mes, dataNasc.ano);
        }
        Console.ReadKey();
    }
}