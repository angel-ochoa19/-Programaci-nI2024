using System;

class CuentaBancaria
{
    private double saldo;

    public CuentaBancaria(double saldoInicial) => saldo = saldoInicial;

    public double ObtenerSaldo() => saldo;

    public void Depositar(double cantidad)
    {
        if (cantidad > 0) { saldo += cantidad; Console.WriteLine($"Depósito exitoso. Nuevo saldo: {saldo:C}"); }
        else Console.WriteLine("La cantidad a depositar debe ser mayor que cero.");
    }

    public void Retirar(double cantidad)
    {
        if (cantidad > 0 && cantidad <= saldo) { saldo -= cantidad; Console.WriteLine($"Retiro exitoso. Nuevo saldo: {saldo:C}"); }
        else if (cantidad > saldo) Console.WriteLine("Fondos insuficientes.");
        else Console.WriteLine("La cantidad a retirar debe ser mayor que cero.");
    }
}

class Program
{
    static void Main()
    {
        double saldoInicial;
        Console.Write("Ingrese el saldo inicial de la cuenta: ");
        while (!double.TryParse(Console.ReadLine(), out saldoInicial) || saldoInicial < 0)
            Console.Write("Ingrese un valor válido para el saldo inicial: ");

        CuentaBancaria cuenta = new CuentaBancaria(saldoInicial);

        int opcion;
        do
        {
            MostrarMenu();
            opcion = int.Parse(Console.ReadLine());

            RealizarAccion(opcion, cuenta);

        } while (opcion != 4);
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\n--- Menú ---\n1. Verificar saldo disponible\n2. Depositar dinero\n3. Retirar dinero\n4. Salir");
        Console.Write("Ingrese su opción: ");
    }

    static void RealizarAccion(int opcion, CuentaBancaria cuenta)
    {
        switch (opcion)
        {
            case 1: Console.WriteLine($"Saldo disponible: {cuenta.ObtenerSaldo():C}"); break;
            case 2: RealizarTransaccion("Ingrese la cantidad a depositar: ", cuenta.Depositar); break;
            case 3: RealizarTransaccion("Ingrese la cantidad a retirar: ", cuenta.Retirar); break;
            case 4: Console.WriteLine("¡Hasta luego!"); break;
            default: Console.WriteLine("Opción no válida."); break;
        }
    }

    static void RealizarTransaccion(string mensaje, Action<double> accion)
    {
        Console.Write(mensaje);
        double cantidad = double.Parse(Console.ReadLine());

        if (cantidad < 0) Console.WriteLine("Ingrese una cantidad válida: ");
        else accion(cantidad);
    }
}