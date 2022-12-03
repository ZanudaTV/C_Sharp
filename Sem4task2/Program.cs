/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int i = InputeNum();
int sum = 0;
int anser = SumComponentsNumber();
Console.WriteLine($"сумма всех цифр в числе равна: {anser}");

int SumComponentsNumber()
{
while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
return sum;
}

int InputeNum()
{
    Console.WriteLine("Введите число ");
    bool uinput = int.TryParse(Console.ReadLine(), out int а);
    if (uinput)
    {
        return а;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}