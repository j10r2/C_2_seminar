Console.WriteLine("Введите трёхзначное (целое) число:");
int count = 0;
while (count < 10){
try
    {
        int a = int.Parse(Console.ReadLine());
        string num = Convert.ToString(a);
        int lgt = num.Length;
        if (lgt < 3)
            {
                Console.WriteLine("третьего знака нет");
            }
        else
            {
                Console.WriteLine(num.Substring(2, 1));
            }
        break;
    }
catch
    {
        Console.WriteLine("Юзер, это не число, не зли машину о_0");
        Console.WriteLine();
        count ++;
        if (count == 10)
            {
                Console.WriteLine("Ты упорный юзер, но терпение машины закончилось");
            }
    }
}
