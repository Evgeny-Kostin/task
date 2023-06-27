// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. 
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int a = TakeUserNum();
int b = TakeUserNum();
int c = TakeUserNum();

if(TriangleInequality(a, b, c))
    Console.WriteLine($"Треугольник со сторонами такой длины может существовать");
else
    Console.WriteLine($"Треугольник со сторонами такой длины НЕ может существовать");

bool TriangleInequality(int a, int b, int c)
{
    bool inequality = true;

    if(a >= (b + c) || b >= (a + c) || c >= (a + b)) inequality = false;

    return inequality;
}

int TakeUserNum()
{
    int userNum;

    while(!int.TryParse(Console.ReadLine(), out userNum))
        Console.WriteLine("Пожалуйста введите число!");

    return userNum;
}