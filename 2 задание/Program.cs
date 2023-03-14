int GetNum(int A)
{
    int sum=0;
    while (A>=0)
    {
        int s = A%10;
        sum +=s;
    }
    return sum;
}
Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int result = GetNum(a);
Console.WriteLine($"Результат: {result}");
