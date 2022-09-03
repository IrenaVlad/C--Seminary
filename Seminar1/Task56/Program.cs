const int ROWS = 4;
const int COLUMNS = 3;
int[,] FillMatrixRandom(int rows, int columns, int leftRange = 0, int rigthRange = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for(int i = 0; i< matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rigthRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i< matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+ " ");
        }
        Console.WriteLine();
    }
}
void FindMinRow(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)];
    for(int i =0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i,j];
        }
        result[i] = sum;
    }
    int min = result[0];
    int number = 0;
    for(int i = 1; i < result.Length; i++)
    {
        if(result[i] < min)
        {
            min = result[i];
            number = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма в строке {number+1}");
}
int [,] matrix = FillMatrixRandom(ROWS, COLUMNS);
PrintMatrix(matrix);
FindMinRow(matrix);