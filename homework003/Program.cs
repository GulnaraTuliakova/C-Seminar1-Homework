//Выяснить является ли число чётным
Console.WriteLine("Определим, является ли число четным");
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
Console.WriteLine(a + " число четное");
else
Console.WriteLine(a + " число нечетное");