Console.Clear();

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool WeekendYes(int Weekend)
{
    if (Weekend < 5)
    {
        return false;
    }
    return true;
}

int Weekend = Promt("Введите № дня недели от 1 до 7 ");

if (WeekendYes(Weekend))
    Console.WriteLine("Повезло,повезло, это выходной день! ");
else
    Console.WriteLine("Пора на завод, работяги! ");
