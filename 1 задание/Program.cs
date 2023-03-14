double GetNum(double A, double B)
{
    double pow;
    pow = Math.Pow(A,B);
    return pow;
}
Console.Clear();
Console.WriteLine("Введите два числа");
double a = Double.Parse(Console.ReadLine());
double b = Double.Parse(Console.ReadLine());
double result = GetNum(a,b);
Console.WriteLine($"Результат: {result}");