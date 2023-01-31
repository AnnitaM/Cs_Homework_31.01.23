// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Enter a number ");
string num = Console.ReadLine();
string number = num.ToString();
int[] array = new int[number.Length];
Console.WriteLine(array.Length);
if (array.Length <= 2)
{
    Console.WriteLine($"There is no thrid digit");
    return;
}
else
{
    int find = int.Parse(num[2].ToString());
    Console.WriteLine($"Thrid digit is {find}");
}