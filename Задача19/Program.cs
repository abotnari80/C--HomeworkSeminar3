Console.WriteLine("Введите 5-ти значное число:");
int value = Convert.ToInt32(Console.ReadLine());
int[] array = new int[3];
int i = 0;

while (i < 2)
{
    array[i] = value % 10;
    value = value / 10;
    i = i + 1;
}

array[2] = value % 10;
int halfValue = (array[0] * 100) + (array[1] * 10) + array[2];

if (value == halfValue)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}