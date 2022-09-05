Console.Write("Введите число M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int Sum(int M, int N)
{
    if(M > N) 
    {
        return 0;
    }
    return M + Sum(M+1,N);
}
if(M < N)
{
    Console.WriteLine($"Сумма натуральных чисел в промежутке от M до N равна {Sum(M, N)}");
}
else
{
    Console.WriteLine($"Сумма натуральных чисел в промежутке от N до M равна {Sum(N, M)}");
}
