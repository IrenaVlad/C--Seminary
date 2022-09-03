const int ROWS = 2;
const int COLUMNS = 2;
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
void SumMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int i = 0; i < matrix3.GetLength(0); i++)
    {
        for(int j = 0; j < matrix3.GetLength(1); j++)
        {
            int sum = 0;
            for(int a = 0; a < matrix2.GetLength(0); a++)
            {
                sum = sum +matrix1[i,a]*matrix2[a,j];
            }
            matrix3[i,j] = sum;
            Console.Write(matrix3[i,j] +" ");
        }
        Console.WriteLine();
    }
}
int [,] matrix1 = FillMatrixRandom(ROWS, COLUMNS);
PrintMatrix(matrix1);
Console.WriteLine();
int [,] matrix2 = FillMatrixRandom(ROWS, COLUMNS);
PrintMatrix(matrix2);
Console.WriteLine();
SumMatrix(matrix1, matrix2);