using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            string altura;
            string peso;
            
            double altura1;
            double peso1;
            
            double soma;
            double somatoria;
            double somatotal;
            
            
            Console.WriteLine("Calcule a massa corporal de uma pessoa");
            Console.WriteLine("Digite a altura");
            altura = Console.ReadLine();
            Console.WriteLine("Digite o peso");
            peso = Console.ReadLine();

            altura1 = Convert.ToDouble(altura);
            peso1 = Convert.ToDouble(peso);

            soma = peso1 / altura1;
            somatoria = Math.Pow(altura1, 2);
            somatotal = peso1 / somatoria;
            
            Console.WriteLine($"Indice corporal é {somatotal},0Kg/m²");

            

        }
    }
}
