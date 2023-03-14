int[] GetSize(int size)
{
    int[] result = new int[size];
    for(int i=0;i<size;i++)
    {
        result[i]=new Random().Next(99);
    }
    return result;
}
Console.Clear();
Console.WriteLine("Введите число (размер массива)");
int a = int.Parse(Console.ReadLine());
int[] array = GetSize(a);
Console.WriteLine($"[   {String.Join(", ",array)}   ]");
for (int i = 0; i<array.Length - 1;i++)
{
    Console.Write($"{array[i]}, ");
}
Console.Write($"{array[array.Length-1]}");
foreach(var el in array){
    Console.Write($"{el} ");
}
