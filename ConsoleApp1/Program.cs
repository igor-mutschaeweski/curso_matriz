using System;
using System.Globalization;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("PROGRAMAÇÃO ORIENTADA A OBJETOS - EXERCICIO DE MATRIZ");
            Console.WriteLine("=====================================================");

            Console.WriteLine();
            
            Console.WriteLine("Digite a quantidade de linhas e colunas para a matriz:");
            String[] y = Console.ReadLine().Split(' ');

            Console.WriteLine();

            int m = int.Parse(y[0]);
            int n = int.Parse(y[1]);

            int[,] matriz = new int[m,n];

            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Digite um numero da matriz:");
            int x = int.Parse(Console.ReadLine());

         //   Console.WriteLine();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Posição na matriz: " + "[" + i + "," + j + "]");
                        
                        if (j > 0)
                        {
                            Console.WriteLine("Numero à esquerda: " + matriz[i,j-1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Numero acima: " + matriz[i-1,j]);
                        }                     
                        if (j < n - 1)
                        {
                            Console.WriteLine("Numero à direita: " + matriz[i,j+1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Numero abaixo: " + matriz[i+1,j]);
                        }
                    
                    }

                }
            }
            Console.WriteLine();
        }
    }
}
