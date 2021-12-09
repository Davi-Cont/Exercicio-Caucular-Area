using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string forma;
            double area, lado, tam_base, tam_base1, altura, diag_maior, diag_menor;
            

            Console.WriteLine("Informe a forma desejada (Quadrado, Retangulo, Trapezio ou Losango)");
            forma = Console.ReadLine().ToUpper();

           

            switch (forma)
            {
                case "QUADRADO":
                    Console.WriteLine("Infome o tamanho de um dos lados em cm");
                    lado = double.Parse(Console.ReadLine());
                    
                    area = lado * lado;
                    Console.WriteLine("A area do quadrado é: " + area);
                    break;


                case "RETANGULO":
                    Console.WriteLine("Informe o tamanho da base em cm");
                    tam_base = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a altura em cm");
                    altura = double.Parse(Console.ReadLine());

                    area = tam_base * altura;
                    Console.WriteLine("A area do retangulo é: " + area);
                    break;


                case "TRAPEZIO":
                    Console.WriteLine("Informe o tamanho da base menor em cm");
                    tam_base = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o tamanho da base maior em cm");
                    tam_base1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a altura em cm");
                    altura = double.Parse(Console.ReadLine());

                    area = (tam_base + tam_base1) * altura / 2;
                    Console.WriteLine("A area do trapezio é: " + area);
                    break;


                case "LOSANGO":
                    Console.WriteLine("Informe a medida da diagonal maior em cm");
                    diag_maior = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a medida da diagonal menor em cm");
                    diag_menor = double.Parse(Console.ReadLine());

                    area = diag_maior * diag_menor / 2;
                    Console.WriteLine("A area do losango é: " + area);
                    break;

                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }

            Console.ReadKey();




        }
    }
}
