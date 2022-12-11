// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double k1 = InputeNum();

double b1 = InputeNum();

double k2 = InputeNum();

double b2 = InputeNum();

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Пересечение в точке: ({x};{y})");

double InputeNum()
{
    Console.WriteLine("Введите числа в порядке k1, b1, k2, b2 ");
    bool uinput = double.TryParse(Console.ReadLine(), out double num);
    if (uinput)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}