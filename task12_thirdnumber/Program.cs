Console.WriteLine("Введите целое число ");
string a = Console.ReadLine();
int x = Convert.ToInt32(a);
if (x > 99) 
{
    Console.WriteLine(a[2]);
}
else Console.WriteLine("Нет третьей цифры.");