double[] aPoints = new double[3];
double[] bPoints = new double[3];

Console.WriteLine("Введите координаты для точки A");
Console.Write("X:");
aPoints[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Y:");
aPoints[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("Z:");
aPoints[2] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты для точки B");
Console.Write("X:");
bPoints[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Y:");
bPoints[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("Z:");
bPoints[2] = Convert.ToDouble(Console.ReadLine());

double answer = Math.Sqrt((bPoints[0] - aPoints[0])*(bPoints[0] - aPoints[0]) + (bPoints[1] - aPoints[1])*(bPoints[1] - aPoints[1]) + (bPoints[2] - aPoints[2])*(bPoints[2] - aPoints[2]));
Console.WriteLine(answer);