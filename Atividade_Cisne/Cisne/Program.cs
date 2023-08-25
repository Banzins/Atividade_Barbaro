using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Cisne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Exercício 1\n");
            int i_nro1 = 0, i_nro2 = 0;
            Console.Write("Digite um Numero Inteiro: ");
            i_nro1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro Numero Inteiro: ");
            i_nro2 = int.Parse(Console.ReadLine());
            Console.Write("Soma: {0}", i_nro1 + i_nro2);
            Console.ReadLine();


            Console.WriteLine("\n\nExercício 2 \n");
            double d_nro1 = 0;

            Console.Write("Digite um Numero real: ");
            d_nro1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("A terça parte é {0}", d_nro1 / 3);
            Console.ReadLine();


            Console.WriteLine("\n\nExercício 3 \n");

            d_nro1 = 0;
            double d_nro2 = 0;
            Console.Write("Digite o 1º Numero real: ");
            d_nro1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o 2º Numero real: ");
            d_nro2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Média: {0}", (d_nro1 + d_nro2) / 2);
            Console.ReadLine();


            Console.WriteLine("\n\nExercício 4 \n");

            double i_nro6 = 0;
            Console.Write("Digite seu saldo: R$ ");
            i_nro6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("O saldo com Reajuste de 1%: {0:c}", i_nro6 * 1.01);
            Console.ReadLine();


            Console.WriteLine("\n\nExercício 5 \n");

            d_nro1 = 0;
            d_nro2 = 0;
            double d_nro3 = 0;
            double d_nro4 = 0;
            Console.WriteLine("Digite a 1º nota:");
            d_nro1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a 2º nota:");
            d_nro2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a 3º nota:");
            d_nro3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a 4º nota:");
            d_nro4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Média: {0}", ((d_nro1 + d_nro2) + (d_nro3 + d_nro4)) / 4);
            Console.ReadLine();
        }
    }
}
