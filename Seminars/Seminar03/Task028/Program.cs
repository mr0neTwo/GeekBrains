// 28
Console.WriteLine("Введите число ");
int chis = Convert.ToInt32(Console.ReadLine());
int proizv = 1;
for (int i = 1; i < chis+1; i++)
{
    proizv = proizv * i;
    Console.WriteLine(proizv);
}
Console.WriteLine(proizv);