using System;

namespace ExercicioIMC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool op = true;

            while (op)
            {
                Console.Clear();
                Pessoa pessoa = new Pessoa();

                Console.Write("Informe seu peso atual: ");
                pessoa.peso = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Informe sua Altura: ");
                pessoa.altura = double.Parse(Console.ReadLine());
                Console.WriteLine();

                pessoa.imprimirMessage();

                Console.WriteLine("Deseja realizar outra avaliação? [S/N]");

                if (Console.ReadLine().ToUpper() == "N")
                {
                    op = false;
                }
            }
        }
    }
}
