using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_Unicornio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma palavra:");

            string palavra = Console.ReadLine();



            

            {
                Console.WriteLine("Toda a Palavra: {0}", palavra);


                char primeiro = palavra[0];

                Console.WriteLine($"O primeiro caractere da palavra é: {primeiro}");

                char ultimoCaractere = palavra[palavra.Length - 1];

                Console.WriteLine($"Ultimo caractere da plavra é: {ultimoCaractere}");


                string paot = palavra.Substring(0,3);
                Console.WriteLine("Do primeiro ao terceiro caractere: " + paot);

                char quarto = palavra[3];

                Console.WriteLine($"O quarto caractere da palavra é: {quarto}");

                string todasMenosPrimeira = palavra.Substring(1);
                Console.WriteLine("Todas as letras exceto a primeira: " + todasMenosPrimeira);

                string doisultimos = palavra.Substring(palavra.Length - 2);
                
                Console.WriteLine($"Dois Ultimo caractere da plavra é: {doisultimos}");

                Console.ReadLine();



            }

           

                Console.WriteLine("A palavra está vazia.");
        }
    }    }
