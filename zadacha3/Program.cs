Console.WriteLine("Введите числa ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = a;
if (a>b & a > c);
{
    max = a;
}
if (c > a & c > b);
{
    max = c;
}
if (b>c & b>a);
{
    max = b;
}
Console.Write("Наибольшее число = ");
Console.WriteLine(max);
