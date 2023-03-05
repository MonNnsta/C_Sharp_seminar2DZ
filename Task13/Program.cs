int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int ThirdRank(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}

bool ValidateNum(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет! ");
        return false;
    }
    return true;

}

int num = Prompt("Введите число -> ");
if (ValidateNum(num))
{

    Console.WriteLine($"Третья цифра в числе -> {ThirdRank(num)}");
}