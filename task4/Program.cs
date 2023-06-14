//Напишите программу, которая на вход принимает три числа и выдает, 
//максимальое из этих чисел.
// 2 3 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите числa A B C: ");

int numberA = int.Parse(Console.ReadLine()!); 
int numberB = int.Parse(Console.ReadLine()!);
int numberC = int.Parse(Console.ReadLine()!);

int max = numberA;

if (numberA>max) {
    Console.WriteLine(max=numberA);
}
if (numberB>max)
{
    Console.WriteLine(max=numberB);
}
if (numberC>max) {
   Console.WriteLine(max=numberC);
}

Console.Write("max = ");
Console.WriteLine(max);
