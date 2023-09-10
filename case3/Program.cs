/* Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
Например, изначально массив             Новый массив будет выглядеть
выглядел вот так:                       вот так:
1 4 7 2                                 1 4 7 2
5 9 2 3                                 5 81 2 9
8 4 2 4                                 8 4 2 4 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Creat2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(minValue, maxValue +1);
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

void ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {    
            array[i, j] *= array[i, j];
        }
    }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] myArray = Creat2DArray(rows, columns);

int min = InputNum("Введите минимальное значение элемента: ");
int max = InputNum("Введите максимальное значение элемента: ");

Fill2DArray(myArray, min, max);
Print2DArray(myArray);
Console.WriteLine();
ChangeArray(myArray);
Print2DArray(myArray);