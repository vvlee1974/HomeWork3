/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
Алгоритм
Вводим числа с защитой от "балбеса"
Вводим переменные кординат каждой точки x, y, z
Водим формулу расстояния, используя методы Math.Sqrt() и Math.Pow()
Выводим результат
*/


int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число. Повторите ввод!");
        }
    }
    return result;
}
Console.Write("Точка А - координата x1: ");
int x1 = GetNumber("");
Console.Write("Точка А - координата y1: ");
int y1 = GetNumber("");
Console.Write("Точка А - координата z1: ");
int z1 = GetNumber("");

Console.Write("Точка В - координата x2: ");
int x2 = GetNumber("");
Console.Write("Точка В - координата y2: ");
int y2 = GetNumber("");
Console.Write("Точка В - координата z2: ");
int z2 = GetNumber("");

double distans = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"Расстояние AB = {distans}");