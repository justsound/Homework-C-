Console.WriteLine("Введите трехзначное число ");
int a = Convert.ToInt32( Console.ReadLine());
int b = (a / 10) % 10;
if (99<a && a<1000) Console.WriteLine(b);
else Console.WriteLine("Вы ввели неправильное число");

/*
Console.WriteLine("Введите трехзначное число ");
string a = Console.ReadLine();
int b = Convert.ToInt32(a);
if (99<b && b<1000) Console.WriteLine(a[1]);
else Console.WriteLine("Вы ввели неправильное число");
*/