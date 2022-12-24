/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*
Создаём метод защиты от "балбеса" - GetNumber(string message)
Создаём метод возведения числа в степень - GetPow(int x)
Ввод числа, ипользуя метод GetNumber(string message)
Выводим таблицу через оператор for, используя метод GetPow(int x)
*/

int GetNumber(string message) // метод проверки введения числа (защита от "балбеса")
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

double[] GetPow(int x) // метод возведения чисел (от "0" до "x") в степень
{
    double[] mass = new double[x];
    for (int index = 0; index < x; index++)
    {
        mass[index] = Math.Pow(index + 1, 3);
    }
    return mass;
}

int result = GetNumber("Введите число"); // принимает введённое число
double[] massPow = GetPow(result); // применяет метод для возведения чисел (от "0" до "x") в степень
for (int i = 0; i < massPow.Length; i++)
{
    Console.WriteLine($"Куб числа {i + 1} равен {massPow[i]}");
}
