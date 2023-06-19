// напишите программу которая на вход принимает 2 числа и проверяет, является ли одно число квадратом другого.
// 5, 25-> да, -4, 16 -> да, 25, 5 -> да, 8, 9 -> нет.

Console.Clear();
Console.WriteLine("Введите число1: ");
int a = Convert.TwoInt32(Console.ReadLine());
Console.WriteLine("Введите число2: ");
int b = Convert.TwoInt32(Console.ReadLine());
string res = (" ");
if (b*b !=a && a*a != b)
{
    res = ("нет");
}
else{
    res = ("да");
}
Console.WriteLine(res);