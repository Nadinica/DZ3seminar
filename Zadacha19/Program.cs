// Задача 19 Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да   while(10000<=x<100000)

Console.Write("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
int PoiskCount(int x)
{
    int result = 0;
    while (x!=0)
    {
        result+=1;
        x=x/10;
    }
    return result;
}
int count1 = PoiskCount(x);
//Console.WriteLine(count1);
int[]Number(int x)
{
    int count = PoiskCount(x)-1;
    int[] numbers =  new int [count+1];
    while (x!=0)
    {
        numbers[count--]= x%10;
        x=x/10;
    }
    return numbers;
}
int [] array = Number(x);
int size = array.Length;
int index = 0;
if (index<size)
if (array[0]==array[array.Length-1] && array[1]==array[array.Length-2])
{
    
    Console.Write("Число является палиндромом");
}
else
{
    Console.Write("Число не является палиндром");
}

