//Задача№8: Напишите программу, которая на вход принимает число N,
// а на выходе показывает все четные числа от 1 до N.
// 5 -> 2,4
// 8 -> 2,4,6,8

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);
int i = 2;

if(number > 1)
{
    while(i <= number)
    {
        Console.Write(i + " ");
        i = i + 2;
    }
}