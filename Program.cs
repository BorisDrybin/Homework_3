﻿// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// int a = num / 10000;
// int b = num % 10;
// int c = num / 1000 % 10;
// int d = num / 10 % 10;

// if (num > 9999 && num < 100000)
// {
//     if (a == b && c == d)
//     {
//     Console.WriteLine("Палиндром");
//     }
//     else
//     {
//     Console.WriteLine("Не палиндром");
//     }
// }
// else
// {
//     Console.WriteLine("Число не пятизначное!");
// }



// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите x1");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите y1");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите z1");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите x2");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите y2");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите z2");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

// Console.WriteLine(d = Math.Round(d, 2));


// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}