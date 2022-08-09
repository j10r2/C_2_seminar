Console.WriteLine("Введите трёхзначное (целое) число:");
while (true){
try
    {
        int a = int.Parse(Console.ReadLine());
        while ((Math.Abs(a) / 100 < 1) || (Math.Abs(a) / 100 >= 10))
            {
                Console.WriteLine();
                Console.WriteLine("Введённое число не трёхзначное");
                Console.WriteLine("сделай нормально");
                a = int.Parse(Console.ReadLine());
            }
        Console.WriteLine("вторая цифра числа - " + (a % 100)/10);
    break;
    }
catch
    {
        Console.WriteLine("Юзер, это не число, не зли машину о_0");
        Console.WriteLine();
    }
}