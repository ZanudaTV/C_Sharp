/* Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет. Не использовать string[]
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int num = int.Parse(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("Нет третьего числа");
}
else
{
    while (num > 999)
    {
        num /= 10;
    }
    int resalt = num / 10;
    int resalt2 = num - resalt * 10;
    Console.WriteLine(resalt2);
}

