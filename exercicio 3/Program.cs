using System;

namespace exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            for (int i = 1; i < 501; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    valor += i;
                }
            }
            Console.Write(valor);
            Console.ReadKey();
        }
    }
}

