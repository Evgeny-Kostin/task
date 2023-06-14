// Задача №8: Напишите программу, котрая на вход принимает число N, 
// а на выходе показывает все четные числа от 1 до N.
// 5-> 2,4
// 8-> 2,4,6,8

Console.Write("Введите число N: "); 
int N = int.Parse(Console.ReadLine()!); 
if ((N % 2) == 0)
{
    Console.WriteLine("chentoe");
}
else
{
    Console.WriteLine("nechentoe");
}
