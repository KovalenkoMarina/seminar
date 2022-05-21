Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());
int count = 0;
while (n > 0)
{
    n = n/10;
    count++;
}
Console.WriteLine($"Цифр в числе {count}");

