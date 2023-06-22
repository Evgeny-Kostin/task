// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = Prompt ("Введите число: ");
int i = 1;
Cube(number);
int Prompt (string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void Cube(int number)
{
while(i<=number) 
{
    
    Console.Write(i*i*i + " ");
    i++;
}
}
