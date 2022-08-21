public class Example
{
public static void Main()
    {
        double[] arr = { 8.4, 6.7, 1.2, 3.3, 4.8 };
 
        Array.Sort(arr);
        if (arr.Length > 0) {
            Console.WriteLine("Минимальное значение равно " + arr[0]);
            Console.WriteLine("Максимальное значение равно " + arr[arr.Length - 1]);
        }
        double sum = arr[arr.Length-1] - arr[0];
        Console.WriteLine("Разница равна " + sum);
    }
}