// Задача№13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78  -> третьей цифры нет
//32679 -> 6


Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());                 
int secondValue = number%10;                                //находим второе число
//Console.WriteLine(secondValue + " -> Третье число"); 
if (number<100) {
    Console.WriteLine("Третьей цифры нет");
}
Console.WriteLine(secondValue + " -> Третье число");

