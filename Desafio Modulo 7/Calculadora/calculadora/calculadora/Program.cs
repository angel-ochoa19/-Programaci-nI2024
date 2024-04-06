using System;

public class Calculadora
{
    public string Marca { get; set; }
    public string Serie { get; set; }

    public double Sumar(double a, double b)
    {
        return a + b;
    }

    public double Restar(double a, double b)
    {
        return a - b;
    }

    public double Multiplicar(double a, double b)
    {
        return a * b;
    }

    public double Dividir(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException();
        }
        return a / b;
    }
}

public class CalculadoraCientifica : Calculadora
{
    public double Potencia(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public double Raiz(double a)
    {
        return Math.Sqrt(a);
    }

    public double Modulo(double a, double b)
    {
        return a % b;
    }

    public double Logaritmo(double a)
    {
        return Math.Log(a);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        CalculadoraCientifica calcCientifica = new CalculadoraCientifica();

        // Aquí puedes usar los métodos de las instancias creadas
        Console.WriteLine("Suma: " + calc.Sumar(5, 3));
        Console.WriteLine("Resta: " + calc.Restar(5, 3));
        Console.WriteLine("Multiplicación: " + calc.Multiplicar(5, 3));
        Console.WriteLine("División: " + calc.Dividir(5, 3));

        Console.WriteLine("Potencia: " + calcCientifica.Potencia(5, 3));
        Console.WriteLine("Raíz: " + calcCientifica.Raiz(9));
        Console.WriteLine("Módulo: " + calcCientifica.Modulo(5, 3));
        Console.WriteLine("Logaritmo: " + calcCientifica.Logaritmo(10));
    }
}