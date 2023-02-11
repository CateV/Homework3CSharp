// Напишите программу, которая принимает на вход число N и выдаёт таблицу кубов чисел 
//от 1 до N

int InputInt(string message)
{
    System.Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int number = InputInt("введите число");

for (int i=1; i<=number; i++)
{
    int cube = i*i*i;
    System.Console.Write($"{cube}\t");
}

