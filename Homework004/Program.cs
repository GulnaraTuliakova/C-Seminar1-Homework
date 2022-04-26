//Показать четные числа от 1 до N
Console.WriteLine("Показать четные числа от 1 до n");
Console.Write("Введите число n: ");
int b =  int.Parse(Console.ReadLine());
int a = 1;
while (a >= 1 && a < b)
{
   if (a % 2 == 0)
   {
   Console.Write(a + " ");   
   } 
   a++;
}

