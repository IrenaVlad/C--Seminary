Console.WriteLine("Введите массив вещественных чисел из 5 элементов");
double[] arr = new double[5];
int index = 0;
int max = arr[0];
if(arr[index] > max)
{
    max = arr[index];
    index++;
} 
Console.WriteLine($"max = {max}");
int index = 0;
int min = arr[0];
if(arr[index] < min)
{
    min = arr[index];
    index++;
} 
Console.WriteLine($"min = {min}");
int sum = 0;
sum = max - min;
Console.WriteLine(sum);