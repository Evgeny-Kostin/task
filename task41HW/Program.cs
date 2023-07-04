// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int length = Prompt("Введите колличств элементов >");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Колличеств чисел больше 0- {CountPositiveNumbers (array)}");

//Считать число с консоли
int Prompt(string message)
{
    Console.Write(message); //вывести сообщение
    string value = Console.ReadLine(); //считывает с консоли строку
    int result = Convert.ToInt32(value); //преобразует строку в целое число
    return result;
}

// вывод массива
int[] InputArray(int length);

{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1} -й элемент");
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"а[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
