// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Подскажите, пожалуйста почему не работает

int rows = Prompt("Введите колличество строк: ");
int columns = Prompt("Введите колличество столбцов: ");
Console.WriteLine("введите номер строки");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите номер столбца");
int n = int.Parse(Console.ReadLine()!);
int[,] numbers = new int[10, 10];
int[,] array = GetArray(rows, columns);
PrintArray(array);

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

if (m > numbers.GetLength(0) || n > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет"); // на значении m 55 n 55 пишет, на значении 1 и 7 все равно ставит 0
}
else
{
    Console.WriteLine($"значение элемента {m} строки и {n} столбца равно {numbers[m-1,n-1]}"); //{numbers[m-1,n-1]}
} //почему то не работает

int[,] GetArray(int a, int b)
{
    int[,] result = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            result[i, j] = new Random().Next(1, 10); // [0,0] , [0,1] , [0,2]....//[1,0], [1,1] , [1,2]
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) // GetLength(0) - длина строки
    {
        for (int j = 0; j < arr.GetLength(1); j++) // GetLength(1) - длина столбцов
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
