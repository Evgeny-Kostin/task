﻿//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int a = Promt ("Введите число: ");
int len = Length(a);
Console.Write($"Сумма цифр в числе {a} равно: {Sum(a,len)}");
int Promt(string message) 
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
int Length(int a)
{
int index = 0;
while (a > 0)
{
a /= 10;
index++;
}
return index;
}

int Sum(int a, int len)
{
int sum = 0;
for (int i = 1; i <= len; i++)
{
sum += a % 10;
a /= 10;
}
return sum;
}