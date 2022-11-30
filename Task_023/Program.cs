// Task_023
Console.Clear();

Console.Write("Введите число: ");
double n = Convert.ToDouble(Console.ReadLine());

double i = 1;
while (i <= n)
{
    double m = Math.Pow(i , 3);
    Console.Write($"{m} ");
    i++;
}