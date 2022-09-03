int[,,] array = new int[2,2,2];
int count = 0;
Random rand = new Random();
for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int a = 0; a < array.GetLength(2); a++)
            {
                array[i,j,a] = rand.Next(10, 100);
                Console.Write($"{array[i,j,a]}({i},{j},{a}) ");
                count++;
            }
        }
        Console.WriteLine();
    }

