
Console.WriteLine("Введите трехзначное число ");
string a = Console.ReadLine();
int b = Convert.ToInt32(a);
if (99<b && b<1000) Console.WriteLine(a[1]);
else Console.WriteLine("Вы ввели неправильное число");

