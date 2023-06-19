// Задача№10. Напишите программу, которая принимает 3-х значное число и на выходе показывает 
//вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трех значное число от 100 до 999: ");
int num = int.Parse(Console.ReadLine()!);
int firstValue = num/10%10;
//int secondValue = num%10;
Console.WriteLine(firstValue);
