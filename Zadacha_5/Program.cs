


Console.WriteLine("Entre number X1 ");
double numX1 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Y1 ");
double numY1 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Z1 ");
double numZ1 = double.Parse(Console.ReadLine());



Console.WriteLine("Entre number X2 ");
double numX2 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Y2 ");
double numY2 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Z2 ");
double numZ2 = double.Parse(Console.ReadLine());



double numSQRT = Math.Sqrt(Math.Pow((numX1-numX2),2)+Math.Pow((numY1-numY2),2)+Math.Pow((numZ1-numZ2),2));

Console.Write(numSQRT);