// По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int squareB = b * b;
if (a == squareB)
{
Console.WriteLine("Первое число является квадратом второго и равно " + squareB);
}
else
{
Console.WriteLine("Первое число  не является квадратом второго"); 
}