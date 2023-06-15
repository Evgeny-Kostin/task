//Напишите программу, которая на вход принимает два числа и выдает, 
//какое число больше, а кокое меньше
// a=5 b=7 -> max=7
// a=2 b=10 -> max=10
// a=-9 b=-3 -> max=-3


Console.WriteLine("Введите число A: ");
Console.WriteLine("Введите число B: ");
int numberA = int.Parse(Console.ReadLine()!); 
int numberB = int.Parse(Console.ReadLine()!);
int max = numberA - numberB;
int min = numberA - numberB;
if (numberA>numberB) {
    Console.WriteLine(max=numberA);
}
else if (numberB>numberA)
{
    Console.WriteLine(max=numberB);
    Console.WriteLine(min=numberA);
}
//if (numberB>numberA) {
   // Console.WriteLine(max=numberB);
else if (numberA<numberB) {
    Console.WriteLine(min=numberA);
}
if (numberB<numberA) {
    Console.WriteLine(min=numberB);
}

// Добрый день! Задачу 2 можно оптимизировать не прописывая столько условий:
//Console.Write("Введите число A: ");
//int numberA = int.Parse(Console.ReadLine()!);
//Console.Write("Введите число B: ");
//int numberB = int.Parse(Console.ReadLine()!);
//int max = numberA;
//int min = numberB;
//if (max < min)
//{
//max = numberB;
//min = numberA;
//}
//Console.WriteLine("max = " + max + " min = " + min);
//Обратите внимание, в переменной max и min уже по умолчанию присвоены значения A и B, поэтому достаточно сделать лишь одну проверку и если окажется, что A < B мы просто перезапишем значения, если нет значит всё верно и так оставим!
//В 4 задаче можно удалить ветку с проверкой numberA, так как оно лежит по умолчанию уже в переменной max.
//В 6 задаче ошибка в условии, следовало поставить вместо деления нацело(/), деление с остатком(%).
//8 задача отлично, в целом хорошо справились с домашней работой!
