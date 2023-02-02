System.Console.WriteLine("Enter number: ");

int Number = int.Parse(Console.ReadLine());

int I = 1;

while(I  <= Number)
{
    Console.Write(I*Math.Pow(I, 3)+ " ");
                                                       //сделать таблицу кубов
    I+=1;

}