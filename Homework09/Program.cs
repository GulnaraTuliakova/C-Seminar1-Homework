//Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Найдем третью цифру в числе");
Console.Write("Введите целое число n: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 && num > -100)
      {
      Console.Write("В числе нет третьей цифры");
      }
if (num >= 100)
      {
           while (num >= 1000)
            {
            num = num / 10;
            }
      Console.WriteLine("Третья цифра числа " + num % 10); 
      }
          
if (num <= -100)
        {
        while (num <= -1000)
            {
            num = num / 10;
            }
      Console.WriteLine("Третья цифра числа " + (-num) % 10); 
      }

