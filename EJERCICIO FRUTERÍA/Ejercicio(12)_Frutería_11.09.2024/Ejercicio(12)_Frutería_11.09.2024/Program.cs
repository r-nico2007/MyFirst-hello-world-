public class Program
{
    private static void Main(string[] args)
    {
        const decimal PrecioKilosManzanas = 5000;
        double descuento;
        
        //Una frutería ofrece las manzanas con descuento según la siguiente tabla:
        //Determinar el precio del kilo de manzana como desarrollador. Determinar y mostrar cuanto pagará una persona que compre manzanas es esa frutería y cuál descuento fue el que se aplicó, si fué que se aplicó alguno

        //Datos de entrada: Cantidad de kilos de manzana
        //proceso: Calcular el valor neto de manzanas y aplicar su respectivo descuento
        //Datods de salida: Valor total y descuento aplicado
        Console.Write("Ingrese la cantidad de kilos de manzanas a comprar: ");
        double KilosManzanas = Convert.ToDouble(Console.ReadLine());

        //Cálculos

        if (KilosManzanas >= 0 && KilosManzanas <= 2)
        {
            descuento = 0;
        }
        else if (KilosManzanas > 2 && KilosManzanas <= 5)
        {
            descuento = 10;
        }
        else if (KilosManzanas > 5 && KilosManzanas <= 10)
        {
            descuento = 15;
        }
        else
        {
            descuento = 20;
        }
        
        //Cálculo del precio bruto
    }
}