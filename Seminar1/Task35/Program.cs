int[] array = new int[10];
Random rand = new Random();
for(int a = 0; a < array.Length; a++)
{
    array[a] = rand.Next(0, 1000);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
int count = 0;
for(int a = 0; a < array.Length; a++)
{
    if(10 < array[a] < 100)
    {
        count=count+1;
    }
}
Console.WriteLine($"Количество элементов массива в отрезке [10,99] равно {count}");
