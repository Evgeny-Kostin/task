// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10



// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }


// void Transformation(int res)
// {
//     string result = string.Empty;
//     while (res > 0)
//     {

//         int remainder = res % 2;
//         res /= 2;
//         result = remainder.ToString() + result;
//     }

//     Console.Write($"В двоичном коде число равно: " + result);
// }

// int number = Prompt("Введите число: ");
// Transformation(number);