Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int C = Math.Abs(B);
int sum = A; 
int count=2;
while( count <=C)
{
sum = sum * A;
count++;
}
Console.WriteLine(sum);
