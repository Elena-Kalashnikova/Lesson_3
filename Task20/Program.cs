// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A: ");
Console.Write("X: ");
int x_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int y_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("X: ");
int x_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y: ");
int y_2 = Convert.ToInt32(Console.ReadLine());

double dist = GetDistance(x_1, y_1, x_2, y_2);
double distRound = Math.Round(dist, 2, MidpointRounding.ToZero);
Console.WriteLine("Растояние между A и B: " + distRound);

double GetDistance(int a_1, int a_2, int b_1, int b_2)
{
    double firstCatet = b_1 - a_1;
    double secondCatet = b_2 - a_2;
    double distan = Math.Sqrt(firstCatet * firstCatet + secondCatet * secondCatet);
    return distan;
}

