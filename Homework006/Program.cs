//Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Наша задача показать наибольшую цифру выбранного числа из отрезка от 10 до 99");
Console.WriteLine("Программа выбирает любое число из указанного отрезка и......");
 int num = new Random().Next(9,100);
Console.WriteLine("Это число: " + num);
int num1 = num / 10;
int num2 = num % 10;
if (num1 > num2)
{
 Console.WriteLine("Наибольшая цифра числа "  + num + ": " + num1);   
}
if (num2 > num1)
{
 Console.WriteLine("Наибольшая цифра числа "  + num + ": " + num2);   
}
if (num2 == num1)
{
 Console.WriteLine("Обе цифры числа "  + num + " равны. Это цифра: " + num2);   
}





