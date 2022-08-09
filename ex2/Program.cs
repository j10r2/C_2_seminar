int a = new Random().Next(100, 999);

Console.WriteLine(a);

int b = a / 100;
int c = a % 10;

Console.WriteLine(b);

Console.WriteLine(c);

Console.WriteLine(b * 10 + c);