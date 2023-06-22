// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов 
// и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

const int ARRAYSIZE = 8;
int[] randomBinaryArray = RandomBinaryArray();
PrintArray(randomBinaryArray);

int[] RandomBinaryArray()
{
    int[] array = new int[ARRAYSIZE];
    Random random = new Random();

    for(int i = 0; i < ARRAYSIZE; i++)
        array[i] = random.Next(1, 9);

    return array;
}

void PrintArray(int[] array)
{
    foreach(var element in array)
        Console.Write($"{element} ");

    Console.WriteLine();
}