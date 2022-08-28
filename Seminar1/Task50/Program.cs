﻿Console.WriteLine("Задайте двумерный массив  m x n ");
Console.WriteLine("Введите m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(-10, 10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите номер строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a < m && b < n)
{
Console.WriteLine($"Значение элемента равно {matrix[a-1, b-1]}");
}
else
{
Console.WriteLine("Такой ячейки в массиве нет");
} 
