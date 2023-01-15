
Console.WriteLine("Введите число от 10 до 99");
string a = Console.ReadLine();
int b = Convert.ToInt32(a);
if (9<b && b<100) 
{
    if (a[0] > a[1]) Console.WriteLine(a[0]);
    else Console.WriteLine(a[1]);
}
else Console.WriteLine("Вы ввели неправильное число");

