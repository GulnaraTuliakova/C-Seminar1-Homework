//По заданному номеру дня недели вывести его название

Console.WriteLine("Введите номер дня недели. (Нумерация начинается с понедельника.)");
int a = int.Parse(Console.ReadLine());
if ( a == 1 )
{
 Console.WriteLine( a + " день недели это понедельник");   
}
else if ( a == 2 )
{
 Console.WriteLine( a + " день недели это вторник");   
}
if ( a == 3 )
{
 Console.WriteLine( a + " день недели это среда");   
}
if ( a == 4 )
{
 Console.WriteLine( a + " день недели это четверг");   
}
if ( a == 5 )
{
 Console.WriteLine( a + " день недели это пятница");   
}
if ( a == 6 )
{
  Console.WriteLine( a + " день недели это суббота");  
}
if ( a == 7 )
{
 Console.WriteLine( a + " день недели это восресенье");   
}
else if (a > 7 || a < 1)
{
Console.WriteLine("Число " + a + " введено неверно. В неделе 7 дней.");   
}
