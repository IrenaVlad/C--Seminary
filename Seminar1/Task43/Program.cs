Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
if(k1==k2)
{
    Console.WriteLine("Прямые не пересекаются");
}
else if(b1==b2)
{
    Console.WriteLine("Прямые совпадают друг с другом и с осью y");
}
else
{
    double x = (b1-b2)/(k2-k1);
    double y = k1*x + b1;
    Console.WriteLine($"Координаты точки пересечения {(x, y)}"); 
}
