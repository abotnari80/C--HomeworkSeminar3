Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int cubeNum = 1;
int cube = 0;

while (cubeNum < number)
{
    cube = cubeNum * cubeNum * cubeNum;
    Console.Write(cube);
    Console.Write(", ");
    cubeNum = cubeNum + 1;
}

cube = cubeNum * cubeNum * cubeNum;
Console.WriteLine(cube);