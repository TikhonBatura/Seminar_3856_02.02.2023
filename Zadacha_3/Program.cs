// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

//Евклидово растояние

Console.WriteLine("Entre number X1 ");
double numX1 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Y1 ");
double numY1 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number X2 ");
double numX2 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Y2 ");
double numY2 = double.Parse(Console.ReadLine());

double numSQRT = Math.Pow((numX1-numX2),2)+Math.Pow((numY1-numY2),2);

double result = Math.Sqrt(numSQRT);

Console.Write(result.ToString("c2"));