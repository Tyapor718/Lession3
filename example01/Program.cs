//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int ReadIn (string m)
{
    Console.WriteLine ($" {m} >");
    return Convert.ToInt32 (Console.ReadLine ());
}
int GerQuorter (int x, int y)
{
    if (x > 0 && y> 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    if (x > 0 && y < 0)
    {
        return 4;
    }
    return 0;
}
int x= ReadIn ("Введите х");
int y = ReadIn ("Введите y");
int numberQuorter =  GerQuorter (x , y);
Console.Write ($"Номер четверти для x,y ({x},{y}) равна {numberQuorter} ");
