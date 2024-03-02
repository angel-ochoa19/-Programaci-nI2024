using System;

class Program
{
    static void Main()
    {
        double suma = 0;
        int contador = 0;
        double numero;

        Console.WriteLine("Ingrese números (ingrese 0 para terminar):");

        while (true)
        {
            Console.Write("Ingrese un número: ");
            if (!double.TryParse(Console.ReadLine(), out numero) || numero == 0)
            {
                break;
            }

            suma += numero;
            contador++;
        }

        if (contador == 0)
        {
            Console.WriteLine("No se ingresaron números.");
        }
        else
        {
            double promedio = suma / contador;
            Console.WriteLine($"La suma de los números ingresados es: {suma:F2}");
            Console.WriteLine($"El promedio de los números ingresados es: {promedio:F2}");
        }
    }
}