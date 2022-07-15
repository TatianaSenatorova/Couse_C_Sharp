/*Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/

double Distance(double Ax, double Ay, double Bx, double By)
{
    return Math.Round(Math.Sqrt(Math.Pow(Bx-Ax,2)+Math.Pow(By-Ay,2)),4);
}
Console.WriteLine(Distance(3, 6, 2, 1));