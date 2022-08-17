int[] array = new int[8];
int i = 0;
while(i < 8)
{
    array [i] = new Random().Next(0, 100);
    Console.Write($"[{array[i]}], ");
    i++;
}
Console.WriteLine();
