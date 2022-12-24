/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

/*
АЛГОРИТМ
Вводим число с защитой от "балбеса"
Добавляем массив 
Запускаем цикл сравнения чисел 1 с 5, 2 с 4
Выводим результат
*/

int GetNumberFromConsole(string message)
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
            Console.WriteLine("Ввели не пятизначное число. Повторите ввод!");
        }
    }
    return result;
}
Console.Write("Ведите пятизначное число: ");
int num = GetNumberFromConsole(""); // 12821

                 //    0   1   2     3     4      5
int[] fiveDigitNum = { 1, 10, 100, 1000, 10000, 100000 };
int n = fiveDigitNum.Length;


int d1 = (num % fiveDigitNum[5])/fiveDigitNum[4];
//Console.WriteLine(d1);
int d2 = (num % fiveDigitNum[4])/fiveDigitNum[3];
//Console.WriteLine(d2);
int d4 = (num % fiveDigitNum[2])/fiveDigitNum[1];
//Console.WriteLine(d4);
int d5 = num % fiveDigitNum[1];
//Console.WriteLine(d5);



if(d1==d5 && d2 == d4)
{
    Console.WriteLine($"{num} - палиндром");
}
else
{
    Console.WriteLine($"{num} - нет");
}
