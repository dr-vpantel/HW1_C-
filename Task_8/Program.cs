// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine()); 
int evenNumber = 2;

if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.WriteLine($"Четное число от 1 до N: {evenNumber}");
        evenNumber = evenNumber + 2;
    }
}