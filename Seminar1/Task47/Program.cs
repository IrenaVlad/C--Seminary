Console.WriteLine("Задайте двумерный массив  m x n ");
Console.WriteLine("Введите m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double [m,n];
Random rand = new Random();
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < 0; j++)
    {
        matrix[m,n] = rand.NextDouble();
        Console.Write($"{matrix[i,j]}  ");
    }
    Console.WriteLine();
}