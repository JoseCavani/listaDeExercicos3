using System;

namespace listaDeExercicos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sucesso;
            float[] altura = new float[15];
            for (int s = 0; s < altura.Length; s++)
            {
                Console.WriteLine("digite a altura da pessoa " + (s + 1));
            volta1:
                sucesso = float.TryParse(Console.ReadLine(), out altura[s]);
                if (sucesso == false)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("valor invalido tente novamente");
                    Console.ResetColor();
                    goto volta1;
                }
            }
            Array.Sort(altura);
            Console.WriteLine("mais alto : " + altura[14] + "\nmais baixo : " + altura[0]);
            Console.ReadKey();
        }
    }
}
