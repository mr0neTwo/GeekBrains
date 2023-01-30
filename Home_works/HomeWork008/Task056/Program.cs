// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей
// суммой элементов.
//
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

static int[,] GetRandomArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
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

static int GetIndexWithMinSumOfRow(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    int minSumOfRow = 0;
    int minIndex = 0;
 
    for (int i = 0; i < rows; i++)
    {
        int sumOfRow = 0;
        for (int j = 0; j < columns; j++)
        {
            sumOfRow += array[i, j];
        }

        // Console.WriteLine(sumOfRow);
        if (sumOfRow < minSumOfRow || i == 0)
        {
            minSumOfRow = sumOfRow;
            minIndex = i;
        }
       
    }
    
    return minIndex;
} 

int[,] array = GetRandomArray(5, 6);
Print2DArray(array);
Console.WriteLine();

Console.WriteLine($"Минимальная сумма в строке под номером {GetIndexWithMinSumOfRow(array) + 1}");