int a = new Random().Next(10, 100);
Console.WriteLine(a);
int b = a / 10;
int c = a % 10;
if (b == c)
{
    Console.WriteLine("числа равны");
}
else
{
if (b > c)
{
    Console.WriteLine(b);
}
else
{
    Console.WriteLine(c);
}
}