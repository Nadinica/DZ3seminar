// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Напишите число");
int n = Convert.ToInt32(Console.ReadLine());

int N;
int[] arr = new int[n];
for (int i = 1; i <= n; i++)
{
    N = i*i*i;Console.Write("n^3="); Console.WriteLine(N);
     
}

