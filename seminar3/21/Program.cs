// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// // A (3,6,8); B (2,1,-7), -> 15.84

// // A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("write new point A");
    Console.Write("x    ");int x =int.Parse(Console.ReadLine());
    Console.Write("y    ");int y =int.Parse(Console.ReadLine());
    Console.Write("z    ");int z =int.Parse(Console.ReadLine());

Console.WriteLine("write new point B");
    Console.Write("x    ");int x1 =int.Parse(Console.ReadLine());
    Console.Write("y    ");int y1 =int.Parse(Console.ReadLine());
    Console.Write("z    ");int z1 =int.Parse(Console.ReadLine());

double Decision(double x, double x1, 
                double y, double y1, 
                double z, double z1){
  return Math.Sqrt(Math.Pow((x1-x), 2) + 
                   Math.Pow((y1-y), 2) + 
                   Math.Pow((z1-z), 2));
}

double segmentLength =  Math.Round (Decision(x, x1, y, y1, z, z1), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");