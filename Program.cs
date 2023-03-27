// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через пробел");
double []array = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
int count=0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i]>0)
  {
    count++;
  }
}
Console.WriteLine("Колличество введенных чисел больше 0 = "+count);



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



// Console.Write("Найдёт точку пересечения двух прямых, заданных уравнениями ");
// Console.ForegroundColor = ConsoleColor.Red;
// Console.WriteLine("y = k1*x+b1, y=k2*x+b2.");
// Console.ResetColor();
// Console.Write("Значения ");
// Console.ForegroundColor = ConsoleColor.Red;
// Console.Write("k1, k2, b1, b2 ");
// Console.ResetColor();
// Console.WriteLine("задать самостоятельно.");
// Console.WriteLine("(для продолжения нажмите клавишу)");
// Console.ReadKey();
// Console.WriteLine();
// Console.WriteLine("Введите угловой коэффициент первой прямой k1");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите угловой коэффициент первой прямой b1");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите угловой коэффициент первой прямой k2");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите угловой коэффициент первой прямой b2");
// double b2 = Convert.ToDouble(Console.ReadLine());
// if (k1==k2)
//   {
//   Console.WriteLine("Прямые параллельные и не имеют точки пересечения");
//   }
//   else
//   {
//   double x=Math.Round((b1-b2)/(k2-k1),2);
//   double y=Math.Round((k1*((b1-b2)/(k2-k1))+b1),2);
//   Console.WriteLine("Точка пересечения двух прямых: x="+x+", y="+y);
// }