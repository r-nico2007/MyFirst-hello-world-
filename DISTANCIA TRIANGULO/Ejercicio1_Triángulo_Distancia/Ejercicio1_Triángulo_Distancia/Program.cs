public class Program
{
    private static void Main(string[] args)
    {
        //Lea la longitud de tres segmentos y que muestre si se puede construir un triangulo.

        //declaracion de los datos de entrada (inputs)
        double seg1, seg2, seg3;
        bool isTriangle;
        string msj;

        //pedir los datos
        Console.Write("Ingrese el primer segmento: ");
        seg1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo segmento: ");
        seg2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el tercer segmento: ");
        seg3 = Convert.ToDouble(Console.ReadLine());

        //Proceso - validación
        if ((seg1 + seg2) > seg3)
        {
            if ((seg1 + seg3) > seg2)
            {
                if ((seg2 + seg3) > seg1)
                {
                    isTriangle = true;
                }
                else
                {
                    isTriangle = false;
                }
            }
            else
            {
                isTriangle=false;
            }

        }
        else
        {
            isTriangle = false;
        }
        if (((seg1 + seg2) > seg3) && ((seg1 + seg3) > seg2 && ((seg2 + seg3) > seg1)))
        {
            isTriangle = true;
        }
        else
        {
            isTriangle = false;
        }

        //Mostrar output (mensaje)
        if (isTriangle)
        {
            Console.Write("Se puede construir el triangulo.");
        }
        else
        {
            Console.Write("No se puede construir el triangulo.");
        }


    }
}