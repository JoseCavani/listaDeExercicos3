using System;

namespace exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = 1;
            bool sucesso;
            Console.WriteLine("digite numero ");
        volta1:
            sucesso = int.TryParse(Console.ReadLine(), out int numero);
            if (sucesso == false)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("valor invalido tente novamente");
                Console.ResetColor();
                goto volta1;
            }
            Console.Clear();
            for (int i = numero; i > 0; i--)
            {
            
                  
                if (i != 1)
                    Console.Write(i + "*");
                else
                    Console.Write(i);
                resultado = i * resultado;
            }
            Console.Write(" = ");
          Console.Write(resultado);
            Console.ReadKey();
        }
    }
}
