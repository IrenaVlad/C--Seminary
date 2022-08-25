int[] FillArray(int size, int leftRange, int rigthRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rigthRange+1);
    }
    return arr;
}
int[] array = FillArray(5,-6,6);
Console.WriteLine('[' +string.Join(", ", array) +']');
int[] array2 = new int[5];
for(int j = 0; j < 5; j++)
{
    array2[j] = array[j];
}
Console.WriteLine('[' +string.Join(", ", array2) +']');