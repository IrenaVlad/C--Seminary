int Fibonachi(int N)
{
    int result = 0;
    if(N == 0)
    {
        result = 0;
    }
    else if(N == 1 || N == 2)
    {
        result = 1;
    }
    else 
    {
        result = Fibonachi(N-1) + Fibonachi(N-2);
    }    
    return result;
};
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < N; i++)
{
    Console.WriteLine(Fibonachi(i));
}

