using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {  Console.Write($"{matrix[i, j]}\t");  }     
        Console.WriteLine();
        }


    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
    int[,] array = new int[n, m];
      
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = (i * m * k + 1) + k * j;
        }
      }
        return array;

    }
  
    static void PrintListAvr (double [] list)
    {
      // Введите свое решение ниже
      Console.WriteLine("The averages in columns are: ");
      for (int i = 0; i < list.Length; i++)
      {
            Console.Write($"{list[i]:f2}\t");
      }
      
    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
      double[] array = new double[matrix.GetLength(1)];
        double a = 0;
        int b = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            while (b < matrix.GetLength(0))
            {
                a = a + matrix[b, i];
                b++;
            }
            array[i] = a / matrix.GetLength(0);
            b = 0;
            a = 0;
        }
        return array;

    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 4;
           m = 5;
           k = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}