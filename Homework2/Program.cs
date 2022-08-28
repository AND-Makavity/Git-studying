int a1 = new Random().Next(1, 10);
int a2 = new Random().Next(1, 10);
int a3 = new Random().Next(1, 10);
int max = a1;

if (a2 > max) max = a2;
if (a3 > max) max = a3;

Console.WriteLine($"{a1}, {a2}, {a3}");
Console.WriteLine($"max = {max}");