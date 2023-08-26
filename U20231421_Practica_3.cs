using System;
using System.Runtime.CompilerServices;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
        //Declaración de variable
        string? Marca_Zapato;
        string? Color_Zapato;
        int Cantidad_Zapato;
        double Precio;

        //Captura datos
        Console.WriteLine("\n-------CAPTURANDO VARIABLES-----");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Ingrese la marca del Zapato a comprar:  ");
        Marca_Zapato = Convert.ToString(Console.ReadLine());

        Console.WriteLine("\nIngrese el color del par Zapato a comprar: ");
        Color_Zapato = Convert.ToString(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nIngrese la cantidad de pares de zapatos a comprar: ");
        Cantidad_Zapato = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nIngrese el precio del par de zapatos a comprar: ");
        Precio = Convert.ToDouble(Console.ReadLine());
        Console.ResetColor();
        Console.WriteLine("-------FIN DE CAPTURACIÓN VARIABLES-----");

        //Capturando el total a pagar
        double Total = Cantidad_Zapato * Precio;


        //Impriendo resultado
        Console.WriteLine("\n--------IMPRIMIENDO RESULTADOS-------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("La marca de zapatos a comprar es: " + Marca_Zapato);
        Console.WriteLine("\nEl color de zapatos a comprar es: " + Color_Zapato);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nLa catidad de pares de zapatos a comprar es: " + Cantidad_Zapato);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nEl precio a pagar por los pares de zapatos es: " + Precio);
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nTotal a pagar por la compra es: " + Total);
        Console.ResetColor();
        Console.WriteLine("\n-------FIN DE IMPRIMIR RESULTADOS------\n");
        }
    }
}
