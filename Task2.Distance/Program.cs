// Напишите программу, которая принимает на вход координаты 2-х точек и 
// находит расстояние между ними в 3D пространстве
int InputInt(string message)
{
    System.Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
double GetDistance(int a1, int a2, int a3, int b1, int b2, int b3)
{
    double distance = Math.Sqrt((b1-a1)*(b1-a1)+(b2-a2)*(b2-a2)+(b3-a3)*(b3-a3));
    return distance;
}
int x1 = InputInt("введите координату х первой точки");
int y1 = InputInt("введите координату y первой точки");
int z1 = InputInt("введите координату z первой точки");
int x2 = InputInt("введите координату х второй точки");
int y2 = InputInt("введите координату y второй точки");
int z2 = InputInt("введите координату z второй точки");
//double howLong =GetDistance (x1,y1,z1,x2,y2,z2);// либо так - в этом случае норм без именования
double howLong =GetDistance (a1:x1,b1:x2,a2:y1,b2:y2,a3:z1,b3:z2);
System.Console.WriteLine("расстояние между точками - " + howLong);

