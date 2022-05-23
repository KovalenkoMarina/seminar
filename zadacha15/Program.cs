Console.Clear();
Console.WriteLine("Выяснить являются ли три числа сторонами треугольника");
Console.Write("Введите первую сторону треугольника: ");
int firstSide =  int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите вторую сторону треугольника: ");
int secondSide =  int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите третью сторону треугольника: ");
int thirdSide =  int.Parse(Console.ReadLine() ?? "0");

if ((firstSide+secondSide>thirdSide) && (firstSide+thirdSide>secondSide) && (secondSide+thirdSide>firstSide))
    Console.WriteLine("Отрезки являются сторонами треугольника");
else
    Console.WriteLine("Отрезки НЕ являются сторонами треугольника");

