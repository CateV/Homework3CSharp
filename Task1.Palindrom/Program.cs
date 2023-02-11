int InputInt(string message)
{
    System.Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
int TurnOver(int number)
{
    int newNumber = 0;
    while (number > 0)
    {
        newNumber = newNumber * 10 + number % 10;
        number = number / 10;
    }
    return newNumber;
}
int number = InputInt("введите число");
int secondNumber = TurnOver(number);

    if (number == secondNumber)
        System.Console.WriteLine($"Да, {number}- палиндром");
    else
        System.Console.WriteLine($"Нет, {number} не палиндром");


