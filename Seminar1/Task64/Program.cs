Console.Write("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int number)
{
    if(number == 0)
    {
        return;
    }
    Console.Write($"{number}  ");
    PrintNumbers(number-1);
}

PrintNumbers(n);
