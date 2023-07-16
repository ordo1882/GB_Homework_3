﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Enter the coordinate x1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the coordinate y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the coordinate z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the coordinate x2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the coordinate y2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the coordinate z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

System.Console.WriteLine(Math.Round(result, 2));