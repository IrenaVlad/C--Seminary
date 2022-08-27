Console.WriteLine("Задайте двумерный массив  m x n ");
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
Console.WriteLine();
for(int j = 0; j < n; j++)
{
    double sum = 0;
    for(int i = 0; i < m; i++)
    {
        sum = sum + matrix[i, j];
    } 
    Console.WriteLine($"Среднее арифметическое столбца номер {j+1} равно {sum/m}");
}