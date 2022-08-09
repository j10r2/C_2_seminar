Console.WriteLine("введите первое число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("введите второе число:");
int b = int.Parse(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
    Console.WriteLine();
    Console.WriteLine("остаток от деления равен " + a % b);
}