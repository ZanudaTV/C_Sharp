/* Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и метод который возводит число A
 в натуральную степень B. Задание должно быть выполнено в методе.
 В методе не должно быть вывода в консоль. Не использовать Math.Pow() */


int a = InputeA();
int b = InputeB();
int resalt = a;
int anser = MakeHowMathPow(a, b);
Console.WriteLine($"Ответ {anser} ");


int MakeHowMathPow(int a, int b)
{
    for (int i = 1; i < b; i++)
    {
        resalt = resalt * a;
    }
    return resalt;
}
int InputeA()
{
    Console.WriteLine("Введите число А ");
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
int InputeB()
{
    Console.WriteLine("Введите число B ");
    bool uinput2 = int.TryParse(Console.ReadLine(), out int b);
    if (uinput2)
    {
        return b;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}
