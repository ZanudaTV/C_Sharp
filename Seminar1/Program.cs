int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int Max = 0;
int Min = 0;
if (num1 > num2)
{
    Max = num1;
    Min = num2;
}
else 
{
    Max = num2;
    Min = num1; 
}

Console.WriteLine(Max);
Console.WriteLine(Min);