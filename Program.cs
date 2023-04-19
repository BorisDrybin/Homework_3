// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

int a = num / 10000;
int b = num % 10;
int c = num / 1000 % 10;
int d = num / 10 % 10;

if (num > 9999 && num < 100000)
{
    if (a == b && c == d)
    {
    Console.WriteLine("Палиндром");
    }
    else
    {
    Console.WriteLine("Не палиндром");
    }
}
else
{
    Console.WriteLine("Число не пятизначное!");
}