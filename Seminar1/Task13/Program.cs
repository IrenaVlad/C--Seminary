Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    string s = Convert.ToString(number);
    int third = int.Parse(s[2].ToString());
    Console.WriteLine($"Третья цифра числа: {third}");
}

