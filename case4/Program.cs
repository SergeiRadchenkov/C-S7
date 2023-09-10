/* Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12 */

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

int ChangeArray(int[,] array)
{
    int sum = 0;
/*    int minLength = array.GetLength(0);
    if (array.GetLength(1) < array.GetLength(0))
        minLength = array.GetLength(1); */
    int minLength = array.GetLength(0) > array.GetLength(1) ? array.GetLength(1) : array.GetLength(0);
    for (int i = 0; i < minLength; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");

int[,] myArray = Creat2DArray(rows, columns);

int min = InputNum("Введите минимальное значение элемента: ");
int max = InputNum("Введите максимальное значение элемента: ");

Fill2DArray(myArray, min, max);
Print2DArray(myArray);
Console.WriteLine();
int sum = ChangeArray(myArray);
Console.Write(sum);