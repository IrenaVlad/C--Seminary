Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
string []arr = {"x > 0; y > 0", "x < 0; y > 0", "x < 0; y < 0", "x > 0; y < 0"};
if(quarter >= 1 && quarter <=4)
{
    Console.WriteLine(arr[quarter -1]);
}
else
{
    Console.WriteLine("Такой четверти нет");
}