using System;

namespace CalculoDescuentoClientes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ejemplo de uso
            double[][] montosCompras = new double[5][];
            for (int cliente = 0; cliente < 5; cliente++)
            {
                montosCompras[cliente] = new double[5];
                for (int compra = 0; compra < 5; compra++)
                {
                    Console.Write($"Ingresa el monto de la compra {compra + 1} para el cliente {cliente + 1}: ");
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out double monto))
                    {
                        montosCompras[cliente][compra] = monto;
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Inténtalo de nuevo.");
                        compra--; // Repetir la entrada para la misma compra
                    }
                }
            }
            CalcularDescuento(montosCompras);
        }
        //Aplicar descuento
        static void CalcularDescuento(double[][] montosCompras)
        {
            for (int cliente = 0; cliente < montosCompras.Length; cliente++)
            {
                double totalCompras = 0;

                // Calcular el total de compras para el cliente actual
                foreach (double compra in montosCompras[cliente])
                {
                    totalCompras += compra;
                }

                // Aplicar descuento según las reglas
                double descuento = 0;
                if (totalCompras >= 100 && totalCompras <= 1000)
                {
                    descuento = totalCompras * 0.1;
                }
                else if (totalCompras > 1000)
                {
                    descuento = totalCompras * 0.2;
                }
                static void MostrarInstrucciones()
                {
                    Console.WriteLine("1.Para cada cliente, ingresa los montos de las últimas 5 compras cuando se te solicite.");
                    Console.WriteLine("2.Si ingresas un valor no válido, se te pedirá que lo intentes nuevamente.\r\n");
                    Console.WriteLine("3.El programa calculará el total de compras y aplicará el descuento según las reglas especificadas.");
                    Console.WriteLine("4.Verás los resultados en la consola.");
                }
                // Mostrar resultados
                Console.WriteLine($"Cliente {cliente + 1}: Total de compras = {totalCompras:C}, Descuento = {descuento:C}");
            }
        }
    }
}