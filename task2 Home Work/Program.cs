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