Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите другое число");
int b = Convert.ToInt32(Console.ReadLine());
double c = a%b;
if (c == 0) Console.WriteLine("Кратные числа");
else Console.WriteLine( $"Остаток от деления: {c}");