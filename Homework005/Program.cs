//Показать вторую цифру трёхзначного числа

Console.WriteLine("Найдем вторую цифру в трехзначном числе");
Console.Write("Введите 3-х значное число: ");
int a =  int.Parse(Console.ReadLine());
if (a > 99 && a < 1000)
{
int num1 = a % 100;
int num2 = num1 / 10;
Console.WriteLine("Вторая цифра: " + num2);
}
else
{
Console.WriteLine("Число не 3-х значное!");
}
