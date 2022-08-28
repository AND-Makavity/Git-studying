int first = new Random().Next(1, 10);
int second = new Random().Next(1, 10);
int max = 0;
int min = 0;

if (first > second)
{
    max = first;
    min = second;
}
else
{
    min = first;
    max = second;
}
Console.WriteLine($"first = {first}");
Console.WriteLine($"second = {second}");
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
