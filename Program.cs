// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Add first number:");
string? numberStringA = Console.ReadLine();
int numberA = Convert.ToInt32(numberStringA);
Console.WriteLine("Add second number:");
string? numberStringB = Console.ReadLine();
int numberB = Convert.ToInt32(numberStringB);
int max = 0, min = 0;
if (numberA > numberB)
{
    max = numberA;
    min = numberB;
}    
else
{
    max = numberB;
    min = numberA;
}
Console.Write("Max:");
Console.WriteLine(max);
Console.Write("Min:");
Console.WriteLine(min);