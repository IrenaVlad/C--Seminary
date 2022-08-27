Console.WriteLine("Задайте двумерный массив  m x n ");
Console.WriteLine("Введите m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < 0; j++)
    {
        matrix[m,n] = new Random().Next(-10, 10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
for(int i =0; i<n; i++)
{

}