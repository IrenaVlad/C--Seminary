int[] array = new int[5];
Console.Write("Введите первую цифру числа: ");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую цифру числа: ");
array[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третью цифру числа: ");
array[2] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите четвертую цифру числа: ");
array[3] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите пятую цифру числа: ");
array[4] = Convert.ToInt32(Console.ReadLine());
if(array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}