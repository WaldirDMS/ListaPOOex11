using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPOOex11
{
    class Peso
    {
        private double altura;
        private double peso;
        private double imc;

        public void setPeso(double p)
        {
            peso = p;
        }

        public void setAltura(double p)
        {
            altura = p;
        }

        public void calcularImc()
        {
            imc = (altura / (peso * peso));

            if (imc < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }

            else
            {
                if (imc >= 25)
                {
                    Console.WriteLine("Acima do peso");
                }

                else
                {
                    Console.WriteLine("Peso ideal");
                }
            }
        }
    }
}
