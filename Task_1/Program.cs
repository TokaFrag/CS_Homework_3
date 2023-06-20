// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void Print(string text)
{
    Console.WriteLine(text);
}

double GetIntNumber()
{
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}

void CalculateDistance(double x1, double y1, double x2, double y2, double z1, double z2)
{
    double result = Math.Round((Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z2 - z1) * (z2 - z1))), 2);
    Print($"The distance between the points will be {result}");

}

Print("Input dot A (x,y,z)");
double dotAX1 = GetIntNumber();
double dotAY1 = GetIntNumber();
double dotAZ1 = GetIntNumber();
Print("Input dot B (x,y,z)");
double dotAX2 = GetIntNumber();
double dotAY2 = GetIntNumber();
double dotBZ1 = GetIntNumber();
CalculateDistance(dotAX1, dotAY1, dotAX2, dotAY2, dotAZ1, dotBZ1);
