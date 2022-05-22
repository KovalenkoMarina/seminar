double[] array = new double[10];
for (int i = 0; i<array.Length; i++)
{
    array[i] = new Random().NextDouble()*10;
    Console.WriteLine($"{array[i]}");
}

double min = 1;
double max = 0;
int count = array.Length;

for (int i = 0; i<count; i++)
{
    if (array[i]>max)
    {
        max = array[i];
    }
}
for (int i = 0; i<count; i++)
{
    if (array[i]<min)
    {
        min = array[i];
    }
}

Console.WriteLine("Максимальный элемент " + max);
Console.WriteLine("Минимальный элемент " + min);
Console.WriteLine(max-min);