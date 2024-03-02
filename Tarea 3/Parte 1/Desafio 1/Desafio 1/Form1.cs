using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {

        // Add a listener for debug output
        TextWriterTraceListener listener = new TextWriterTraceListener(Console.Out);
        Debug.Listeners.Add(listener);

        // Solicitar nombre del usuario
        Console.Write("Ingrese su nombre: ");
        string nombreUsuario = Console.ReadLine();


        // Solicitar ingresos de los últimos 3 meses
        Console.Write("Ingrese ingresos del mes 1: ");
        double ingresoMes1;
        while (!double.TryParse(Console.ReadLine(), out ingresoMes1))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
        }

        Console.Write("Ingrese ingresos del mes 2: ");
        double ingresoMes2;
        while (!double.TryParse(Console.ReadLine(), out ingresoMes2))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
        }

        Console.Write("Ingrese ingresos del mes 3: ");
        double ingresoMes3;
        while (!double.TryParse(Console.ReadLine(), out ingresoMes3))
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
        }

        // Calcular la suma y el promedio
        double sumaIngresos = ingresoMes1 + ingresoMes2 + ingresoMes3;
        double promedioIngresos = sumaIngresos / 3;

        // Imprimir el mensaje
        Console.WriteLine($"Hola {nombreUsuario}, en total ganaste ${sumaIngresos} y promediaste ${promedioIngresos}.");
    }
}