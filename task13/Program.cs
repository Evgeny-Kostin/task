// Задача 13. Напишите программу которая на вход принимает число и проверяет кратно ли оно одновременно 7 и 23.
// 14 -> no, 46-> no, 161->yes
Console.Clear();
Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine()!); // new Random().Next(100, 1000); 
//int result = 0;
//int result1 = number/7;
//int result2 = number/23;
if (number%7 == 0 && number%23 == 0) // чтобы одновременно сравнить с 2-я условиями ставим && условия приравниваем к 0. /не работатет
{
    Console.WriteLine(number + "-> да");
    
}
else
{
    Console.WriteLine(number + "-> нет");
}
