// Напишите программу, которая принимает на вход число N и выдаёт таблицу кубов чисел от 1 до N

int InputInt(string message)
{
    System.Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
string CubicTable(int n)
{
    string output = String.Empty;
    for (int i = 1; i <= n; i++)
    {
        output = output + i * i * i;
        if (i < n) output = output + ", ";
    }
    return output;
}
int number = InputInt("введите число больше 0");
string toPrint = CubicTable(number);
System.Console.WriteLine(toPrint);



