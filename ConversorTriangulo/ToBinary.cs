using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTriangulo
{
    class ToBinary
    {
        public static string paraBinario(int num)
        {
            int numero = num;
            int divisor = 2;

            List<int> Result = new List<int>();
            StringBuilder binario = new StringBuilder();

            string binarioFinal;

            while (num != 0)
            {
                Result.Add(num % divisor);
                num = num / divisor;
            }

            foreach (int item in Result)
            {
                binario.Append(item);
                //    Console.Write(item.ToString());
            }

            binarioFinal = Reverter.ReverseString(binario.ToString());

            return binarioFinal;
        }
    }
}
