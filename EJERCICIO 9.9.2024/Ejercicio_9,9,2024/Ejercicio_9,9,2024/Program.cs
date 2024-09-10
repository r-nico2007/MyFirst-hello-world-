using System;
using System.ComponentModel.Design;

public class Program
// Construir un programa que pida por pantalla 3 numeros 
// y luego diga cual es el mayor, el del medio y el menor de los 
//numeros ingresados 
{
    private static void Main(string[] args)
    {
        double num1, num2, num3;
        bool esmayor, esintermedio, esmenor;

        Console.Write("Ingrese el primer numero: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        num2 = Convert.ToDouble(Console.ReadLine());


        Console.Write("Ingrese el tercer numero: ");
        num3 = Convert.ToDouble(Console.ReadLine());


        if (((num1 > num2) && (num1 > num3)))
        {
            if (num2 > num3)
            {
                Console.Write("Numero 1 es el mayor, numero 2 es el intermedio y número 3 es el menor.");
            }
            else
            {
                Console.Write("Numero 1  es el mayor, numero 3 es el intermedio y numero 2 es el menor");
            }
        }
        else if (num2 > num3) && (num1 > num3)))
                { 
    }
}








