// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

static int[,] GetRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(10);
        }
    }

    return array;
}

static void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }

        Console.WriteLine();
    }
}

static double[] AverageOfColumns(int[,] array)
{
    double[] averageOfColumns = new double[array.GetLength(1)];
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    for (int i = 0; i < columns; i++)
    {
        double sum = 0;
        for (int j = 0; j < rows; j++)
        {
            sum += array[j, i];
        }

        averageOfColumns[i] = sum / rows;
    }

    return averageOfColumns;
}

int[,] array = GetRandomArray(4, 4);
Print2DArray(array);
Console.WriteLine();

double[] averageOfColumns = AverageOfColumns(array);
Console.WriteLine($"[ {String.Join(", ", averageOfColumns)} ]");