using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Aguia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nAtividade 1\n");
            int i_tab = 0;
            Console.Write("Digite uma Variável e para definir a tabuada:");
            i_tab = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} x 1 = {1}", i_tab, i_tab * 1 );
            Console.WriteLine("{0} x 2 = {1}", i_tab, i_tab * 2 );
            Console.WriteLine("{0} x 3 = {1}", i_tab, i_tab * 3 );
            Console.WriteLine("{0} x 4 = {1}", i_tab, i_tab * 4 );
            Console.WriteLine("{0} x 5 = {1}", i_tab, i_tab * 5 );
            Console.WriteLine("{0} x 6 = {1}", i_tab, i_tab * 6 );
            Console.WriteLine("{0} x 7 = {1}", i_tab, i_tab * 7 );
            Console.WriteLine("{0} x 8 = {1}", i_tab, i_tab * 8 );
            Console.WriteLine("{0} x 9 = {1}", i_tab, i_tab * 9 );
            Console.WriteLine("{0} x 10 = {1}", i_tab, i_tab * 10 );
            Console.ReadLine();


            Console.WriteLine("\n\nAtividade 2\n");
            int i_laud = 0;
            Console.Write("Quantidade de Laudas:");
            i_laud = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor Total: R${0}", i_laud  * 50);
            int i_total = i_laud *50;
            Console.WriteLine("Valor Parcelado: R${0}", i_total /3);
            Console.ReadLine();


            Console.WriteLine("\n\nAtividade 3\n");
            string s_nome = "";
            Console.Write("Digite seu Nome:");
            s_nome = (Console.ReadLine());
            Console.WriteLine("Boas Vindas,{0}", s_nome);
            Console.WriteLine("Tecle Enter para finalizar");
            


            Console.ReadLine();


        }
    }
}
