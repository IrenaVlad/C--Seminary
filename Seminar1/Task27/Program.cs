// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// string s = n.ToString();
// int sum = 0;
// int i = str.Length;
// int index = 0;
// while(str[index] < i)
// {
    // sum = sum +str[index];
    // index++;
// }
// Console.WriteLine(sum);

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
n = Math.Abs(n);
string s = Convert.ToString(n);
int sum = 0;
while (n > 0)
    {
        sum = sum + n % 10;
        n = n / 10;
    }
    Console.WriteLine(sum);