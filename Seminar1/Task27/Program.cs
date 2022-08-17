Console.WriteLine("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());
string str = N.ToString();
int sum = 0;
int i = str.Length;
int index = 0;
while(str[index] < i)
{
    sum = sum + str[index];
    index++;
}
Console.WriteLine(sum);
