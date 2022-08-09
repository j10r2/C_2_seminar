Console.WriteLine("введите первое число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("введите второе число:");
int b = int.Parse(Console.ReadLine());

if (b == a * a)
{
    Console.WriteLine("второе число является квадратом первого");
}
else
{
    if (a == b * b)
{
    Console.WriteLine("первое число является квадратом второго");
}
else
{
    Console.WriteLine("ни одно число не является квадратом другого");
}
}