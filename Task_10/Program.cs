//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Enter a number ");
int num = int.Parse(Console.ReadLine());
int scndDig = (num % 100 - num % 10) / 10;
if (num < 100 || num > 999)
{
    Console.Write("Error"); return;
}
else
{
    Console.WriteLine($"Second digit is {scndDig}");
}