//Задача 12. Напишите программу, которая на вход принимает 2 числа, и выводит является ли второе число кратным первому.
// 34, 5 ->  не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.WriteLine("Введите число1 ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число2 ");
int b = int.Parse(Console.ReadLine()!);
int res = 0;
double res2 = 0;

if (a % b == 0)
{
    res = a / b;
    Console.WriteLine("кратно" );
}
else 
{
    res2 = a % b;
    Console.Write("не кратно -> " + res2);
}