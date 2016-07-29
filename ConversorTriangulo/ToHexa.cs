using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTriangulo
{
    class ToHexa
    {
        public static string paraHexa(int num)
        {
            int numero = num;
            int divisor = 16;

            List<int> Result = new List<int>();
            StringBuilder binario = new StringBuilder();

            string hexaFinal;

            while (num != 0)
            {
                Result.Add(num % divisor);
                num = num / divisor;
            }

            foreach (int item in Result)
            {
                binario.Append(item);
            }

            hexaFinal = Reverter.ReverseString(binario.ToString());
            hexaFinal = hexaFinal.Replace("01", "A")
                .Replace("11", "B")
                .Replace("21", "C")
                .Replace("31", "D")
                .Replace("41", "E")
                .Replace("51", "F");


            return hexaFinal;
        }
    }
}
