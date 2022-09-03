const int ROWS = 3;
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

int [,] SelectionSort(int[,] matrix)
{
    for(int i = 0; i< matrix.GetLength(0); i++)
    {
        for(int j = 0; j< matrix.GetLength(1)-1; j++)
        {
            int max = matrix[i,j];
            for(int a = j+1; a <matrix.GetLength(1); a++)
            {
                if(matrix[i,a] > max)
                {
                    matrix[i,j] = matrix[i,a];
                    matrix[i,a] = max;
                    max = matrix[i,j];
                }
            }
        }
    }
    return matrix;
}
int [,] matrix = FillMatrixRandom(ROWS, COLUMNS);
PrintMatrix(matrix);
Console.WriteLine();
SelectionSort(matrix);
PrintMatrix(matrix);     