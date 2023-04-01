// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

int ReadInt(string message)
{
    System.Console.Write($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int ax = ReadInt ("Координата х первой точки");
int ay = ReadInt ("Координата y первой точки");
int bx = ReadInt ("Координата х второй точки");
int by = ReadInt ("Координата y второй точки");

int koordX = (ax - bx);
int koordY = (ay - by);
double W = Math.Sqrt(Math.Pow(koordX,2) + Math.Pow(koordY,2));
System.Console.Write($"Показать результат {W:f2}");
//$ знак подстановки который позволяет внутри строки писать переменные в {}

