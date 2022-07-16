/*Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double Distance(double Ax, double Ay, double Az, double Bx, double By, double Bz)
{
    return Math.Round(Math.Sqrt(Math.Pow(Bx-Ax,2)+Math.Pow(By-Ay,2)+Math.Pow(Bz-Az,2)),2);
}

Console.WriteLine(Distance(3, 6, 8, 2, 1, -7));
Console.WriteLine(Distance(7, -5, 0, 1, -1, 9));