// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] array = GetArray(8);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 999);
    }

    return result;
}

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}


