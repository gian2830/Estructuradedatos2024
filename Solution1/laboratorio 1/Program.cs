// See https://aka.ms/new-console-template for more information
using System;

class Calculadora
{
    static void Main()
    {
        // Solicitar los dos números al usuario
        Console.Write("Ingresa el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Realizar las operaciones aritméticas
        double suma = num1 + num2;
        double resta = num1 - num2;
        double multiplicacion = num1 * num2;
        double division;

        // Imprimir los resultados
        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Suma: {num1} + {num2} = {suma}");
        Console.WriteLine($"Resta: {num1} - {num2} = {resta}");
        Console.WriteLine($"Multiplicación: {num1} * {num2} = {multiplicacion}");

        // Manejar la división por cero
        if (num2 != 0)
        {
            division = num1 / num2;
            Console.WriteLine($"División: {num1} / {num2} = {division}");
        }
        else
        {
            Console.WriteLine($"División: No se puede dividir por cero.");
        }
    }
}