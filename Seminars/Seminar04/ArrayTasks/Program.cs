
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

int[] myArray = CreateRandomArray(12, -9, 9);
ShowArray(myArray);


int sumPos = 0;
int sumNeg = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0) sumPos += myArray[i];
    else sumNeg += myArray[i];
}
Console.WriteLine($"сумма положительных элементов = {sumPos}");
Console.WriteLine($"сумма отрицательных элементов = {sumNeg}");
