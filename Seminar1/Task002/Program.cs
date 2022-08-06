Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB)
{
    Console.Write("max = ");
    Console.WriteLine(numberA);
    Console.Write("min = ");
    Console.WriteLine(numberB);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(numberB);
    Console.Write("min = ");
    Console.WriteLine(numberA);
}