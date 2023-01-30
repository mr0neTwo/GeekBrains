// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки
// двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

static int[,] SortArrayRowsDesc(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    int[] temp = new int[columns];
 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            temp[j] = array[i, j];
        }
        
        Array.Sort(temp);
        Array.Reverse(temp);
        
        for (int k = 0; k < columns; k++)
        {
            array[i, k] = temp[k];
        }
    }

    return array;
} 

int[,] array = GetRandomArray(5, 6);
Print2DArray(array);
Console.WriteLine();

int[,] sortedArray = SortArrayRowsDesc(array);
Print2DArray(sortedArray);

