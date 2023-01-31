// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.Clear(); 
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
if (number < 1 || number > 7)
{
    Console.WriteLine("Error");
    return;
}
if (number == 6 || number == 7)
{
    Console.WriteLine("It is weekend");
}
else
{
    Console.WriteLine("It is working day");
}

    

