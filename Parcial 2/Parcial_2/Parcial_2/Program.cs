using System;
using System.Collections.Generic;
using System.Windows;
System.Windows.MessageBox

using static System.Net.Mime.MediaTypeNames;

namespace CalculadoraCientificaWPF
{
    // Clase base Calculadora
    public class Calculadora
    {
        public double Resultado { get; protected set; }

        public virtual double Sumar(double a, double b)
        {
            Resultado = a + b;
            return Resultado;
        }

        public virtual double Restar(double a, double b)
        {
            Resultado = a - b;
            return Resultado;
        }

        public virtual double Multiplicar(double a, double b)
        {
            Resultado = a * b;
            return Resultado;
        }

        public virtual double Dividir(double a, double b)
        {
            if (b != 0)
            {
                Resultado = a / b;
                return Resultado;
            }
            else
            {


                System.Windows.MessageBox.Show("Error: División por cero.");
                return 0;
            }
        }

        public virtual void Limpiar()
        {
            Resultado = 0;
        }
    }

    // Clase derivada CalculadoraCientifica
    public class CalculadoraCientifica : Calculadora
    {
        public double RaizCuadrada(double a)
        {
            Resultado = Math.Sqrt(a);
            return Resultado;
        }

        public double Potencia(double a, double b)
        {
            Resultado = Math.Pow(a, b);
            return Resultado;
        }

        public double Seno(double a)
        {
            Resultado = Math.Sin(a);
            return Resultado;
        }

        public double Coseno(double a)
        {
            Resultado = Math.Cos(a);
            return Resultado;
        }

        public double Tangente(double a)
        {
            Resultado = Math.Tan(a);
            return Resultado;
        }
    }

    // Clase para la memoria de operaciones
    public static class Memoria
    {
        private static List<string> operaciones = new List<string>();

        public static void AgregarOperacion(string operacion)
        {
            operaciones.Add(operacion);
        }

        public static string ConsultarMemoria()
        {
            string memoria = "Operaciones realizadas:\n";
            foreach (string operacion in operaciones)
            {
                memoria += operacion + "\n";
            }
            return memoria;
        }

        public static void LimpiarMemoria()
        {
            operaciones.Clear();
        }
    }
}
