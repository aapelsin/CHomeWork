// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число больше 1 - ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
while(count <= num)
{
   if (count %2 == 0)
   {
      Console.Write(count);
      if (count != num && count != (num-1))
         {
         Console.Write(", ");
         }
      else
         {
         Console.Write(".");
         }  
   }
      count = count + 1;
}