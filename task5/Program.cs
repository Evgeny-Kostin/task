﻿//Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!); //берем от пользов число и переводим из строки в число
int i = number*-1;                           // ввод переменной с отрицательным значением

while (i<=number)                            //в цикле ввести условие переменная меньше или равна числу
{                  
    Console.Write(i + " ");                  // вывод числа склеив+конкотинация с пробелом " " кавычки чтобы считывался как символ
    i++;                                     //ввести +1 чтобы не ушло в бесконечность
}
