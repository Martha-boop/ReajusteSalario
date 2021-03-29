using System;

namespace ReajusteSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double novosalario = 0;

            Console.WriteLine("Efetue o reajuste do sálarial!");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe o sálario:");
                salario = int.Parse(Console.ReadLine());
                if(salario <= 300)
                { // 50 %
                    novosalario = salario * 1.50;

                }
                else
                { // 30%
                    novosalario = salario + ((salario * 30) / 100);

                }
                Console.WriteLine("Salario reajustado:" + novosalario);
            }
            Console.ReadLine();
        }
    }
}
