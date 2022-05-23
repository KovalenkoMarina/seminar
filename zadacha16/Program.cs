// Console.Clear();
// Console.WriteLine("Написать программу преобразования десятичного числа в двоичное");
// Console.Write("Введите число: ");
// int NumberN =  int.Parse(Console.ReadLine() ?? "0");
// int i = 0;
// int Number = NumberN;
// while (Number>0)
// {
//     Number /= 2;
//     i++;
// }

// int[] array = new int[i];

// i = 0;

// while (NumberN>0)
// {
//     if (NumberN%2 == 0)
//     {
//         NumberN /=2;
//         array[i] = 0;
//     }
//     else
//     {
//         NumberN = (NumberN - 1)/2;
//         array[i] = 1;
//     }
//     i++;
// }
// Array.Reverse(array);
// foreach (int k in array)
//     Console.Write($"{k} ");

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = 0;
string result = " ";

while(a > 0)
{
    b = a % 2;
    result = b + result;
    a = a / 2;
  
}
Console.WriteLine(result);


