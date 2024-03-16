﻿using System;
using System.Collections.Generic;

public class Box
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateVolume()
    {
        return Length * Width * Height;
    }
}

class Program
{
    static void Main()
    {
        List<Box> boxes = new List<Box>();

        Console.Write("Ingrese la cantidad de cajas: ");
        int numBoxes = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numBoxes; i++)
        {
            Console.WriteLine($"Ingrese las dimensiones de la caja {i + 1}:");
            Console.Write("Largo: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ancho: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Alto: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Box box = new Box { Length = length, Width = width, Height = height };
            boxes.Add(box);

        }
        double totalVolume = 0;
        foreach (var box in boxes)
        {
            totalVolume += box.CalculateVolume();
        }

        double averageVolume = totalVolume / numBoxes;

        Console.WriteLine($"Total de volumen de las cajas: {totalVolume}");
        Console.WriteLine($"Volumen promedio de las cajas: {averageVolume}");


    }
}
//En este programa, se crea una lista de objetos Box donde se almacenarán las dimensiones de cada caja ingresada por el usuario. 
//Luego, se utiliza un bucle foreach para calcular el total de volumen sumando los volúmenes de cada caja, y finalmente se calcula
//el volumen promedio dividiendo el total de volumen entre la cantidad de cajas   .
//Al ejecutar este programa, el usuario podrá ingresar la cantidad de cajas y las dimensiones de cada una, y el programa 
//calculará el total de volumen y el volumen promedio de todas las cajas ingresadas.