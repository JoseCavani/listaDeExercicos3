using System;

namespace exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(numero + "*" + i + "=" + numero*i);
            }
            Console.ReadKey();
        }
    }
}
