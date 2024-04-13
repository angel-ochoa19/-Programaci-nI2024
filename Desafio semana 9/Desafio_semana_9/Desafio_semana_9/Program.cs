using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Pedir al usuario que ingrese el texto
        Console.WriteLine("Ingrese un texto que contenga direcciones de correo electrónico:");
        string texto = Console.ReadLine();

        // Validar si el usuario ingresó algún texto
        if (string.IsNullOrEmpty(texto))
        {
            Console.WriteLine("No ingresaste ningún texto.");
            return;
        }

        // Definir la expresión regular para encontrar direcciones de correo electrónico
        // Esta expresión regular es más precisa y puede manejar casos más complejos
        string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        // Buscar coincidencias usando la expresión regular
        MatchCollection coincidencias = Regex.Matches(texto, patron);

        // Verificar si se encontraron direcciones de correo electrónico
        if (coincidencias.Count == 0)
        {
            Console.WriteLine("No se encontraron direcciones de correo electrónico en el texto ingresado.");
            return;
        }

        // Mostrar las direcciones de correo electrónico encontradas
        Console.WriteLine("\nDirecciones de correo electrónico encontradas:");
        foreach (Match coincidencia in coincidencias)
        {
            Console.WriteLine(coincidencia.Value);
        }
    }
}