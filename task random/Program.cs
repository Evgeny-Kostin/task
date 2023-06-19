//Напишите программу, которая вводит случайное число на отрезке
//[10,99] и показывает цифру числа.
//78->8, 12->2, 85->8.

Console.Clear();
int number = new Random().Next(10, 100); //если оставить пустым вместит в себя все числа доступные в диапазоне int.
// если одно число(100) то сгенерит от 0-100. (10,100) в методе Next левая граница включ, правая нет поэтому на 1 больше.
int firstValue = number/10; // вводим переменную для хранения наших вычислений
int secondValue = number%10;
Console.WriteLine(number + " " + firstValue + " " + secondValue); // выводим для проверки вводимое число и полученные результаты вычислений.
// провести сравнение чисел через ветвление условие:
if (firstValue>secondValue)
{
    Console.WriteLine(firstValue);
}
else if(firstValue == secondValue)
{
    Console.WriteLine("значения равны");
}
else
{
    Console.WriteLine(secondValue);
}