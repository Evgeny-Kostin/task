//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int Number = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int Number) {
  if (Number == 6 || Number == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (Number < 1 || Number > 7) {
    Console.WriteLine("Введите цифру от 1 до 7! ");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(Number);
