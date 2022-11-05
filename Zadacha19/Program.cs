// Задача 19 Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

int y1 = 0;
int y2 = 0;
int y3 = 0;
int y4 = 0;
int y5 = 0;
while (x > 9999)
{
    if (y1 == y5)
    {
        if (y2 == y4) Console.WriteLine("Палиндром");
        break;
    }
    else Console.WriteLine("не является палиндромом");
}
Console.WriteLine("проверяется только пятизначное число");


