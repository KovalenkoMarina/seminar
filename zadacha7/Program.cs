Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Список квадратов чисел от 1 до {n} ");
int a = 1;
while (a <= n)
{
    int b = a*a;
    Console.Write(b + " ");
    a++;
}
