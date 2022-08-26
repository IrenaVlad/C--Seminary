Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Factorial( int N)
{
    if(N== 1) return 1;
    else return N*Factorial(N-1);
}
Console.WriteLine(Factorial(N));