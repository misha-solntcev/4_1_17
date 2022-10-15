using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 17
Из заданной матрицы A(N, M) удалите строку, в которой находится первый
отрицательный элемент. */

namespace _4_1_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {   
                { 8, 0, 6, 4, 8 },
                { 4, 1, 6, -7, 8 },
                { 7, 8, 9, 0, 2 },
                { 12, 0, 3, -4, 5 },
                { 13, 0, -1, 1, 0 },
            };
            int n = arr.GetLength(0);
            int m = arr.GetLength(1);

            // Поиск отрицательного элемента
            int index = 0;            
            for (int i = 0; i < n; i++)            
                for (int j = 0; j < m; j++)                
                    if (arr[i, j] < 0)
                    {
                        index = i;
                        goto Exit;
                    }            
            Exit:
            // Сдвиг строк
            for (int i = index; i < n-1; i++)            
                for (int j = 0; j < m; j++)
                    arr[i, j] = arr[i+1, j];

            // Новый массив без последней строки.
            int[,] newArr = new int[n-1, m];
            int k = newArr.GetLength(0);
            int l = newArr.GetLength(1);
            for (int i = 0; i < k; i++)
                for (int j = 0; j < l; j++)
                    newArr[i, j] = arr[i, j];

            // Вывод в консоль измененного массива.
            Console.WriteLine($"Измененный массив: ");
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    Console.Write($" {newArr[i, j]}, ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
