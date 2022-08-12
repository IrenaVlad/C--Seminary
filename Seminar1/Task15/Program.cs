Console.WriteLine("Введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 6 || number == 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Рабочий день");
}

