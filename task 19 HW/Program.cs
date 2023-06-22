// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine(); 
СheckForPolydrome(num);
void СheckForPolydrome(string number)
{
    if (num[0]==num[4] && num[1]==num[3])
    {
        Console.WriteLine($"{num} - палиндром.");
    }
        else 
        {
            Console.WriteLine($"{num} - НЕ палиндром.");
        }
// else if (num<10000 && num>100000)
// {
//     Console.WriteLine("неверное число");
// }
}
Console.WriteLine("Все супер, или Мыж в России");

