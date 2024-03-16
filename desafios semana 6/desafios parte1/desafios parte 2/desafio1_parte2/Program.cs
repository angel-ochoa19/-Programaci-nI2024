using System;

public class Rectangulo
{
    private readonly double Alto;
    private readonly double Largo;

    public Rectangulo(double alto, double largo)
    {
        Alto = alto;
        Largo = largo;
    }

    public double SuperficieFrontal
    {
        get
        {
            return Alto * Largo;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangulo rectangulo = new Rectangulo(5, 10);
        Console.WriteLine("La superficie frontal del rectángulo es: " + rectangulo.SuperficieFrontal);
    }
}
