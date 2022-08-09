Console.WriteLine("Введите целое число (целое, пожалуйста):");
while (true)
{
    try
        {
            int a = int.Parse(Console.ReadLine());
            a = Math.Abs(a);
            if (a >= 100)
                {   
                    if (a > 999)
                        {
                        int i = 10;                    
                        while (a / i > 1000)
                            {i = i * 10;}
                        Console.WriteLine("третья цифра числа - " + (a / i) % 10);
                        }
                    else
                        {
                        Console.WriteLine("третья цифра числа - " + a % 10);
                        }
                }
            else
                {
                Console.WriteLine("третьей цифры нет");
                }
        break;
        }
catch
    {
        Console.WriteLine("Попробуйте ещё раз, цифры - это верхний ряд кнопок");
        Console.WriteLine();
    }
}