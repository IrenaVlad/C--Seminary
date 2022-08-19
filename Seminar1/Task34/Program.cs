int[] array = new int[10];
Random rand = new Random();
for(int a = 0; a < array.Length; a++)
{
    array[a] = rand.Next(100, 1000);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
int count = 0;
for(int a = 0; a < array.Length; a++)
{
    if(array[a]%2 ==0)
    {
        count=count+1;
    }
}
Console.WriteLine($"Количество четных чисел равно {count}");