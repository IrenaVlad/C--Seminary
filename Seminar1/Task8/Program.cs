Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count < N)
{
    if(count%2 == 0)
    {
        int what = count;
        Console.WriteLine(what);
        count = count+1;
    }
    else
    {
        count = count+1;
    }
}