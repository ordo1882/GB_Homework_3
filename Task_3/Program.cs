﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Enter the number");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= num; i++)
{
    System.Console.WriteLine(Math.Pow(i, 3));
}