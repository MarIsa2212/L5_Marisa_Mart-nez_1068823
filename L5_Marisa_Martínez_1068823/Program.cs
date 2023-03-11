using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

namespace L5_Marisa_Martínez_1068823
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            Console.Write("Ingrese un número entero: ");

            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    Console.WriteLine("El número es cero");
                }
                else if (x > 0)
                {
                    Console.WriteLine("El número es positivo");
                }
                else
                {
                    Console.WriteLine("El número es negativo");
                }
            }
            catch (Exception ex) //exception es un tipo de dato, se esta declarando la variable ex
            {
                Console.WriteLine("No ingreso un número " + ex.Message);

            }
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Ingrese un número según el día de la semana: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0 && num > 7)
            {
                Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7");
            }
            else
            {
                Console.WriteLine("Número valido");
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Martes");
                        break;
                    case 3:
                        Console.WriteLine("Miércoles");
                        break;
                    case 4:
                        Console.WriteLine("Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Sábado");
                        break;
                    case 7:
                        Console.WriteLine("Domingo");
                        break;
                }

            }

        }
    }
}