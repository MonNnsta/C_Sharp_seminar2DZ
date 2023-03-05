Console.Clear();

Console.Write("Введите трёхзначное число -> ");
int num = int.Parse(Console.ReadLine() ?? "");

if (num < 100 || num >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, повторите ввод! ");
    return;    
}

else
{
    Console.WriteLine($"Введенное число {num} ");

    int solutionNum = num / 10 % 10;
    Console.WriteLine($"Вторая цифра в веденном числе -> {solutionNum} ");
}