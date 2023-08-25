using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Coruja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nExercício 1\n");
            int i_nmr1 = 0;
           
            Console.Write("Digite um Número:");
            i_nmr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sucessor: {0}", i_nmr1 + 1);
            Console.WriteLine("Antecessor: {0}", i_nmr1 - 1);
            Console.ReadLine();


            Console.WriteLine("\n\nExercício 2\n");

            string s_en = "";
            string s_nm = "";
            string s_tl = "";
            Console.Write("Digite seu Nome:");
            s_nm = Console.ReadLine();
            Console.Write("Digite seu Endereço:");
            s_en = Console.ReadLine();
            Console.Write("Digite seu Telefone:");
            s_tl = Console.ReadLine();
            Console.WriteLine("Nome: {0} \nEndereço: {1} \nTelefoe: {2}",s_nm, s_en, s_tl);
            Console.ReadLine();


            Console.WriteLine("\n\nExercício 3\n");

            i_nmr1 = 0;
            int i_nmr2 = 0;
            Console.Write("Digite seu 1° Número:");
            i_nmr1 = int.Parse(Console.ReadLine());
            Console.Write("Digite seu 2° Número:");
            i_nmr2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Soma:{0}\n Subtração:{1}\n Multiplicação:{2}\n", i_nmr1 + i_nmr2 , i_nmr1 - i_nmr2 , i_nmr1 * i_nmr2);           
            Console.ReadLine();


            Console.WriteLine("\n\nExercício 4\n");

            double d_ps = 0;
            double d_al = 0;
            Console.Write("Digite seu Peso: KG");
            d_ps = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua Altura: ");
            d_al = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("IMC:{0} ", d_ps / (d_al*2));
            Console.ReadLine();


        }


    }
    
}

