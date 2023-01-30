// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

static void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:D2}  ");
        }

        Console.WriteLine();
    }
}

static int[,] FillArray(int[,] array, int[] startPoint, int startValue)
{
    int x = startPoint[0];
    int y = startPoint[1];

    bool canStepRight = y + 1 < array.GetLength(1) && array[x, y + 1] == 0;
    bool canStepDown = x + 1 < array.GetLength(0) && array[x + 1, y] == 0;
    bool canStepLeft = y - 1 >= 0 && array[x, y - 1] == 0;
    bool canStepTop = x - 1 >= 0 && array[x - 1, y] == 0;

    if (canStepRight && !canStepTop)
    {
        array[x, y++] = ++startValue;
        FillArray(array, new int[] { x, y }, startValue);
    }
    else if (canStepDown)
    {
        array[x++, y] = ++startValue;
        FillArray(array, new int[] { x, y }, startValue);
    }
    else if (canStepLeft)
    {
        array[x, y--] = ++startValue;
        FillArray(array, new int[] { x, y }, startValue);
    }
    else if (canStepTop)
    {
        array[x--, y] = ++startValue;
        FillArray(array, new int[] { x, y }, startValue);
    }
    else
    {
        array[x, y] = ++startValue;
    }

    return array;
}

int[,] array = new int[7, 7];
int[,] filledArray = FillArray(array, new int[2], 0);
Print2DArray(filledArray);