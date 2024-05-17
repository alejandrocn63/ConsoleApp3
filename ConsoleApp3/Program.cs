using System;
namespace ConsoleApp3
{
    class Program
    {
        static bool EsPrimo(int numero)
        {
            if (numero <= 1) 
                return false; // Los números menores o iguales a 1 no son primos
                              // Solo verifica hasta la raíz cuadrada del número
            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    return false; // Si es divisible, no es un número primo
                }
            }
            return true; // Si no se encuentran divisores, es un número primo
        }
        static void Main(string[] args)
        {
            // Solicita al usuario que ingrese un número
            Console.WriteLine("Ingrese el número: ");

            // Intenta convertir la entrada del usuario a un entero
            int numero;
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                // Verifica si el número es primo y muestra el resultado
                if (EsPrimo(numero))
                    Console.WriteLine($"{numero} es un número primo.");
                else
                    Console.WriteLine($"{numero} no es un número primo.");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero válido.");
            }
        }
    }
}