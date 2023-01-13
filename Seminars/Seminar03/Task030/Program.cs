// 30
int[] myArray = new int[8];
Random rand= new Random();
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rand.Next(2);
    Console.WriteLine(myArray[i]);
}


// 30
int[] array = GetBinaryArray(8);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");


int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);
    }

    return result;
}