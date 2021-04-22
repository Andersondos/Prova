using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fim = false;
            List<int> resultadoCalculo = new List<int>();

            Console.WriteLine("Informe um numero positivo");
            int numero  = Convert.ToInt32(Console.ReadLine());
            if(numero < 1) Console.WriteLine("Informe um numero maior que 0");
            
            resultadoCalculo.Add(numero);
            while(fim == false)
            {
                if(numero % 2 == 0)
                {
                    numero = numero / 2;
                    resultadoCalculo.Add(numero);
                }
                else
                {
                    numero = 3 * numero + 1;
                    resultadoCalculo.Add(numero);
                }

                fim = numero == 1 ? true: false;
            }
                int[] resultadoFinal = new int[resultadoCalculo.Count];
                foreach (var x in resultadoCalculo.Select((value, index) => new { value, index }))
                {
                    resultadoFinal[x.index] = x.value;
                }
                Console.WriteLine(string.Join(" -> ", resultadoFinal));
        }
    }
}