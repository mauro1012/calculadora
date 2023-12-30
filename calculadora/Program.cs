using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
            Console.WriteLine("ingrese la cantidad de numeros que desea ingresar");
            int count = int.Parse(Console.ReadLine());

            double[] numero = new double[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Ingrese el numero {0}:", i + 1);
                numero[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Los numeros ingresadas son:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(numero[i]);
            }
        
            if (count > 1)
            {
                Console.WriteLine("Eliga la operación que desee ejecutar\n1.suma" +
        "\n2.resta" +
        "\n3.multiplicacion" +
        "\n4.divicion" +
        "\n5.salir");
                string ops = Console.ReadLine();
                double result = 0;
                switch (ops)
                {
                    case "1":
                        double sum = numero.Sum();
                        Console.WriteLine("La suma de los números ingresados es {0}.", sum);
                        break;
                    case "2":
                        result = numero.Aggregate((a, b) => a - b);
                        Console.WriteLine("La resta de los números ingresados es {0}.", result);
                        break;
                    case "3":
                        result = numero.Aggregate((a, b) => a * b);
                        Console.WriteLine("La multiplicacion de los números ingresados es {0}.", result);
                        break;
                    case "4":
                        result = numero.Aggregate((a, b) => a / b);
                        Console.WriteLine("La divicion de los números ingresados es {0}.", result);
                        break;
                }


            }
            else
            {
                Console.WriteLine("para realizar las operaciones se neceesitan mas de 1 numero");

            }
              
    }
}
