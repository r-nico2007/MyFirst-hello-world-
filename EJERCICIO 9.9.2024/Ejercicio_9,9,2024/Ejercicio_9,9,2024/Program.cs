using System;

public class Program
    // Construir un programa que pida por pantalla 3 numeros 
// y luego diga cual es el mayor, el del medio y el menor de los 
//numeros ingresados 
{
    private static void Main(string[] args)
    {
        double num1, num2, num3;
        bool esmayor;

        Console.Write("Ingrese el primer numero: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        num2 = Convert.ToDouble(Console.ReadLine());


        Console.Write("Ingrese el tercer numero: ");
        num3 = Convert.ToDouble(Console.ReadLine());

        if (((num1 > num2) && (num1 > num3)))
        {
            esmayor = true;

        }
        else
        {
            esmayor = false;
        }
        if (esmayor)
        {
            Console.Write("Numero 1 es el mayor");
        }
        else
        {
            Console.Write("Numero 1 no es el mayor");
        }    
        
    }

    }
