// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D
// пространстве.
//
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// <summary>
// Запрашивает ввод 3 координат через пробел.
// </summary>
// <param name="massage">Сообщение при вводе</param>
// <returns>Возвращает массив из трех координат</returns>
static int[] Get3DCoordinatesFromConsole(string massage)
{
    const int countCoordinates = 3;
    int[] listCoordinates = new int[countCoordinates];
    bool check = true;
    while (check)
        
    {
        Console.WriteLine(massage);
    
        string input = Console.ReadLine()!;
        string[] listStrCoordinates = input.Split(' ');
        
        if (listStrCoordinates.Length != 3)
        {
            Console.WriteLine("Ошибка ввода!");
            continue;
        }

        for (int i = 0; i < listStrCoordinates.Length; i++)
        {
            if (int.TryParse(listStrCoordinates[i], out int number))
            {
                listCoordinates[i] = number;
                check = false;
            }
            else
            {
                Console.WriteLine("Ошибка ввода!");
                check = true;
                i += countCoordinates; // чтобы выйти из цикла и check не перезаписалась
            }
        }
    }

    return listCoordinates;
}

// <summary>
// Рассчитывает длину отрезка в пространстве по двум координатам
// </summary>
// <param name="coorsA">Координаты точки А</param>
// <param name="coorsB">Координаты точки В</param>
// <returns>Возвращает длину отрезка</returns>
static double LineLength3D(int[] coorsA, int[] coorsB)
{
    int axisX = coorsA[0] - coorsB[0];
    int axisY = coorsA[1] - coorsB[1];
    int axisZ = coorsA[2] - coorsB[2];
    double result = Math.Sqrt( Math.Pow(axisX, 2) + Math.Pow(axisY, 2) + Math.Pow(axisZ, 2) );

    return result;
}

int[] coorsA = Get3DCoordinatesFromConsole("Введите координаты точки A через пробел. Например: 3 6 8.");
int[] coorsB = Get3DCoordinatesFromConsole("Введите координаты точки B через пробел. Например: 2 1 -7.");

double lineLength = LineLength3D(coorsA, coorsB);

Console.WriteLine($"Длина отрезка: {lineLength:F2}");


