int[] array = {1, -7, 567, 89, 223};
int count = 0;
for(int i =0; i < 5; i++)
{
    if(array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество положительных чисел равно {count}");
