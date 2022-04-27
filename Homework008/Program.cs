//Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Выясним, кратно ли число задуманному");
Console.Write("Введите задуманное число: ");
int num1 =  int.Parse(Console.ReadLine());
if (num1 <= 0)
{
Console.Write("Задумайте положительное первое число");
}
if (num1 > 0)
{
    Console.Write("Введите другое число, кратность которого надо определить: ");
    int num2 =  int.Parse(Console.ReadLine());
    if (num2 <= 0)
    {
     Console.Write("Введите положительное второе число");   
    }
    if (num2 > 0)
    {
        if (num2 < num1)
        {
            Console.Write("Второе число должно быть больше или равно первому");
        }
             if (num2 >= num1 && num2 % num1 == 0)
            {  
                Console.Write("Число " + num2 + " кратно " + num1);
            }
            if (num2 >= num1 && num2 % num1 > 0)
            {
                int residual = num2 % num1;
                Console.Write("Числo " + num2 + " не кратно " + num1 + ". Остаток от деления составляет " + residual); 
            } 
    }
    
}    

