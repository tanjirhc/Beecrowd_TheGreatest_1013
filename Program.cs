using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_TheGreatest_1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int A = Convert.ToInt32(valores[0]);
            int B = Convert.ToInt32(valores[1]);
            int C = Convert.ToInt32(valores[2]);

            int maiorAB = (A + B + Math.Abs(A - B)) / 2;
            int maiorMaiorC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine($"{maiorMaiorC} eh o maior");
            Console.ReadKey();
        }
    }
}
