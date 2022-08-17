int N = 8;
int min = 0;
int max = 10;
int[] Array = (int N, int min, int max);
{
    int[] arr = new int[N];
    for(int i = 0; i < N; i++)
    {
        arr [i] = new Random().Next(min, max);
    }
    return arr;
}
Console.Write();
Console.WriteLine('[' + string.Join(", ", Array(i, min, max)) + ']');
Console.WriteLine();
