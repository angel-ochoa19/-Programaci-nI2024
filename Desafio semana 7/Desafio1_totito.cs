

using System;

namespace TresEnLinea
{
    class Program
    {
        static char[,] tablero = new char[3, 3]; // El tablero de 3x3
        static char jugadorActual = 'X'; // El jugador actual (comienza con 'X')

        static void Main(string[] args)
        {
            InicializarTablero();
            MostrarInstrucciones();

            while (true)
            {
                MostrarTablero();
                Console.WriteLine($"Turno del jugador {jugadorActual}.");
                Console.Write("Ingresa la fila (0-2): ");
                int fila = int.Parse(Console.ReadLine());
                Console.Write("Ingresa la columna (0-2): ");
                int columna = int.Parse(Console.ReadLine());

                if (EsMovimientoValido(fila, columna))
                {
                    RealizarMovimiento(fila, columna);
                    if (HayGanador())
                    {
                        Console.WriteLine($"¡Jugador {jugadorActual} ha ganado!");
                        break;
                    }
                    else if (TableroLleno())
                    {
                        Console.WriteLine("¡Empate! El tablero está lleno.");
                        break;
                    }
                    CambiarJugador();
                }
                else
                {
                    Console.WriteLine("Movimiento inválido. Inténtalo de nuevo.");
                }
            }
        }

        static void InicializarTablero()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tablero[i, j] = ' ';
                }
            }
        }

        static void MostrarInstrucciones()
        {
            Console.WriteLine("Bienvenido al juego ToTiTo (Tres en línea)!");
            Console.WriteLine("Para jugar, ingresa la fila y columna donde deseas colocar tu ficha ('X' o 'O').");
            Console.WriteLine("El tablero se ve así:");
            Console.WriteLine(" 0 1 2");
            Console.WriteLine("0 | | | |");
            Console.WriteLine("1 | | | |");
            Console.WriteLine("2 | | | |");
            Console.WriteLine("Elige una fila (0-2) y una columna (0-2) para colocar tu ficha (‘X’ o ‘O’).");
            Console.WriteLine("El objetivo es formar una línea horizontal, vertical o diagonal con tus fichas.");
            Console.WriteLine("¡Diviértete jugando ToTiTo!");
            Console.WriteLine("¡Comencemos!");
        }

        static void MostrarTablero()
        {
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("|" + tablero[i, j]);
                }
                Console.WriteLine("|");
            }
        }

        static bool EsMovimientoValido(int fila, int columna)
        {
            return fila >= 0 && fila < 3 && columna >= 0 && columna < 3 && tablero[fila, columna] == ' ';
        }

        static void RealizarMovimiento(int fila, int columna)
        {
            tablero[fila, columna] = jugadorActual;
        }

        static bool HayGanador()
        {
            // Implementa la lógica para verificar si hay un ganador
            // (Comprueba filas, columnas y diagonales)
            // Devuelve true si hay un ganador, de lo contrario, false.
            // ¡Puedes ser creativo aquí!

            return false;
        }

        static bool TableroLleno()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tablero[i, j] == ' ')
                        return false;
                }
            }
            return true;
        }

        static void CambiarJugador()
        {
            jugadorActual = (jugadorActual == 'X') ? 'O' : 'X';
        }
    }
}