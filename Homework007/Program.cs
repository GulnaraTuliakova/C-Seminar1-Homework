//Удалить вторую цифру трёхзначного числа

Console.WriteLine("Удалим вторую цифру в трехзначном числе");
Console.Write("Введите положительное трехзначное число: ");
int num =  int.Parse(Console.ReadLine());
if (num > 99 && num < 1000)
{
int num1 = num / 100;
int num3 = num % 10;
Console.WriteLine("Число " + num + " без второй цифры превращается в число: " + num1 + num3 );
}
else
{
Console.WriteLine("Не верно введено число! Попробуй еще!");
}
