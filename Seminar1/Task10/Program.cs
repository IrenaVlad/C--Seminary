Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int a = number/10;
int b = a%10;
Console.WriteLine($"{b}");
