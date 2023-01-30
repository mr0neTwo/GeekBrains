// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

static int[,,] GetRandomUniq3DArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    Random random = new Random();

    int amountNumbers = x * y * z;
    if (amountNumbers > 90)
    {
        string message = $"Невозможно заполнить массив из {amountNumbers} элементов уникальными двузначными значениями";
        throw new Exception(message);
    }

    int[] uniqNumbers = new int[amountNumbers];
    int currentIndex = 0;
    
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                bool check = true;
                while (check)
                {
                    int number = random.Next(10, 100);
                    if (!uniqNumbers.Contains(number))
                    {
                        array[i, j, k] = number;
                        uniqNumbers[currentIndex] = number;
                        currentIndex++;
                        check = false;
                    }
                }
            }
        }
    }

    return array;
}

static void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]}({i}, {j}, {k})");
            }
        }
    }
}

static void Print3DArrayBeauty(int[,,] array)
{
    for (int z = 0; z < array.GetLength(2); z++)
    {
        int y = array.GetLength(1);
        if (y == 1) Console.Write($"Z{z}".PadRight(array.GetLength(1) * 4 + 2));
        else Console.Write($"Слой {z}".PadRight(array.GetLength(1) * 4 + 2));
        
    }
    Console.WriteLine();
    
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int z = 0; z < array.GetLength(2); z++)
        {
            for (int y = 0; y < array.GetLength(1); y++)
            {
                Console.Write($"{array[x, y, z]}  ");
            }

            Console.Write("  ");
        }
        Console.WriteLine();
    }
}

int[,,] array = GetRandomUniq3DArray(4, 4, 5);
Print3DArray(array);

Console.WriteLine();
Print3DArrayBeauty(array);