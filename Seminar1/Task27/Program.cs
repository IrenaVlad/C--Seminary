Console.WriteLine("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[N];
int sum = 0;
int i = Array.Length;
int index = 0;
while(index<i)
{
sum = sum + Array[index];
index++;
}
Console.WriteLine(sum);
