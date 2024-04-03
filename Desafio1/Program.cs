using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[3, 3]; 
            int currentPlayer = 1; 
            int totalMoves = 0; 

            while (totalMoves < 9) 
            {
                Console.Clear(); 
                PrintBoard(board);

                Console.WriteLine($"Turno del Jugador {currentPlayer}");
                Console.Write("Fila (0-2): ");
                int row = int.Parse(Console.ReadLine());

                Console.Write("Columna (0-2): ");
                int col = int.Parse(Console.ReadLine());

                if (IsValidMove(board, row, col))
                {
                    board[row, col] = currentPlayer;
                    totalMoves++;

                    if (CheckWinner(board, currentPlayer))
                    {
                        Console.Clear();
                        PrintBoard(board);
                        Console.WriteLine($"¡Jugador {currentPlayer} ha ganado!");
                        break;
                    }

                    currentPlayer = 3 - currentPlayer; 
                }
                else
                {
                    Console.WriteLine("Movimiento inválido. Inténtalo de nuevo.");
                }
            }

            if (totalMoves == 9)
            {
                Console.Clear();
                PrintBoard(board);
                Console.WriteLine("¡Empate! El juego ha terminado sin ganador.");
            }
        }

        static void PrintBoard(int[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    char symbol = board[i, j] == 1 ? 'X' : board[i, j] == 2 ? 'O' : ' ';
                    Console.Write($" {symbol} ");
                    if (j < 2) Console.Write("|");
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("-----------");
            }
        }

        static bool IsValidMove(int[,] board, int row, int col)
        {
            return board[row, col] == 0; 
        }

        static bool CheckWinner(int[,] board, int player)
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                    return true; 
                if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
                    return true; 
            }

            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
                return true; 
            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
                return true; 

            return false;
        }
    }
}
