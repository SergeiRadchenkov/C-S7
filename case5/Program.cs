int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Creat2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int k)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = (i * array.GetLength(1) * k + 1) + k * j;
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}\t");       
        Console.WriteLine();
    }
}

int[] FindNumberByPosition(int [,] matrix, int rowPosition, int columnPosition)
{
    int[] array = new int[3];
    
    if (rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1))
     {   return array = new int[3] {0, 0, 0}; }
    else
    {
        return array = new int[3] {rowPosition, columnPosition, matrix[rowPosition - 1, columnPosition - 1]};
    }
     
}

void PrintCheckIfError(int[] results, int X, int Y)
{
   if (results[0] == 0)
        Console.WriteLine("There is no such index");
    else 
        Console.WriteLine($"The number in [{X}, {Y}] is {results[2]}");
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] myArray = Creat2DArray(rows, columns);

int plus = InputNum("Введите число, на которое увеличивается каждый новый элемент: ");
int x = InputNum("Введите значение X: ");
int y = InputNum("Введите значение Y: ");

Fill2DArray(myArray, plus);
Print2DArray(myArray);
int[] result = FindNumberByPosition(myArray, x, y);
PrintCheckIfError(result, x, y);