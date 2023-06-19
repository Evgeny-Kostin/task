// напишите программу которая на вход принимает 2 числа и проверяет, является ли одно число квадратом другого.
// 5, 25-> да, -4, 16 -> да, 25, 5 -> да, 8, 9 -> нет.
Console.Clear();
Console.Write("Введите число1: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число2: ");
int b = int.Parse(Console.ReadLine()!);
int x = 0;
if (a>b)
{
    x = b * b;
    if (x==a)
    {
        Console.WriteLine($" {a}, {b} -> да");
    }
    
}
else if (a<b) 
{
    x = a *a;
    if (x==b)
    {
        Console.WriteLine($" {a}, {b} -> да");
    }
    else
    {
        Console.WriteLine($" {a}, {b} -> нет");
    }

}
