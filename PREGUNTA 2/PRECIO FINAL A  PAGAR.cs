// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int P;
        double precio, subtotal = 0, IGV, total;

        // Ingrese la cantidad de productos a comprar
        Console.WriteLine("Ingrese el número de productos a comprar:");
        P = int.Parse(Console.ReadLine());

        // Hallar el subtotal
        for (int x = 1; x <= P; x++)
        {
            Console.WriteLine($"Ingrese el precio del producto a comprar {x}:");
            precio = double.Parse(Console.ReadLine());
            subtotal += precio;
        }

        // Hallar IGV y total
        IGV = subtotal * 0.18;
        total = subtotal + IGV;

        // Resultados obtenidos
        Console.WriteLine($"Subtotal: {subtotal}");
        Console.WriteLine($"IGV (18%): {IGV}");
        Console.WriteLine($"Total a pagar: {total}");
    }
}