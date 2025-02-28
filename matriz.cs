using System;

class Program
{
    static void Main()
    {
        int filas = 4, columnas = 6; 
        int[,] matriz = new int[filas, columnas]; 
        int valor = 12; 


        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j <= i && j < columnas; j++) 
            {
                matriz[i, j] = valor--;
            }
        }

        
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t"); 
            }
            Console.WriteLine();
        }
    }
}
