/*Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine();
Console.Write(number[0]);
Console.WriteLine(number[2]);*/

int number = new Random().Next(100, 1000);
Console.Write(number/100);
Console.WriteLine(number%10);