using System;

namespace ListaPOOex11
{

    class Program
    {
        static void Main(string[] args)
        {
            Peso peso;

            peso = new Peso();

            Console.Write("Informe o peso: ");
            peso.setPeso(double.Parse(Console.ReadLine()));

            Console.Write("Informe a altura: ");
            peso.setAltura(double.Parse(Console.ReadLine()));

            peso.calcularImc();
        }
    }
}

