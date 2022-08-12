Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string s = number.ToString();
int second = int.Parse(s[1].ToString());
Console.Write("Вторая цифра числа: ");
Console.WriteLine(second);
