/* Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите номер дня недели в РФ");
bool isDay = int.TryParse(Console.ReadLine(), out int day);

if (!(isDay) || day < 1 || day > 7)
{
    Console.WriteLine("Это не номер дня недели в РФ");
}
else
{
    if (day < 6)
    {
        Console.WriteLine("Рабочий день");
    }
    else
    {
        Console.WriteLine("Выходной");
    }
}