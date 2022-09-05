Console.WriteLine("Введите число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());

int Ack(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  } 
  else if (n == 0 && m > 0) 
  {
    return Ack(m - 1, 1);
  }
  else 
  {
    return Ack(m - 1, Ack(m, n - 1));
    }
}
Console.WriteLine($"Функция равна {Ack(m,n)}");