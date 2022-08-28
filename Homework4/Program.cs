int N = new Random().Next(1, 20);
Console.WriteLine($"Программа показывает все чётные числа от 1 до {N}");
int index;

for (index = 1; index <= N; index++)
{
    if (index % 2 == 0) Console.Write($"{index} ");
}
