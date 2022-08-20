int[] array = new int[10];
Random rand = new Random();
for(int a = 0; a < array.Length; a++)
{
    array[a] = rand.Next(0, 100);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
int sum = 0;
for(int a=1; a < array.Length; a = a+2)
{
    sum = sum + array[a];
}
Console.WriteLine($"Сумма равна {sum}");