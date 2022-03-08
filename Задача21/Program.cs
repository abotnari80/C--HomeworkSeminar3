double[] aPoints = new double[3];
double[] bPoints = new double[3];

Console.WriteLine("Введите координаты для точки A:");
Console.WriteLine("X:");
aPoints[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Y:");
aPoints[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z:");
aPoints[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты для точки B:");
Console.WriteLine("X:");
bPoints[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y:");
bPoints[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z:");
bPoints[2] = Convert.ToInt32(Console.ReadLine());

double answer = Math.Sqrt((bPoints[0] - aPoints[0])*(bPoints[0] - aPoints[0]) + (bPoints[1] - aPoints[1])*(bPoints[1] - aPoints[1]) + (bPoints[2] - aPoints[2])*(bPoints[2] - aPoints[2]));
Console.WriteLine(answer);