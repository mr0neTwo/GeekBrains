
// 26

int Length(int number)
{
    int count = 1;
    while(number / 10 != 0)
    {
        number = number / 10;
        count += 1;
    }
    return count;

}
int result = Length(345);
Console.WriteLine(result);


