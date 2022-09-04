Console.Write("Введите число M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());

void Sum(int M, int N, int sum = 0)
{
    if(M == N)
    {
        return;
    }
    Sum(M = M + 1);
    sum = sum + M;
    Console.WriteLine(sum);
}
Sum(M,N);
