using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese las calificaciones del alumno, una por una. Ingrese 'fin' para terminar.");
        double suma = 0;
        int contador = 0;
        string input;
        while (true)
        {
            input = Console.ReadLine();
            if (input.ToLower() == "fin")
            {
                break;
            }
            int calificacion;
            if (int.TryParse(input, out calificacion) && calificacion >= 1 && calificacion <= 10)
            {
                suma += calificacion;
                contador++;
            }
            else
            {
                Console.WriteLine("Error: La calificación ingresada no es válida. Por favor, ingrese una calificación entre 1 y 10.");
            }
        }
        if (contador > 0)
        {
            double promedio = suma / contador;
            Console.WriteLine($"El promedio del alumno es: {promedio}");
        }
        else
        {
            Console.WriteLine("Error: No se ingresaron calificaciones válidas.");
        }
    }
}