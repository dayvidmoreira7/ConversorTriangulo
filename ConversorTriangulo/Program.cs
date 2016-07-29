using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Decimal");
            string numero = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Seu Decimal: " + numero);
            Console.WriteLine("");
            Console.WriteLine("Seu Binário: " + ToBinary.paraBinario(int.Parse(numero)));
            Console.WriteLine("");
            Console.WriteLine("Seu Hexadecimal: " + ToHexa.paraHexa(int.Parse(numero)));
            Console.ReadKey();
        }
    }
}
