void PrintMatrix(int[,] Matrix);
{
    for(int i = 0; i < Matrix.GetLength(0); i++)
    {
        for(int j = 0; j < Matrix.GetLength(1); j++)
        {
            Console.Write(Matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}
int M = 4;
int N = 4;
int[,] matrix = new int[M,N];
int row = 0;
int col = 0;
int stepCol = 1;
int stepRow = 0;
int turn = 0;
int dist = N;
for(int i = 0; i < matrix.Length; i++)
{
    matrix[row, col] = i;
    if(--dist == 0)
    {
        dist = N*(turn%2)+M*((turn+1)%2)-2-(turn/2-1);
        int temp = stepCol;
        stepCol = - stepRow;
        stepRow = temp;
        turn++;
    }
    col = col + stepCol;
    row = row + stepRow;
}
PrintMatrix(matrix);